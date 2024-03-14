using Ecommerce.Purchase.Core.Interfaces;
using Ecommerce.Purchase.Infrastructure.Configuration.MongoDB;
using Ecommerce.Purchase.Infrastructure.Configuration.RabbitMQ;
using Ecommerce.Purchase.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Purchase.Infrastructure
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services
                .AddMongo()
                .AddRabbitMQ()
                .AddRepositories();

            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPurchaseOrderRepository, PurchaseOrderMongoDbRepository>();

            return services;
        }
    }
}
