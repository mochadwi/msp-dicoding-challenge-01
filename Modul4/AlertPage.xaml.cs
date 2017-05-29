using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Modul4
{
    public partial class AlertPage : ContentPage
    {
        public AlertPage()
        {
            InitializeComponent();
        }

        async void OnAlertSimpleClicked(object sender, System.EventArgs e)
        {
            await DisplayAlert("Alert", "You have been alerted", "OK");
        }

        async void OnAlertYesNoClicked(object sender, System.EventArgs e)
        {
            var answer = await DisplayAlert("Question?", "Would you like to play game?",
                                            "Yes", "No");
        }
    }
}
