
using Ecommerce.Purchase.Application.Interfaces;
using Ecommerce.Purchase.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Purchase.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services
                .AddApplicationServices();

            return services;
        }

        private static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IPurchaseOrderService, PurchaseOrderService>();

            return services;
        }
    }
}
