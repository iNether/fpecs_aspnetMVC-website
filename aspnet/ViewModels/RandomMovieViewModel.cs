using aspnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspnet.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers {get; set;}
    }
}