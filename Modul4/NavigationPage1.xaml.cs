using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Modul4
{
    public partial class NavigationPage1 : ContentPage
    {
        public NavigationPage1()
        {
            InitializeComponent();
            // When button clicked
            btnNext.Clicked += BtnNext_Clicked;
        }

        // Button event to next page
        private async void BtnNext_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage2());
        }
    }
}
