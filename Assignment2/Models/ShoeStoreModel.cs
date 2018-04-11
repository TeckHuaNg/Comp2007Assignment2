using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2.Models;

namespace Assignment2.Models
{
    public class ShoeStoreModel : DbContext
    {
        // constructor
        public ShoeStoreModel(DbContextOptions<ShoeStoreModel> options) : base(options)
        {

        }

        public DbSet<Shoe> Shoes { get; set; }

        public DbSet<Assignment2.Models.Company> Company { get; set; }
    }
}
