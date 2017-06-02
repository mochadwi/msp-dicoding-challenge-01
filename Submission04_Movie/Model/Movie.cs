﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission04_Movie.Model
{
    public class Movie
    {
		public string Title { get; set; }

		public string Link2 { get; set; }

		public string PubDate { get; set; }

		public string Creator { get; set; }

		public string Category { get; set; }

		public string Guid { get; set; }

		public string Description { get; set; }

		public string ImageUrl { get; set; }

		public static IList<Movie> All { get; set; }

		static Movie()
		{
			All = new ObservableCollection<Movie>();
		}
    }
}
