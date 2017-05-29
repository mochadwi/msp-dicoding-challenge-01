using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Modul4
{
    public partial class ActionSheetPage : ContentPage
    {
        public ActionSheetPage()
        {
            InitializeComponent();
        }

        private async void OnActionSheetSimpleClicked(object sender, EventArgs e)
        {
            await DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
        }
        private async void OnActionSheetCancelDeleteClicked(object sender, EventArgs e)
        {
            await DisplayActionSheet("ActionSheet: SavePhoto?", "Cancel", "Delete", "Photo Roll", "Email");
        }
    }
}
