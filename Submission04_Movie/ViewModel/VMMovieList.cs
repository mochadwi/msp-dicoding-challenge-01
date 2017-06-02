using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Submission04_Movie.Common;
using Submission04_Movie.Helper;
using Submission04_Movie.Model;

namespace Submission04_Movie.ViewModel
{
    public class VMMovieList : ViewModelBase
    {
		private ObservableCollection<Movie> movielist = new ObservableCollection<Movie>();
		public ObservableCollection<Movie> MovieList
		{
			get
			{
				return movielist;
			}
			set
			{
				if (this.movielist != value)
				{
					movielist = value;
					RaisePropertyChanged("");
				}
			}
		}
		
        public VMMovieList()
		{
			getData();
		}

		public async void getData()
		{

			var uri = new Uri(string.Format(ApiURL.getComingSoon, string.Empty));
			HttpClient client = new HttpClient();

			try
			{
				//  Debug.WriteLine(uri);
				var response = await client.GetAsync(uri);
				if (response.IsSuccessStatusCode)
				{
					var content = await response.Content.ReadAsStringAsync();
					XDocument xmlFile = XDocument.Parse(content);
					var query = from c in xmlFile.Descendants("item") select c;
					foreach (XElement book in query)
					{
						//Debug.WriteLine("Judul: " + book.Element("title").Value);
						//Debug.WriteLine("link: " + book.Element("link").Value);
						//Debug.WriteLine("pubDate: " + book.Element("pubDate").Value);
						//Debug.WriteLine("category: " + book.Element("category").Value);
						//Debug.WriteLine("guid: " + book.Element("guid").Value);
						//Debug.WriteLine("Des: " + RemoveHtmlTags(book.Element("description").Value));

						Movie movie = new Movie();
						movie.Title = book.Element("title").Value;
						movie.Link2 = book.Element("link").Value;
						movie.PubDate = book.Element("pubDate").Value;
						movie.Category = book.Element("category").Value;
						movie.Guid = book.Element("guid").Value;
						movie.Description = RemoveHtmlTags(book.Element("description").Value);

						string image = (string)("<xml>" + IgnoreHtmlTags(book.Element("description").Value) + "</xml>");
						XElement xe = XElement.Parse(image);
						var query2 = from c in xe.Descendants("img") select c;
						foreach (XElement book2 in query2)
						{
							Debug.WriteLine("Image: " + book2.Attribute("src").Value);
							movie.ImageUrl = book2.Attribute("src").Value;
						}
						movielist.Add(movie);
					}
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(@"Kesalahan {0}", ex.Message);
			}
		}


		string RemoveHtmlTags(string html)
		{
			return Regex.Replace(html, "<.+?>", string.Empty);
		}


		// mengambil
		string IgnoreHtmlTags(string html)
		{
			MatchCollection mc = Regex.Matches(html, "<.+?>");
			string data = "";
			foreach (Match m in mc)
			{
				data += m.Value;
			}
			return data;
		}
    }
}
