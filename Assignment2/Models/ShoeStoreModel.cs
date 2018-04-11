using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class ShoeStoreModel : DbContext
    {
        // constructor
        public ShoeStoreModel(DbContextOptions<ShoeStoreModel> options) : base(options)
        {

        }

        public DbSet<Shoe> Shoes { get; set; }
    }
}
