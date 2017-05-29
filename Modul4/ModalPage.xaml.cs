using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Modul4
{
    public partial class ModalPage : ContentPage
    {
        public ModalPage()
        {
            InitializeComponent();
        }

        private async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new ModalSecondPage(), true);
        }
    }
}
