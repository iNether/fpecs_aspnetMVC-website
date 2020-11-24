using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace aspnet.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
       
        public MovieGenre MovieGenre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte MovieGenreId { get; set; }
        
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        public DateTime? AddedDate { get; set; }

        [Display(Name = "Number in Stock")]
        public int NumberInStock { get; set; }


    }
}