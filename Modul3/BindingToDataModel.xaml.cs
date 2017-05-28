using System;
using System.Collections.Generic;
using Modul3.Model;
using Xamarin.Forms;

namespace Modul3
{
    public partial class BindingToDataModel : ContentPage
    {
        public BindingToDataModel()
        {
            InitializeComponent();
            BindingContext = new ItemModelViewModel();
        }

        private async void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
			ListItem item = (ListItem)e.Item;
			await DisplayAlert("Tapped", item.Title.ToString() + " was selected",
							   "OK");
			((ListView)sender).SelectedItem = null; // to prevents selected item being selected again
        }

        public class ItemModelViewModel : BindableObject
        {
            // Private fields
            private List<ListItem> items;

            // Constructor
            public ItemModelViewModel()
            {
                // Adds data to model
                items = new List<ListItem>()
                {
                    new ListItem { Title="Mystic", Description="Mystic team blue badge"},
                    new ListItem { Title="Instinct", Description="Instinct team yellow badge"},
                    new ListItem { Title="Valor", Description="Valor team red badge"},
                };
            }

            // Methods
            public List<ListItem> ListItems
            {
                get { return items; }
                set
                {
                    items = value;
                    OnPropertyChanged("ListItems"); // recursively call this methods
                }
            }
		}
    }
}
