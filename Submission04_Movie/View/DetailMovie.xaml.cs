using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Submission04_Movie.View
{
    public partial class DetailMovie : ContentPage
    {
        public DetailMovie()
        {
            InitializeComponent();
            btnBack.Clicked += async (sender, e) =>
            {
                await Navigation.PopAsync(true);
            };
        }
    }
}
