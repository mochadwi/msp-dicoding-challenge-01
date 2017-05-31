using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Submission2_BeratIdeal
{
    public partial class DashboardPage : ContentPage
    {
        public DashboardPage()
        {
            InitializeComponent();
        }

        private void Handle_MaleIdealMess(object sender, System.EventArgs e)
        {
            double height = Convert.ToDouble(entHeight.Text);
            double heightReduction = height - 100;
            double weight = Convert.ToDouble(entWeight.Text);
            double resultBrocha = Math.Floor(heightReduction - (0.10d * heightReduction));
            double resultBMI = Math.Floor(weight / Math.Pow(height / 100, 2));
            string category = "";

            if (resultBMI > 27)
            {
                category = "Obesity (> 27 Kg)";
            }
            else if (23 < resultBMI && resultBMI <= 27)
            {
                category = "Over Weight (24 - 27 Kg)";
            }
            else if (17 <= resultBMI && resultBMI <= 23)
            {
                category = "Normal Weight (17 - 23)";
            }
            else
            {
                category = "Under Weight (< 18 Kg)";
            }

            lblBrochaValue.Text = resultBrocha.ToString();
            lblBmiValue.Text = String.Format("{0:#.0}", resultBMI);
            lblSummaryValue.Text = category;
        }

        private void Handle_FemaleIdealMess(object sender, System.EventArgs e)
        {
            double height = Convert.ToDouble(entHeight.Text);
            double heightReduction = height - 100;
            double weight = Convert.ToDouble(entWeight.Text);
            double resultBrocha = Math.Floor(heightReduction - (0.15d * heightReduction));
            double resultBMI = Math.Floor(weight / Math.Pow(height / 100, 2));

            string category = "";

            if (resultBMI > 27)
            {
                category = "Obesity (> 27 Kg)";
            }
            else if (25 < resultBMI && resultBMI <= 27)
            {
                category = "Over Weight (26 - 27 Kg)";
            }
            else if (18 <= resultBMI && resultBMI <= 25)
            {
                category = "Normal Weight (18 - 25)";
            }
            else
            {
                category = "Under Weight (< 18 Kg)";
            }

            lblBrochaValue.Text = resultBrocha.ToString();
            lblBmiValue.Text = String.Format("{0:#.0}", resultBMI);
            lblSummaryValue.Text = category;
        }
    }
}
