using System;
using System.Collections.Generic;
using Submission02_CarShop.Model;
using Xamarin.Forms;

namespace Submission02_CarShop.View
{
    public partial class DetailCar : ContentPage
    {
        public DetailCar(ModelCar item)
        {
            InitializeComponent();
            this.BindingContext = item;
        }
    }
}
