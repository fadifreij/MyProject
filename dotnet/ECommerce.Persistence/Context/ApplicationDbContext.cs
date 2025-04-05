using E_Commerce.Domain.Entities;
using ECommerce.Domain.Common;
using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Persistence
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
       
        
         public DbSet<Section> Sections { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } =null!;
      

        public DbSet<Department> Departments { get; set; } = null!;
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }


        public DbSet<SectionProduct> SectionProduct { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<SectionProduct>()
        .HasKey(sp => new { sp.SectionId, sp.ProductId });
            modelBuilder.Entity<SectionProduct>()
                .HasOne(sp => sp.Section)
                .WithMany(s => s.SectionProducts)
                .HasForeignKey(sp => sp.SectionId);
            modelBuilder.Entity<SectionProduct>()
                .HasOne(sp => sp.Product)
                .WithMany(p => p.SectionProducts)
                .HasForeignKey(sp=> sp.ProductId);

        }

    }
}
