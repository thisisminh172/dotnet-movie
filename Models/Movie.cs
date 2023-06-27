using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_movie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string AgeRestriction  { get; set; }
        public ICollection<Schedule> Schedules { get; } = new List<Schedule>();
    }
}