using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Entities
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountedPrice { get; set; }
        [MaxLength(500)]
        public string Desc { get; set; }
        public bool Availability { get; set; }
        [MaxLength(25)]
        public string Image { get; set; }
    }
}
