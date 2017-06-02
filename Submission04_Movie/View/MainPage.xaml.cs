using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Submission04_Movie.Model;
using Submission04_Movie.ViewModel;
using Xamarin.Forms;

namespace Submission04_Movie.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

			VMMovieList vmmovie = new VMMovieList();
			listView.BindingContext = vmmovie;

			listView.ItemTapped += async (sender, e) =>
			{
				Movie movie = (Movie)e.Item;
				await Task.Yield();

				var detailMovie = new DetailMovie();
				detailMovie.BindingContext = movie;
				await Navigation.PushAsync(detailMovie);
				((ListView)sender).SelectedItem = null;
			};
        }
    }
}
