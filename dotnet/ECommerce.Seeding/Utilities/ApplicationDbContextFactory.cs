using ECommerce.Persistence;
using ECommerce.Seeding.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Seeding.Utilities
{
    internal class ApplicationDbContextFactory(string filePath)
    {

        private Dictionary<DbServer, IDatabaseProvider> providers = new Dictionary<DbServer, IDatabaseProvider>()
        {
            {
                DbServer.SqlServer, new SqlProvider()
            },
            {
                DbServer.MySql, new MySqlProvider()
            }

        };
        private AppSettingReader _appSettingReader = new(filePath);
        public ApplicationDbContext Create()
        {
            var appSettingReader = _appSettingReader.Read();
            var dbServer = Enum.Parse(typeof(DbServer), appSettingReader.DatabaseProvider);
            return providers[(DbServer)dbServer].Create(appSettingReader);
        }
       

    }

    public interface IDatabaseProvider
    {
        ApplicationDbContext Create(AppSettingsModel appSettings);
    }

    public class SqlProvider() : IDatabaseProvider
    {
        public ApplicationDbContext Create(AppSettingsModel appSettings)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(appSettings.ConnectionStrings.SqlServerConnection);

            return new ApplicationDbContext(optionsBuilder.Options);
            
        }
    }

    public class MySqlProvider() : IDatabaseProvider
    {
        public ApplicationDbContext Create(AppSettingsModel appSettings)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseMySql(appSettings.ConnectionStrings.MySqlConnection, new MySqlServerVersion(new Version(8, 0, 32)));
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }

}
