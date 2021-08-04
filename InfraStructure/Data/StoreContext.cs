using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfraStructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<SubCategories> SubCategories { get; set; }
        public DbSet<Shops> Shops { get; set; }
        public DbSet<ShopsCategories> ShopsCategories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShopsCategories>()
                .HasKey(bc => new { bc.CategoryID, bc.ShopID });
            modelBuilder.Entity<ShopsCategories>()
                .HasOne(bc => bc.Categories)
                .WithMany(b => b.ShopsCategories)
                .HasForeignKey(bc => bc.CategoryID);
            modelBuilder.Entity<ShopsCategories>()
                .HasOne(bc => bc.Shops)
                .WithMany(c => c.ShopsCategories)
                .HasForeignKey(bc => bc.ShopID);
        }
    }
}
