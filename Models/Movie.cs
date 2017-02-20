﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Vidyl.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Number in stock")]
        [Range(1, 20)]
        [Required]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }
    }
}