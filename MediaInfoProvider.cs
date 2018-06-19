using System;
using System.Diagnostics;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using WMPLib;

namespace VideoSortAssistant
{
    public class MediaInfoProvider
    {
        readonly WindowsMediaPlayer _wmp = new WindowsMediaPlayer();

        public TimeSpan? GetDuration(string filePath)
        {
            try
            {
                using (ShellObject shell = ShellObject.FromParsingName(filePath))
                {
                    IShellProperty prop = shell.Properties.System.Media.Duration;
                    var value = prop.ValueAsObject;
                    return TimeSpan.FromTicks((long) (ulong) value);
                    // Duration will be formatted as 00:44:08
                    //string duration = prop.FormatForDisplay(PropertyDescriptionFormatOptions.None);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                try
                {
                    IWMPMedia mediainfo = _wmp.newMedia(filePath);
                    var duration = mediainfo.duration;
                    if (duration < double.Epsilon)
                        return null;
                    return TimeSpan.FromSeconds(duration);
                }
                catch (Exception e2)
                {
                    Debug.WriteLine(e);
                    return null;
                }
                return null;
            }
        }
    }
}