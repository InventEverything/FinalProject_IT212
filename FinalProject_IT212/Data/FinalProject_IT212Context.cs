using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProject_IT212.Models;
using System.Net;
using System.Collections;
using Humanizer;

namespace FinalProject_IT212.Data
{
    public class FinalProject_IT212Context : DbContext
    {
        public FinalProject_IT212Context (DbContextOptions<FinalProject_IT212Context> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
            {
                modelBuilder.Entity<Customers>().HasData(
                    new Customers
                    {
                        CustomerId = 1,
                        FirstName = "Lisa",
                        LastName = "Hedgington",
                        Email = "BalloonGirl657@Treemail.com"
                    }, 
                    new Customers
                    {
                        CustomerId = 2,
                        FirstName = "Margaret",
                        LastName = "Tanding",
                        Email = "CrysanthimumPedals@Treemail.com"
                    }, 
                    new Customers
                    {
                        CustomerId = 3,
                        FirstName = "Camile",
                        LastName = "Smith",
                        Email = "CamileIanHearts@Treemail.com"
                    }, 
                    new Customers
                    {
                        CustomerId = 4,
                        FirstName = "Michael",
                        LastName = "Odderton",
                        Email = "RocksNFries@Treemail.com"
                    }, 
                    new Customers
                    {
                        CustomerId = 5,
                        FirstName = "Helen",
                        LastName = "McBride",
                        Email = "PearlsAndBlooms347@YahootieHoo.com"
                    });
                modelBuilder.Entity<Orders>().HasData(
                    new Orders
                    {
                        OrderId = 1,
                        CustomerId = 1,
                        OrderCost = 53.78m
                    },
                    new Orders
                    {
                        OrderId = 2,
                        CustomerId = 4,
                        OrderCost = 89.64m
                    },
                    new Orders
                    {
                        OrderId = 3,
                        CustomerId = 3,
                        OrderCost = 32.78m
                    },
                    new Orders
                    {
                        OrderId = 4,
                        CustomerId = 2,
                        OrderCost = 338.31m
                    },
                    new Orders
                    {
                        OrderId = 5,
                        CustomerId = 1,
                        OrderCost = 127.44m
                    });
                modelBuilder.Entity<Products>().HasData(
                    new Products
                    {
                        ProductId = 1,
                        Name = "Blouse",
                        Description = "Cream floral",
                        Cost = 53.78m
                    },
                    new Products
                    {
                        ProductId = 2,
                        Name = "Bell Bottoms",
                        Description = "Brown cordoroy",
                        Cost = 73.66m
                    },
                    new Products
                    {
                        ProductId = 3,
                        Name = "Hoodie",
                        Description = "Green moose decal",
                        Cost = 65.99m
                    },
                    new Products
                    {
                        ProductId = 4,
                        Name = "Basic T-shirt",
                        Description = "Black",
                        Cost = 7.99m
                    },
                    new Products
                    {
                        ProductId = 5,
                        Name = "Crop Top",
                        Description = "Maroon lace",
                        Cost = 32.78m
                    });
                modelBuilder.Entity<Quantity>().HasData(
                    new Quantity
                    {
                        QuantityId = 1,
                        ProductId = 1,
                        ProductQty = 1,
                        OrdersOrderId = 1,
                    },
                    new Quantity
                    {
                        QuantityId = 2,
                        ProductId = 2,
                        ProductQty = 1,
                        OrdersOrderId = 2
                    },
                    new Quantity
                    {
                        QuantityId = 3,
                        ProductId = 4,
                        ProductQty = 2,
                        OrdersOrderId = 2
                    },
                    new Quantity
                    {
                        QuantityId = 4,
                        ProductId = 5,
                        ProductQty = 1,
                        OrdersOrderId = 3
                    },
                    new Quantity
                    {
                        QuantityId = 5,
                        ProductId = 1,
                        ProductQty = 2,
                        OrdersOrderId = 4
                    },
                    new Quantity
                    {
                        QuantityId = 6,
                        ProductId = 5,
                        ProductQty = 1,
                        OrdersOrderId = 4
                    },
                    new Quantity
                    {
                        QuantityId = 7,
                        ProductId = 3,
                        ProductQty = 3,
                        OrdersOrderId = 4
                    },
                    new Quantity
                    {
                        QuantityId = 8,
                        ProductId = 1,
                        ProductQty = 1,
                        OrdersOrderId = 5
                    },
                    new Quantity
                    {
                        QuantityId = 9,
                        ProductId = 2,
                        ProductQty = 1,
                        OrdersOrderId = 5
                    });
            }
            modelBuilder.Entity<Orders>().Navigation(e => e.ProductQty).AutoInclude();
        }
        public DbSet<FinalProject_IT212.Models.Customers> Customers { get; set; } = default!;
        public DbSet<FinalProject_IT212.Models.Orders> Orders { get; set; } = default!;
        public DbSet<FinalProject_IT212.Models.Products> Products { get; set; } = default!;
        public DbSet<FinalProject_IT212.Models.Quantity> Quantity { get; set; } = default!;
    }
}
