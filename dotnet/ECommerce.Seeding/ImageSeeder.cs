using E_Commerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Seeding
{
    internal static class ImageSeeder
    {
        public static IEnumerable<ProductImages> SeedProductImagesAfterConvertingToBinaryByDepartment(string categoryFolderName, string departmentFolderName, Product[] products, ref int recordId)
        {
            var baseDirectory = AppContext.BaseDirectory;
            var departmentFolderPath = Path.Combine(baseDirectory, "./../../ECommerce.Seeding/", $"./Images/{categoryFolderName}/{departmentFolderName}");

            var result = new List<ProductImages>();
            try
            {
                // Get all subfolders in the given folder
                string[] subfolders = Directory.GetDirectories(departmentFolderPath);


                // Iterate through each subfolder
                foreach (var subfolder in subfolders)
                {
                    // Get the folder name (last part of the path)
                    string folderName = Path.GetFileName(subfolder);


                    // Get all files in the current subfolder
                    string[] files = Directory.GetFiles(subfolder);

                    foreach (var file in files)
                    {
                        // Read the file as binary data
                        byte[] fileData = File.ReadAllBytes(file);

                        // seed the data in table Product Images
                        result.Add(new ProductImages
                        {
                            Id = recordId,
                            ProductImage = fileData,
                            ProductId = products.Where(p => p.ProductName == folderName).First().Id
                          

                        });
                        
                        recordId++;
                    }
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred when seeding ProducctImages for department {departmentFolderName}: {ex.Message}");
            }
            return result;
        }
    }
}
