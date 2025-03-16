using E_Commerce.Domain.Entities;
using ECommerce.Domain.Common;
using ECommerce.Persistence;
using ECommerce.Seeding.Data;
using ECommerce.Seeding.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Seeding.Services
{
    internal class DataInserter
    {
      
        private readonly DbInitializer _initializer;
        private readonly ApplicationDbContext _context;
        public DataInserter()
        {
            _initializer = new();
            _context = _initializer.Create();

        }

        public void Insert<T>(IEnumerable<T> data, string tableName)  where T: BaseEntity
        {
            
            Console.WriteLine($"Inserting to {tableName} Table ...");
            
            using var transaction = _context.Database.BeginTransaction();
            // Enable IDENTITY_INSERT for the table
            _context.Database.ExecuteSqlRaw($"SET IDENTITY_INSERT {tableName} ON;");

            _context.Set<T>().AddRange(data);
            _context.SaveChanges();

            // Disable IDENTITY_INSERT for the table
            _context.Database.ExecuteSqlRaw($"SET IDENTITY_INSERT {tableName} OFF;");
            transaction.Commit();
            Console.WriteLine($"{tableName} Table seeded successfully ...");
            Console.WriteLine("------------------------------------------");

        }


        public void InsertProductImages()
        {
            Console.WriteLine("Inserting to ProductImage Table ...");
            // Enable IDENTITY_INSERT for the table
            using var productImagesTransaction = _context.Database.BeginTransaction();
            _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT product_images ON;");

            IEnumerable<ProductImages> images;
            int recordId = 1;
            string[] FoodCategory = ["Meat", "Fish & Seafood", "Fruit & Vegtables", "Backery & Cakes", "Frozen"];

            for (int i = 0; i < FoodCategory.Length; i++)
            {

                images = ImageSeeder.SeedProductImagesAfterConvertingToBinaryByDepartment("Food", FoodCategory[i], ProductData.products, ref recordId);
                _context.ProductImages.AddRange(images);
                _context.SaveChanges(true);
            }


            string[] ElectronicsCategory = ["Televisions"];
            for (int   i= 0;   i< ElectronicsCategory.Length;  i++)
            {
                images = ImageSeeder.SeedProductImagesAfterConvertingToBinaryByDepartment("Electronics", ElectronicsCategory[i], ProductData.products, ref recordId);
                _context.ProductImages.AddRange(images);
                _context.SaveChanges(true);
            }

            // Disable IDENTITY_INSERT for the table
            _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT product_images OFF;");
            productImagesTransaction.Commit();
            Console.WriteLine("ProductImage Table seeded successfully ...");
            Console.WriteLine("------------------------------------------");
        }

    }
}
