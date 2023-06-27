using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_movie.Models
{
    public class Theater
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SeatNumber { get; set; }
        public ICollection<Schedule> Schedules { get; } = new List<Schedule>();
    }
}