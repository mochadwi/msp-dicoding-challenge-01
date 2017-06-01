using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Submission02_CarShop.Model;
using Xamarin.Forms;

namespace Submission02_CarShop.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ViewModel.VMCar vmCar = new ViewModel.VMCar();
            BindingContext = vmCar;

            lvCars.ItemTapped += async (sender, e) => 
            {
                ModelCar car = (ModelCar)e.Item;
                await Task.Yield();
                await Navigation.PushAsync(new DetailCar(), true);
                ((ListView)sender).SelectedItem = null;
            };
        }
    }
}
