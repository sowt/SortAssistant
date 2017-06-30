using System.Windows.Forms;

namespace VideoSortAssistant
{
    class MappingControls
    {
        public int Index { get; }
        public CheckBox KeyBox { get; }
        public MoveMappingData Data => Settings.Default.Mappings[Index];
        public MoveMappingData Defaults { get; }

        public MappingControls(CheckBox keyBox, MoveMappingData defaults, int index)
        {
            Index = index;
            Defaults = defaults;
            KeyBox = keyBox;
        }
    }
}