using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Modul3
{
    public partial class BindingListString : ContentPage
    {
        public BindingListString()
        {
            InitializeComponent();

            // Populate data into ListView
            List<string> items = new List<string> { "First", "Second", "Third" };
            listView.ItemsSource = items;

            // Onclick Listener for each item
            listView.ItemTapped += async (sender, e) => 
            {
                await DisplayAlert("Tapped", e.Item.ToString() + " was selected",
                                   "OK");
                ((ListView)sender).SelectedItem = null;
            };
        }
    }
}
