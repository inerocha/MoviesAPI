using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Data.Dto 
{ 
    public class UpdateMovieDto 
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Title field is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Duration field is required")]
        [Range(1, 600)]
        public int Duration { get; set; }
        [Required]
        public string Director { get; set; }
        public string Genre { get; set; }
    }
}
