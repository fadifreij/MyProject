using ECommerce.Domain.Entities;
using ECommerce.ServiceAbstraction;
using ECommerce.ServiceAbstraction.Common;
using ECommerce.Services;





namespace E_Commerce.ApiServices.Providers
{
    public static class ServiceProvider
    {
        public static void AddServices(this IServiceCollection services)
        {
           // services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

        }
    }
}
