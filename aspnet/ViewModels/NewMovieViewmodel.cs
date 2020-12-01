using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using aspnet.Models;
using System.ComponentModel.DataAnnotations;

namespace aspnet.ViewModels
{
    public class NewMovieViewmodel
    {
        public IEnumerable<MovieGenre> MovieGenres { get; set; }
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte? MovieGenreId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Number In Stock")]
        [Range(1, 10)]
        public byte? NumberInStock { get; set; }

        [Required]
        [Display(Name = "Thumbnail Link")]
        public string thumbnailLink { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 
                    ? "Edit Movie" 
                    : "New Movie";
            }
        }
        
        

        public NewMovieViewmodel()
        {
            Id = 0;
        }

        public NewMovieViewmodel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            MovieGenreId = movie.MovieGenreId;
            thumbnailLink = movie.thumbnailLink;
        }
    }
}