using InputKit.Shared.Controls;
using UraniumUI.Pages;
using VisualAll.Apps.Editor;

namespace VisualAll.Apps
{
    public partial class HomePage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void CreateNewButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditorPage());
        }
    }
}