using System;
using System.Collections.Generic;
using Modul3.Model;
using Xamarin.Forms;

namespace Modul3
{
    public partial class ListViewImageCell : ContentPage
    {
        public ListViewImageCell()
        {
            InitializeComponent();
            // Binds the model from custom adapter
            BindingContext = new ImagesViewModel();
        }

        public class ImagesViewModel : BindableObject
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
            public ImagesViewModel()
            {
                // Fills data
                items = new List<ListItem>
                {
                    new ListItem { ImageSource="first.png", Title="Mystic", Description="Mystic team blue badge" },
                    new ListItem { ImageSource="second.png", Title="Instinct",Description="Instinct team yellow badge" },
                    new ListItem { ImageSource="third.png", Title="Valor",Description="Valor team red badge" }
                };
            }
        }
    }
}
