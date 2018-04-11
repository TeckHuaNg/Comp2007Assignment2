using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    [Table("Shoe")]
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
