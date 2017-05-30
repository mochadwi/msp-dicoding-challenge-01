using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Modul4
{
    public partial class NavigationPage2 : ContentPage
    {
        public NavigationPage2(string param)
        {
            InitializeComponent();
            lblParam.Text = "Nama anda: " + param + "\n ID: " +
                (string)Application.Current.Properties["id"];
            btnPrevious.Clicked += BtnPrevious_Clicked;
        }

        private async void BtnPrevious_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(true);
        }
    }
}
