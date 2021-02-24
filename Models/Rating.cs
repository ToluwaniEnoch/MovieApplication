using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApplication.Models
{
    public class Rating
    {
        public List<Rating>  Ratings { get; set; }
        public double MovieRating { get; set; }
        public int MovieId { get; set; }
        public int NumberOfRatings { get; set; }
        
    }
}
