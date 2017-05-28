using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Modul4
{
    public partial class NavigationPage2 : ContentPage
    {
        public NavigationPage2()
        {
            InitializeComponent();
            btnPrevious.Clicked += BtnPrevious_Clicked;
        }

        private async void BtnPrevious_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(true);
        }
    }
}
