using System;
using System.Collections.Generic;
using Modul3.Model;
using Xamarin.Forms;

namespace Modul3
{
    public partial class ListViewCustom : ContentPage
    {
		public ListViewCustom()
		{
			InitializeComponent();
			// Binds the model from custom adapter
			BindingContext = new CustomViewModel();
		}

		private async void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
		{
			ListItem item = (ListItem)e.Item;
			await DisplayAlert("Tapped", item.Title.ToString() + " was selected",
							   "OK");
			((ListView)sender).SelectedItem = null;
		}

		public class CustomViewModel : BindableObject
		{
			// Fields
			private List<ListItem> items;
			public List<ListItem> ShowItems
			{
				get { return items; }
				set
				{
					// Set actual value to items
					items = value;
					OnPropertyChanged("ShowItems"); // tells when there's updated data
				}
			}

			// Constructor
			public CustomViewModel()
			{
				// Fills data
				items = new List<ListItem>
				{
					new ListItem { Title="Pokeball", Description="Pokeball Red", Price="Rp. 10.000" },
					new ListItem { Title="Masterall", Description="Masterball Blue", Price="Rp. 20.000" },
					new ListItem { Title="Ultraball",Description="Ultraball Yellow", Price="Rp. 50.000" }
				};
			}
		}
    }
}
