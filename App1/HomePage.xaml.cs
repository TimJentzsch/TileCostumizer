using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public ApplicationTile ApplicationTile { get; set; }

        public HomePage()
        {
            this.InitializeComponent();
        }

        private void TextColorRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb != null && ApplicationTile != null)
            {
                string colorName = rb.Tag.ToString();
                // Set the text color of the tile
                switch (colorName)
                {
                    case "Light":
                        ApplicationTile.TextColor = TextColor.LIGHT;
                        break;
                    case "Dark":
                        ApplicationTile.TextColor = TextColor.DARK;
                        break;
                }
            }
        }

        private void TextOnCheckbox_Click(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            if (cb != null && ApplicationTile != null)
            {
                string tileType = cb.Tag.ToString();
                bool isChecked = cb.IsChecked ?? false;
                // Set the text on the specified tile type
                switch (tileType)
                {
                    case "Small":
                        ApplicationTile.TextOnSmall = isChecked;
                        break;
                    case "Medium":
                        ApplicationTile.TextOnMedium = isChecked;
                        break;
                    case "Large":
                        ApplicationTile.TextOnLarge = isChecked;
                        break;

                }
            }
        }

        private async void BrowseApplication_Click(object sender, RoutedEventArgs e)
        {
            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.List;
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.ComputerFolder;
            picker.FileTypeFilter.Add(".exe");
            picker.FileTypeFilter.Add(".lnk");

            Windows.Storage.StorageFile file = await picker.PickSingleFileAsync();
            if (file != null)
            {
                // Application now has read/write access to the picked file
                ApplicationTile = new ApplicationTile(file.Path);
                ApplicationTile.Name = file.Name;
            }
        }
    }
}
