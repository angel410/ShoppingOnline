using Microsoft.EntityFrameworkCore;
using ShoppingCart_.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Services.Data
{
    /// <summary>
    /// DbContext for the application
    /// </summary>
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<CarttIems> CarttIems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<OrderDetails>()
                    .Property(s => s.OrderDetailsId)
                    .ValueGeneratedOnAdd();
            //modelBuilder.Entity<OrderDetails>()
            //       .Property(s => s.OrderId)
            //      .ValueGeneratedNever();
            //modelBuilder.Entity<OrderDetails>()
            //        .Property(s => s.PorductId)
            //      .ValueGeneratedNever();
        }
    }
}
