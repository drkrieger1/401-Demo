using Lam15Demo.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lam15Demo.ViewModel
{
    public class MovieGenreViewModel
    {
        public List<Movie> movie;
        public SelectList genres; 


    }
}
