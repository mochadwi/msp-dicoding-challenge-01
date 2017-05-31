using System;
using System.Collections.Generic;
using Submission02_CarShop.Model;
using Xamarin.Forms;

namespace Submission02_CarShop.ViewModel
{
    public class VMCar : BindableObject
    {
        private List<ModelCar> cars;

        public VMCar()
        {
            cars = new List<ModelCar>
            {
                new ModelCar { ImgSource="calya.jpg", Name="Calya", Info="Calya car endurance, 3 seats available",  Price=24500000},
                new ModelCar { ImgSource="honda.jpg", Name="Honda", Info="Honda car endurance, 4 seats available",  Price=35300000},
                new ModelCar { ImgSource="toyota.jpg", Name="Toyota", Info="Toyota car endurance, 6 seats available",  Price=45500000}
            };
        }

        public List<ModelCar> Cars
        {
            get
            {
                return cars;
            }
            set
            {
                cars = value;
                OnPropertyChanged("ShowItems");
            }
        }
    }
}
