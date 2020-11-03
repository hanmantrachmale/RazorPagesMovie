using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required, StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }
        
        [Display(Name = "Release Date"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required, StringLength(30), RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)"), DataType(DataType.Currency), Range(1, 100)]
        public decimal Price { get; set; }
        
        [Required, StringLength(5), RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        public string Rating { get; set; }
    }
}
