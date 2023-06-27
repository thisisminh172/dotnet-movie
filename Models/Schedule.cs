using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_movie.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int TheaterId { get; set; }
        public Theater Theater { get; set; }
    }
}