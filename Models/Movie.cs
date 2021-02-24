using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApplication.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string  Director { get; set; }
        public double AverageRating { get; set; }
        public DateTime DateCreated { get; set; }
    }

    public class AddMovie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public double MovieRating { get; set; }
    }

    public class EditMovie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public double MovieRating { get; set; }

    }
}
