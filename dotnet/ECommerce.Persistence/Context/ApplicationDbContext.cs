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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

             // modelBuilder.Entity<SectionProduct>()
             //.HasKey(e => new { e.ProductId, e.SectionId }); // Composite key

            // DbSeeding.Seed(modelBuilder);


        }

    }
}
