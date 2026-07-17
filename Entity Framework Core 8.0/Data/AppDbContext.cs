using System;
using System.Collections.Generic;
using System.Text;

using EFCoreRetailStore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreRetailStore.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
@"Server=DESKTOP-Q9JDFMI;
Database=RetailInventoryDB;
Trusted_Connection=True;
TrustServerCertificate=True;");
        }
    }
}
