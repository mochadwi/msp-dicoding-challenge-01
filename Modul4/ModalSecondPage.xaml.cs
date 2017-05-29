using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Modul4
{
    public partial class ModalSecondPage : ContentPage
    {
        public ModalSecondPage()
        {
            InitializeComponent();
        }

        private async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }
    }
}
