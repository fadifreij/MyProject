using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Seeding
{
    internal static class DescriptionSeeder
    {
        public static string DescriptionReader(string categoryFolderName, string departmentFolderName,string productName)
        {
            var baseDirectory = AppContext.BaseDirectory;
            var departmentFolderPath = Path.Combine(baseDirectory, "./../../ECommerce.Seeding/", $"./Data/ProductDescriptionData/{categoryFolderName}/{departmentFolderName}");
            var filePath = Path.Combine(departmentFolderPath,$"{productName}.txt");
            return File.ReadAllText(filePath);
        }
    }
}
