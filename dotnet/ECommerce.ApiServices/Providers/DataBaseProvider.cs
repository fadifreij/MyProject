using ECommerce.Persistence;
using Microsoft.EntityFrameworkCore;
using System;

namespace E_Commerce.ApiServices.Providers
{
    public static class DataBaseProvider
    {
        public static void AddDatabaseContext(this WebApplicationBuilder builder, string databaseProvider)
        {
            if (databaseProvider == "MySql")
            {
                builder.Services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseMySql(builder.Configuration.GetConnectionString("MySqlConnection"),
                        new MySqlServerVersion(new Version(8, 0, 32))));
            }
            else if (databaseProvider == "SqlServer")
            {
                builder.Services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnection")));
            }
            else
            {
                throw new InvalidOperationException("Invalid database provider specified in configuration.");
            }
        }
    }
}
