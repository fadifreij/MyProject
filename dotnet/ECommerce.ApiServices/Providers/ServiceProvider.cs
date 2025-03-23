using ECommerce.Domain.Entities;
using ECommerce.ServiceAbstraction.Common;
using ECommerce.Services.Common;

namespace E_Commerce.ApiServices.Providers
{
    public static class ServiceProvider
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
           
        }
    }
}
