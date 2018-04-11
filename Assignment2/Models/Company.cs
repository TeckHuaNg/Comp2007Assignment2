using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    [Table("Company")]
    public class Company
    {
        [Required]
        public string CompanyName { get; set; }

        [Key]
        public int BrandId { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
