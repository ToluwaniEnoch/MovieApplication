using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApplication.Models
{
    public class Rating
    {
        public double MovieRating { get; set; }
        public int movieId { get; set; }
        public int NumberOfRatings { get; set; }
    }
}
