using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Modul2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnHello.Clicked += OnClick;
        }

        private void OnClick(object sender, EventArgs e)
        {
            lblDetail.Text = entryHello.Text;
        }
    }
}
