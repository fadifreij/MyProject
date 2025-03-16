using ECommerce.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Seeding.Utilities
{
    internal class DbInitializer
    {
        private string _filePath;
        private ApplicationDbContextFactory _contextFactory;
        public DbInitializer()
        {
            // Path to the JSON file
          
            _filePath = $"{AppContext.BaseDirectory}\\appsettings.json";
            _contextFactory = new(_filePath);
        }

        public ApplicationDbContext Create() => _contextFactory.Create();
       
    }
}
