using System;
namespace Submission02_CarShop.Model
{
    public class ModelCar
    {
        private string _name, _info, _imgSource;
        private int _price;

        public ModelCar()
        {
        }

		// Constructor
        public ModelCar(string name, string info, string imgSource, int price)
        {
            Name = name;
            Info = info;
            ImgSource = imgSource;
            Price = price;
        }

		// Getter & Setter
		public string Name
        {
            get
            {
                return _name;
            }
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new ArgumentNullException();

				this._name = value;
			}
        }

        public string Info
        {
            get
            {
                return _info;
            }
            set
			{
				if (string.IsNullOrEmpty(value))
					throw new ArgumentNullException();

				this._info = value;
			}
        }

        public string ImgSource
        {
            get
            {
                return _imgSource;
            }
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new ArgumentNullException();

				this._imgSource = value;
			}
        }

        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                this._price = value;
            }
        }
    }
}
