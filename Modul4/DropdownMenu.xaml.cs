
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace Modul4
{
    public partial class DropdownMenu : ContentPage
    {
        public DropdownMenu()
        {
            InitializeComponent();
        }

        protected async void Handle_Clicked(object sender, EventArgs e)
        {
            // Current namespace
            //var namespace1 = typeof(Modul4).ToString();
            //Debug.WriteLine(namespace1);

			// Casting CommandParameter to string
			string type = (string)((ToolbarItem)sender).CommandParameter;
            Debug.WriteLine("Error: {0}", type);

            Type pageType = Type.GetType("Modul4." + type);
            Debug.WriteLine("Error: " + pageType);
            // Creates an instance to point to the right navigation (NavigationPage1, etc)
            try
            {
                Page page = (Page)Activator.CreateInstance(pageType);
                await Navigation.PushAsync(page);
            } catch (ArgumentNullException errorMsg)
            {
                Debug.WriteLine("Error: {0}", errorMsg);
            }
        }
    }
}
