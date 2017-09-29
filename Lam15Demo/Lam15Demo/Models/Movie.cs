using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lam15Demo.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int RunTime { get; set; }
        public string Genre { get; set; }
        public string LeadStar { get; set; }
    }
}
