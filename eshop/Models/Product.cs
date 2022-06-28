using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eshop.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
        public string TechnicalSpecsDoc { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string Image { get; set; }

        [Required]
        public string Category { get; set; }

    }
}
