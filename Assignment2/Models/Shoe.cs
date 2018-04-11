using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Shoe
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public int BrandId { get; set;}

        [Required]
        public string ShoeName { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public  decimal SizeUS { get; set; }

        [Required]
        public int Quantity { get; set; }

        public string ImageUrl { get; set; }
    }
}
