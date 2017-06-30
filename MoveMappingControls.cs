using System.Windows.Forms;

namespace VideoSortAssistant
{
    class MoveMappingControls : MappingControls
    {
        public TextBox PathBox { get; }
        public Button BrowseButton { get; }

        public MoveMappingControls(CheckBox keyBox, TextBox pathBox, Button browseButton, MoveMappingData defaults, int index)
            : base(keyBox, defaults, index)
        {
            BrowseButton = browseButton;
            PathBox = pathBox;
        }
    }
}