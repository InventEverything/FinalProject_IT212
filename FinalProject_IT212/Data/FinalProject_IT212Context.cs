using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProject_IT212.Models;

namespace FinalProject_IT212.Data
{
    public class FinalProject_IT212Context : DbContext
    {
        public FinalProject_IT212Context (DbContextOptions<FinalProject_IT212Context> options)
            : base(options)
        {
        }

        public DbSet<FinalProject_IT212.Models.Customers> Customers { get; set; } = default!;
        public DbSet<FinalProject_IT212.Models.Orders> Orders { get; set; } = default!;
        public DbSet<FinalProject_IT212.Models.Products> Products { get; set; } = default!;
        public DbSet<FinalProject_IT212.Models.Quantity> Quantity { get; set; } = default!;
    }
}
