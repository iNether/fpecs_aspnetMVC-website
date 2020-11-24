using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using aspnet.Models;

namespace aspnet.ViewModels
{
    public class NewMovieViewmodel
    {
        public IEnumerable<MovieGenre> MovieGenres { get; set; }
        public Movie Movie { get; set; }
        public string Title
        {
            get
            {
                if (Movie != null && Movie.Id != 0)
                    return "Edit Movie";
                return "New Movie";
            }
        }
    }
}