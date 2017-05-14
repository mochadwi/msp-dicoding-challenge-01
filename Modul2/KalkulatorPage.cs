using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Modul2
{
    public partial class KalkulatorPage : ContentPage
    {
        public KalkulatorPage()
        {
            InitializeComponent();
            btnAdd.Clicked += OnClick;
            btnSubstract.Clicked += OnClick;
            btnMultiply.Clicked += OnClick;
            btnDivision.Clicked += OnClick;
        }

        private void OnClick(object sender, EventArgs e)
        {
            double result = 0;
            var myBtn = (Button)sender;
            switch(myBtn.Text)
            {
                case "Add":
                    result = Convert.ToDouble(entryNo1.Text) + 
                                Convert.ToDouble(entryNo2.Text);
                    break;
				case "Substract":
					result = Convert.ToDouble(entryNo1.Text) -
								Convert.ToDouble(entryNo2.Text);
					break;
				case "Multiply":
					result = Convert.ToDouble(entryNo1.Text) *
								Convert.ToDouble(entryNo2.Text);
					break;
				case "Division":
					result = Convert.ToDouble(entryNo1.Text) /
								Convert.ToDouble(entryNo2.Text);
					break;
            }

            entryResult.Text = result.ToString();
        }
    }
}
