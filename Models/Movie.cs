using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks; 

namespace MoviesAPI.Models
{
    public class Movie
    {
        [Key]
        [Required(ErrorMessage = "Title field is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Title field is required")]
        public string Title { get; set; } 
        [Required(ErrorMessage = "The director field is mandatory")]
        public string Director { get; set; }
        [Required(ErrorMessage = "The gender field is mandatory")]
        public string Genre { get; set; }
        [Range (1, 43200, ErrorMessage = "Mandatory duration time")]
        public int Duration { get; set; }
        
    }   
}
