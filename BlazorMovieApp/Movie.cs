﻿using System.ComponentModel.DataAnnotations;

namespace BlazorMovieApp
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }
    }
}
