using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using GlobalHotKey;
using Microsoft.VisualBasic.FileIO;
using Shell32;
using SearchOption = System.IO.SearchOption;

namespace VideoSortAssistant
{
    public partial class AssistantForm : Form
    {
        const int MB = 1024 * 1024;
        HotKeyManager _hotKeyManager;

        MappingControls[] _moveMappingItems;
        MediaInfoProvider _mediaInfo = new MediaInfoProvider();

        public AssistantForm()
        {
            InitializeComponent();
            _sorter = RefreshFiltering;
        }

        string FormatKeyName(MoveMappingData data)
        {
            string s = "";
            if (data.ModifierKeys != 0)
                s = data.ModifierKeys.ToString().Replace(" ", "").Replace(",", " + ") + " + ";
            if (data.Key != 0)
            {
                string n = data.Key.ToString().Replace(" ", "").Replace(",", " + ");
                if (n.Length == 2 && n[0] == 'D')
                    n = n.Substring(1);
                s += n;
            }
            if (s == "") s = "(None)";
            return s;
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            ClearItems();
            _undoList.Clear();
            FileList_SelectedIndexChanged(FileList, EventArgs.Empty);
        }

        private void AppendButton_Click(object sender, EventArgs e)
        {
            LoadFiles();
        }

        void LoadFiles()
        {
            var prev = FileDialog.Filter;
            try
            {
                string mask = GetMask();
                FileDialog.Filter = mask + " files | " + mask;
                if (FileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var f in FileDialog.FileNames)
                    {
                        AddFile(f);
                    }
                }
                _sorter();
            }
            finally
            {
                FileDialog.Filter = prev;
            }
        }

        void AddFile(string f)
        {
            if (!File.Exists(f)) return;
            var fileItem = new FileItem(f);
            AddItem(fileItem);
            if (FileList.SelectedIndex == -1) FileList.SelectedIndex = 0;
        }

        readonly Dictionary<string,FileItem> _files = new Dictionary<string,FileItem>();
        
        void ClearItems()
        {
            _files.Clear();
            FileList.Items.Clear();
        }

        void AddItem(FileItem fileItem)
        {
            if (_files.ContainsKey(fileItem.Path)) return;
            _files.Add(fileItem.Path, fileItem);
            FileList.Items.Add(fileItem);
        }

        void RemoveItemAt(int index)
        {
            var el = (FileItem)FileList.Items[index];
            _files.Remove(el.Path);
            FileList.Items.RemoveAt(index);
        }

        class FileItem
        {
            TimeSpan? _duration;
            public string Path { get; }
            public long Size { get; }
            public TimeSpan? Duration
            {
                get => _duration;
                set
                {
                    if (_duration != null) throw new InvalidOperationException();
                    _duration = value;
                    if (value != null && Size > 0)
                        Quality = Size / (float) value.Value.TotalSeconds / 7000;
                    DurationInitialized = true;
                }
            }

            public bool DurationInitialized { get; private set; }
            public float? Quality { get; private set; }
        
            public FileItem(string path)
            {
                Path = path;
                Size = new FileInfo(path).Length;
            }

            public override string ToString()
            {
                var folder = System.IO.Path.GetFileName(System.IO.Path.GetDirectoryName(Path));
                if (folder.Length > 30)
                    folder = folder.Substring(0, 27) + "...";
                return
                    $"[{folder}] {System.IO.Path.GetFileName(Path)} | {FormatSize(Size)}" +
                    $"{(Duration != null ? " | " + (int) Duration.Value.TotalMinutes + "m" : "")} {(Quality != null ? " | Q" + (Quality.Value).ToString("F0") : "")}";
            }
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            SelectFolder(_moveMappingItems.OfType<MoveMappingControls>().First(x => x.BrowseButton == sender).PathBox);
        }

        void SelectFolder(TextBox box)
        {
            FolderBrowser.SelectedPath = box.Text;
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
                box.Text = FolderBrowser.SelectedPath;
        }

        private void FileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileItem item = GetCurrentItem();
            if (item != null)
            {
                FullPathBox.Text = item.Path;
                SizeBox.Text = FormatSize(item.Size);
                MoveCurrentTo.Enabled = true;
                OpenButton.Enabled = true;
                OpenDirButton.Enabled = true;
            }
            else
            {
                FullPathBox.Text = "";
                SizeBox.Text = "";
                MoveCurrentTo.Enabled = false;
                OpenButton.Enabled = false;
                OpenDirButton.Enabled = false;
            }
        }

        static string FormatSize(long size)
        {
            long mbs = size / MB;
            var formattedSize = (mbs >= 250) ? ((mbs / 1024f).ToString("F2") + " GB") : (mbs + " MB");
            return formattedSize;
        }

        private void FileList_DoubleClick(object sender, EventArgs e)
        {
            var item = (FileItem)FileList.SelectedItem;
            if (item != null)
                OpenFile(item.Path);
        }

        private void AssistantForm_Load(object sender, EventArgs e)
        {
            int itemIndex = 0;
            _moveMappingItems = new[]
            {
                new MoveMappingControls(
                    MoveKeyBox,
                    MoveBox,
                    MoveButton,
                    new MoveMappingData(@"D:\", Key.D1, System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Shift),
                    itemIndex++),
                new MoveMappingControls(
                    MoveKeyBox2,
                    MoveBox2,
                    MoveButton2,
                    new MoveMappingData(@"D:\", Key.D2, System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Shift),
                    itemIndex++),
                new MoveMappingControls(
                    MoveKeyBox3,
                    MoveBox3,
                    MoveButton3,
                    new MoveMappingData(@"D:\", Key.D3, System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Shift),
                    itemIndex++),
                new MoveMappingControls(
                    MoveKeyBox4,
                    MoveBox4,
                    MoveButton4,
                    new MoveMappingData(@"D:\", Key.D4, System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Shift),
                    itemIndex++),
                new MoveMappingControls(
                    MoveKeyBox5,
                    MoveBox5,
                    MoveButton5,
                    new MoveMappingData(@"D:\", Key.D5, System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Shift),
                    itemIndex++),
                new MoveMappingControls(
                    MoveKeyBox6,
                    MoveBox6,
                    MoveButton6,
                    new MoveMappingData(@"D:\", Key.D6, System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Shift),
                    itemIndex++),
                new MappingControls(
                    DelKeyBox,
                    new MoveMappingData("", Key.Delete, System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Shift),
                    itemIndex++),
                new MappingControls(
                    PreviousKeyBox,
                    new MoveMappingData("", Key.Left, System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Shift),
                    itemIndex++),
                new MappingControls(
                    NextKeyBox,
                    new MoveMappingData("", Key.Right, System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Shift),
                    itemIndex++),
                new MappingControls(UndoKeyBox, new MoveMappingData("", Key.Z, System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Shift), itemIndex++),
                new MappingControls(
                    ReopenKeyBox,
                    new MoveMappingData("", Key.Space, System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Shift),
                    itemIndex++),
            };

            var mappings = Settings.Default.Mappings?.ToList() ?? new List<MoveMappingData>();
            foreach (var controls in _moveMappingItems)
            {
                if (mappings.Count - 1 < controls.Index)
                    mappings.Add(controls.Defaults);
            }
            // changed event handlers may use it
            Settings.Default.Mappings = mappings.ToArray();

            foreach (var controls in _moveMappingItems)
            {
                var m = mappings[controls.Index];
                controls.KeyBox.Text = FormatKeyName(m);
                var move = controls as MoveMappingControls;
                if (move != null)
                    move.PathBox.Text = m.Path;
            }

            MaskBox.Text = Settings.Default.Mask;
            OpenWithBox.Text = Settings.Default.App;
            OpenWithArgs.Text = Settings.Default.AppArgs;
            PlaceholderBox.Text = Settings.Default.Placeholder;
            
            Settings.Default.Save();
            RegisterHotkeys();
        }

        void RegisterHotkeys()
        {
            // Create the hotkey manager.
            _hotKeyManager = new HotKeyManager();
            foreach (var m in Settings.Default.Mappings)
            {
                if (m.Key != 0)
                    _hotKeyManager.Register(m.Key, m.ModifierKeys);
            }
            _hotKeyManager.KeyPressed += HotKeyManagerPressed;
        }

        void HotKeyManagerPressed(object sender, KeyPressedEventArgs e)
        {
            try
            {
                Key key = e.HotKey.Key;

                foreach (var m in _moveMappingItems.OfType<MoveMappingControls>())
                {
                    var data = Settings.Default.Mappings[m.Index];
                    if (data.IsHotkey(e.HotKey))
                    {
                        if (!CheckItemSelected()) return;
                        string moveTo = data.Path;
                        if (moveTo == "")
                            Console.Beep();
                        else
                            MoveCurrent(moveTo, false);
                        return;
                    }
                }
                if (_moveMappingItems.First(x => x.KeyBox == DelKeyBox).Data.IsHotkey(e.HotKey))
                {
                    DeleteCurrent();
                    return;
                }
                if (_moveMappingItems.First(x => x.KeyBox == PreviousKeyBox).Data.IsHotkey(e.HotKey))
                {
                    if (!CheckItemSelected()) return;
                    OpenAt(FileList.SelectedIndex - 1);
                    return;
                }
                if (_moveMappingItems.First(x => x.KeyBox == NextKeyBox).Data.IsHotkey(e.HotKey))
                {
                    if (!CheckItemSelected()) return;
                    OpenAt(FileList.SelectedIndex + 1);
                    return;
                }
                if (_moveMappingItems.First(x => x.KeyBox == ReopenKeyBox).Data.IsHotkey(e.HotKey))
                {
                    if (!CheckItemSelected()) return;
                    OpenAt(FileList.SelectedIndex);
                    return;
                }
                if (_moveMappingItems.First(x => x.KeyBox == UndoKeyBox).Data.IsHotkey(e.HotKey))
                {
                    Undo();
                    return;
                }

                AppendLog("Unknown hotkey " + FormatKeyName(new MoveMappingData("", e.HotKey.Key, e.HotKey.Modifiers)) + "\r\n");
            }
            catch (Exception ex)
            {
                Console.Beep(20000, 500);
                AppendLog(ex + "\r\n");
            }
        }

        void AppendLog(string text)
        {
            Log.Text += text;
            if (Log.SelectionLength == 0)
                Log.SelectionStart = Log.Text.Length;
        }

        void MoveCurrent(string moveTo, bool isFullName)
        {
            var current = GetCurrentItemPath();
            RemoveCurrentItemAndOpenNext();
            if (!isFullName)
            {
                moveTo = Path.Combine(moveTo, Path.GetFileName(Path.GetDirectoryName(current)));
                Directory.CreateDirectory(moveTo);
                moveTo = Path.Combine(moveTo, Path.GetFileName(current));
            }
            AppendLog($"Moving {current} to {moveTo}\r\n");

            object lockObj = new object();
            bool cancelled = false;
            Interlocked.Increment(ref _tasks);
            Task.Run(
                async () =>
                {
                    try
                    {
                        while (File.Exists(current))
                        {
                            await Task.Delay(1000);
                            lock (lockObj)
                            {
                                if (cancelled) return;
                                try
                                {
                                    File.Move(current, moveTo);
                                    break;
                                }
                                catch
                                {
                                }
                            }
                        }
                    }
                    finally
                    {
                        Interlocked.Decrement(ref _tasks);
                    }
                });
            _undoList.Add(
                () =>
                {
                    lock (lockObj)
                    {
                        cancelled = true;
                        AppendLog($"Moving back {moveTo} to {current}\r\n");
                        try
                        {
                            File.Move(moveTo, current);
                        }
                        catch (Exception e)
                        {
                            if (!File.Exists(current))
                            {
                                AppendLog("Failed to revert moving file " + current + ": " + e + "\r\n");
                                Console.Beep();
                                return;
                            }
                        }
                        InsertAndOpenAtPrevious(current);
                    }
                });
        }

        int _tasks;

        bool DeleteCurrent()
        {
            if (!CheckItemSelected()) return false;
            var current = GetCurrentItemPath();
            RemoveCurrentItemAndOpenNext();
            object lockObj = new object();
            bool cancelled = false;
            Interlocked.Increment(ref _tasks);
            Task.Run(
                async () =>
                {
                    try
                    {
                        while (File.Exists(current))
                        {
                            await Task.Delay(1000);
                            lock (lockObj)
                            {
                                if (cancelled) return;
                                try
                                {
                                    // check not locked (to avoid error dialogs)
                                    File.Move(current, current + ".deleted");
                                    File.Move(current + ".deleted", current);
                                }
                                catch
                                {
                                    continue;
                                }
                                FileSystem.DeleteFile(current, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin, UICancelOption.DoNothing);
                            }
                        }
                    }
                    finally
                    {
                        Interlocked.Decrement(ref _tasks);
                    }
                });
            _undoList.Add(
                () =>
                {
                    lock (lockObj)
                    {
                        cancelled = true;
                        AppendLog("Restoring file " + current + "\r\n");
                        if (!File.Exists(current) && !Restore(current))
                        {
                            Console.Beep();
                            AppendLog("Failed to restore file " + current + "\r\n");
                        }
                        else
                            InsertAndOpenAtPrevious(current);
                    }
                });
            return true;
        }

        void InsertAndOpenAtPrevious(string current)
        {
            int prevIndex = FileList.SelectedIndex;
            if (prevIndex < 0) prevIndex = 0;
            var fileItem = new FileItem(current);
            FileList.Items.Insert(prevIndex, fileItem);
            if (!_files.ContainsKey(current))
                _files.Add(current, fileItem);
            FileList.SelectedIndex = prevIndex;
            OpenAt(prevIndex);
        }

        readonly List<Action> _undoList = new List<Action>();

        void Undo()
        {
            if (_undoList.Count == 0)
            {
                Console.Beep();
                return;
            }
            var el = _undoList[_undoList.Count - 1];
            _undoList.RemoveAt(_undoList.Count - 1);
            el.Invoke();
        }

        bool CheckItemSelected()
        {
            if (FileList.SelectedIndex == -1)
            {
                Console.Beep();
                return false;
            }
            return true;
        }

        string GetCurrentItemPath()
        {
            return GetCurrentItem()?.Path;
        }

        FileItem GetCurrentItem()
        {
            return ((FileItem)FileList.SelectedItem);
        }

        void RemoveCurrentItemAndOpenNext()
        {
            int index = FileList.SelectedIndex;
            RemoveItemAt(index);
            OpenAt(index);
        }

        void OpenAt(int index)
        {
            start:
            if (FileList.Items.Count > index && index >= 0)
            {
                FileList.SelectedIndex = index;
                string fileName = ((FileItem)FileList.SelectedItem).Path;
                if (!File.Exists(fileName))
                {
                    index++;
                    goto start;
                }
                OpenFile(fileName);
                return;
            }
            FileList.SelectedIndex = -1;
            OpenPlaceholder();
        }

        void OpenFile(string fileName)
        {
            try
            {
                if (OpenWithBox.Text.Length > 0)
                {
                    if (!File.Exists(OpenWithBox.Text))
                    {
                        Console.Beep();
                        AppendLog("App " + OpenWithBox.Text + " doesn't exist\r\n");
                    }
                    Process.Start(OpenWithBox.Text, OpenWithArgs.Text.Replace("%1", fileName));
                }
                else
                    Process.Start(fileName);
            }
            catch (Exception e)
            {
                Console.Beep();
                AppendLog("Can't open " + fileName + ": " + e.GetType().Name + "\r\n");
            }
        }

        void OpenPlaceholder()
        {
            string path = PlaceholderBox.Text;
            if (path.Length == 0 || !File.Exists(path))
                path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "placeholder.mp4");
            OpenFile(path);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            UnregisterHotkeys();
            base.OnClosing(e);
        }

        void UnregisterHotkeys()
        {
            _hotKeyManager?.Dispose();
            _hotKeyManager = null;
        }

        private bool Restore(string fileToRestore)
        {
            var shell = new Shell();
            Folder recycler = shell.NameSpace(10);
            var ext = Path.GetExtension(fileToRestore).ToLowerInvariant();
            for (int i = 0; i < recycler.Items().Count; i++)
            {
                FolderItem folderItem = recycler.Items().Item(i);
                string entryFileName = recycler.GetDetailsOf(folderItem, 0);

                string entryDirectory = recycler.GetDetailsOf(folderItem, 1);

                // hidden file extensions in explorer
                if ((entryFileName + ext).ToLowerInvariant() == Path.GetFileName(fileToRestore).ToLowerInvariant())
                    entryFileName += ext;

                if (fileToRestore.ToLowerInvariant() == Path.Combine(entryDirectory, entryFileName).ToLowerInvariant())
                    return DoVerb(folderItem, "RESTORE") || DoVerb(folderItem, "ВОССТАНОВИТЬ");
            }
            return false;
        }

        private bool DoVerb(FolderItem item, string verb)
        {
            foreach (FolderItemVerb fiVerb in item.Verbs())
            {
                if (fiVerb.Name.Replace("&", "").ToUpper().Contains(verb.ToUpper()))
                {
                    fiVerb.DoIt();
                    return true;
                }
            }
            return false;
        }

        private void MoveBox_TextChanged(object sender, EventArgs e)
        {
            var item = _moveMappingItems.OfType<MoveMappingControls>().First(x => x.PathBox == sender);
            Settings.Default.Mappings[item.Index].Path = item.PathBox.Text;
            SaveSettingsTimer.Enabled = true;
        }

        private void MoveCurrentTo_Click(object sender, EventArgs e)
        {
            if (!CheckItemSelected()) return;
            var current = GetCurrentItemPath();
            MoveToDialog.FileName = Path.GetFileName(current);
            MoveToDialog.InitialDirectory = Path.GetDirectoryName(current);
            if (MoveToDialog.ShowDialog() == DialogResult.OK)
                MoveCurrent(MoveToDialog.FileName, true);
        }

        private void FileList_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = (string[])(e.Data.GetData(DataFormats.FileDrop));
                foreach (var f in filePaths)
                {
                    if (Directory.Exists(f))
                        AddDirectory(f);
                    else
                        AddFile(f);
                }
                _sorter();
            }
        }

        string GetMask()
        {
            if (MaskBox.Text.Length == 0) return "*";
            return MaskBox.Text.Replace("|", "");
        }

        private void FileList_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void SnapSortButton_Click(object sender, EventArgs e)
        {
            _sorter = () => SnapSortButton_Click(null, EventArgs.Empty);
            FileItem currentItem = (FileItem)FileList.SelectedItem;
            var items = GetFilteredItems()
                .OrderByDescending(x => x.Size >= 10 * MB ? int.MaxValue : x.Size) // group big elements on top (small elements will be 1/per group so no thenby for them)
                .ThenByDescending(x => x.Size >= 64 * MB ? int.MaxValue : x.Size / (MB * 16)) // split and order those big elements and make new group of bigger elemenets on top
                .ThenByDescending(x => x.Size >= 128 * MB ? int.MaxValue : x.Size / (MB * 32)) // same
                .ThenByDescending(x => x.Size >= 256 * MB ? int.MaxValue : x.Size / (MB * 64))
                .ThenByDescending(x => x.Size >= 512 * MB ? int.MaxValue : x.Size / (MB * 128))
                .ThenByDescending(x => x.Size / (MB * 256)) // maximum threshold  to concat elements is 256 MB
                .ThenBy(x => x.Path)
                .ThenByDescending(x => x.Size)
                .Cast<object>().ToArray();
            FileList.Items.Clear();
            FileList.Items.AddRange(items);
            if (currentItem != null)
                FileList.SelectedIndex = Array.IndexOf(items, currentItem);
        }

        private void AlphabeticalSortButton_Click(object sender, EventArgs e)
        {
            _sorter = () => AlphabeticalSortButton_Click(null, EventArgs.Empty);
            FileItem currentItem = (FileItem)FileList.SelectedItem;
            var items = GetFilteredItems().OrderBy(x => x.Path).Cast<object>().ToArray();
            FileList.Items.Clear();
            FileList.Items.AddRange(items);
            if (currentItem != null)
                FileList.SelectedIndex = Array.IndexOf(items, currentItem);
        }

        private void ShuffleButton_Click(object sender, EventArgs e)
        {
            _sorter = () => ShuffleButton_Click(null, EventArgs.Empty);
            FileItem currentItem = (FileItem)FileList.SelectedItem;
            var items = GetFilteredItems().Shuffle().Cast<object>().ToArray();
            FileList.Items.Clear();
            FileList.Items.AddRange(items);
            if (currentItem != null)
                FileList.SelectedIndex = Array.IndexOf(items, currentItem);
        }

        private void AddPathRecButton_Click(object sender, EventArgs e)
        {
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                AddDirectory(FolderBrowser.SelectedPath);
                _sorter();
            }
        }

        void AddDirectory(string path)
        {
            var wc = GetMask().Split(new[] { "; ", ";" }, StringSplitOptions.RemoveEmptyEntries).Select(x => new WildcardPattern(x, WildcardOptions.IgnoreCase)).ToArray();
            int c = 0;
            foreach (var f in Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories))
            {
                if (wc.Any(x => x.IsMatch(Path.GetFileName(f)))) AddFile(f);
                if (++c == 500)
                {
                    DoPaintEvents();
                    c = 0;
                }
            }
        }

        private void SaveSettingsTimer_Tick(object sender, EventArgs e)
        {
            Settings.Default.Save();
            SaveSettingsTimer.Enabled = false;
        }

        MappingControls _currentSettingUpControls;

        private void MoveKeyBox_CheckedChanged(object sender, EventArgs e)
        {
            var item = _moveMappingItems.First(x => x.KeyBox == sender);
            if (((CheckBox)sender).Checked)
            {
                if (_currentSettingUpControls != null)
                    _currentSettingUpControls.KeyBox.Checked = false;
                _currentSettingUpControls = item;
            }
        }

        private void AssistantForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void AssistantForm_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void AssistantForm_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void AssistantForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (_currentSettingUpControls != null)
            {
                var item = _currentSettingUpControls;
                _currentSettingUpControls = null;
                ModifierKeys modifiers = 0;
                Keys kd = e.KeyData;
                kd &= ~Keys.Shift;
                kd &= ~Keys.Control;
                kd &= ~Keys.Alt;
                Key key = KeyInterop.KeyFromVirtualKey((int)kd);
                if (e.Alt && key != Key.LeftAlt && key != Key.RightAlt)
                    modifiers |= System.Windows.Input.ModifierKeys.Alt;
                if (e.Control && key != Key.LeftCtrl && key != Key.RightCtrl)
                    modifiers |= System.Windows.Input.ModifierKeys.Control;
                if (e.Shift && key != Key.LeftShift && key != Key.RightShift)
                    modifiers |= System.Windows.Input.ModifierKeys.Shift;

                var data = new MoveMappingData(item.Data.Path, key, modifiers);
                Settings.Default.Mappings[item.Index] = data;
                item.KeyBox.Text = FormatKeyName(data);
                SaveSettingsTimer.Enabled = true;
                UnregisterHotkeys();
                RegisterHotkeys();
                item.KeyBox.Checked = false;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFile(GetCurrentItemPath());
        }

        private void OpenDirButton_Click(object sender, EventArgs e)
        {
            Process.Start(Path.GetDirectoryName(GetCurrentItemPath()));
        }

        private void MaskBox_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.Mask = MaskBox.Text;
            SaveSettingsTimer.Enabled = true;
        }

        private void PlaceholderBox_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.Placeholder = PlaceholderBox.Text;
            SaveSettingsTimer.Enabled = true;
        }

        private void OpenWithArgs_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.AppArgs = OpenWithArgs.Text;
            SaveSettingsTimer.Enabled = true;
        }

        private void OpenWithBox_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.App = OpenWithBox.Text;
            SaveSettingsTimer.Enabled = true;
        }

        private void OponWithBrowse_Click(object sender, EventArgs e)
        {
            if (FileDialog.ShowDialog() == DialogResult.OK)
                OpenWithBox.Text = FileDialog.FileName;

        }

        private void PlaceholderBrowse_Click(object sender, EventArgs e)
        {
            if (FileDialog.ShowDialog() == DialogResult.OK)
                PlaceholderBox.Text = FileDialog.FileName;
        }

        void DoPaintEvents()
        {
            Refresh();
            return;
            var f = new PaintMessageFilter();
            Application.AddMessageFilter(f);
            Application.DoEvents();
            Application.RemoveMessageFilter(f);
        }
        
        class PaintMessageFilter : IMessageFilter
        {
            public bool PreFilterMessage(ref Message m)
            {
                return (m.Msg != 0x000F); // WM_PAINT
            }
        }

        Action _sorter;

        private void AssistantForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Volatile.Read(ref _tasks) > 0)
            {
                if (MessageBox.Show(
                        "Not all deletion/movement tasks were finished, some files are possibly locked. We suggest you to press Cancel now, close all applications that might lock your files and try again.",
                        "Locked files won't be deleted or moved! Proceed?",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            else if (e.CloseReason != CloseReason.WindowsShutDown && e.CloseReason != CloseReason.TaskManagerClosing)
            {
                if (MessageBox.Show(
                        "Are you sure? (all deletion/movement tasks are completed now)",
                        "Closing",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void FixBindingsButton_Click(object sender, EventArgs e)
        {
            UnregisterHotkeys();
            RegisterHotkeys();
        }

        private void SortByQualityButton_Click(object sender, EventArgs e)
        {
            _sorter = () => SortByQualityButton_Click(null, EventArgs.Empty);
            FileItem currentItem = (FileItem) FileList.SelectedItem;
            var files = GetFilteredItems();
            foreach (var el in files)
            {
                if (!el.DurationInitialized)
                    el.Duration = _mediaInfo.GetDuration(el.Path);
            }
            var items = files
                .OrderBy(x => x.Quality != null ? 0 : 1)
                .ThenByDescending(x => 
                                       x.Size <= 100 * MB ? -1 : x.Size / (MB * 512))
                .ThenByDescending(x => 
                                      x.Quality != null ? (long)(x.Quality) : -1)
                .ThenBy(x => x.Path)
                .ThenByDescending(x => x.Size)
                .Cast<object>().ToArray();
            FileList.Items.Clear();
            FileList.Items.AddRange(items);
            if (currentItem != null)
                FileList.SelectedIndex = Array.IndexOf(items, currentItem);
        }

        private void RefreshFiltering()
        {
            FileItem currentItem = (FileItem) FileList.SelectedItem;
            var files = GetFilteredItems().Cast<object>().ToArray();
            FileList.Items.Clear();
            FileList.Items.AddRange(files);
            if (currentItem != null)
                FileList.SelectedIndex = Array.IndexOf(files, currentItem);
        }

        IList<FileItem> GetFilteredItems()
        {
            int minSize = (int)Math.Round(MinSizeMbBox.Value * 1024 * 1024);
            var fileItems = _files.Values.Where(x => x.Size > minSize).ToList();

            int minQuality = (int)Math.Round(MinQualityBox.Value);
            if (minQuality > 0)
            {
                foreach (var el in fileItems)
                {
                    if (!el.DurationInitialized)
                        el.Duration = _mediaInfo.GetDuration(el.Path);
                }
                fileItems = fileItems.Where(x => x.Quality > minQuality).ToList();
            }
            return fileItems;
        }

        private void MinQualityBox_ValueChanged(object sender, EventArgs e)
        {
            _sorter();
        }

        private void MinSizeMbBox_ValueChanged(object sender, EventArgs e)
        {
            _sorter();
        }
    }
}