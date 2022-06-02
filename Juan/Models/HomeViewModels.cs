using Juan.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Models
{
    public class HomeViewModels
    {
        public List<Slider> Sliders { get; set; }
        public List<Policy> Policies { get; set; }
        public List<Product> Products { get; set; }
    }
}
