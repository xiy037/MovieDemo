using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApplication.Models
{
    public class MovieRequest
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genres { get; set; }
    }
}
