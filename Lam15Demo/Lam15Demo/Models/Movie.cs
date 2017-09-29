using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lam15Demo.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Tile is required")]
        public string Title { get; set; }

        [Range(30,400)]
        public int RunTime { get; set; }

        [Required(ErrorMessage = "Genre is required you turd")]
        public string Genre { get; set; }

        [Display(Name= "Starring")]
        [Required(ErrorMessage ="Lead is required")]
        public string LeadStar { get; set; }
        
    }
}
