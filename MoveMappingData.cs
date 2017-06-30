using System;
using System.Windows.Forms;
using System.Windows.Input;
using GlobalHotKey;

namespace VideoSortAssistant
{
    [Serializable]
    public class MoveMappingData
    {
        public string Path { get; set; } 
        public ModifierKeys ModifierKeys { get; set; }
        public Key Key  { get; set; }

        public bool IsHotkey(HotKey hotKey)
        {
            return hotKey.Key == Key && ModifierKeys == hotKey.Modifiers;
        }

        public MoveMappingData(string path, Key key, ModifierKeys modifierKeys)
        {
            Key = key;
            ModifierKeys = modifierKeys;
            Path = path;
        }

        public MoveMappingData()
        {
        }
    }
}