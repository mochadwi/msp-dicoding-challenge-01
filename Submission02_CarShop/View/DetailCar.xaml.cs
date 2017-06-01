using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Submission02_CarShop.View
{
    public partial class DetailCar : ContentPage
    {
        public DetailCar()
        {
            InitializeComponent();
        }

        private async void BackToPrevious(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync(true);
        }
    }
}
