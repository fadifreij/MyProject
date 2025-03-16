using ECommerce.Seeding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ECommerce.Seeding.Utilities
{
    internal class AppSettingReader(string filePath)
    {
      public  AppSettingsModel Read()
        {
            try
            {
                Console.WriteLine("Reading database configuration ....");
                Console.WriteLine("-----------------------------------");
                // Read the JSON file content
                string jsonContent = File.ReadAllText(filePath);
                jsonContent = jsonContent.Replace("// \"MySQL\" to MySQL or  to \"SqlServer\" for SQL Server", "");
                // Deserialize JSON content into the Person object
                AppSettingsModel appSettings = JsonSerializer.Deserialize<AppSettingsModel>(jsonContent)!;


                if (appSettings == null)
                    throw new Exception("No configuration for database found.");
                return appSettings;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error reading JSON file: {ex.Message}");
                return new ();
            }
           
        }

    }
}
