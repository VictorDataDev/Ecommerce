using Ecommerce.Purchase.Infrastructure.Interfaces;
using Ecommerce.Purchase.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Purchase.Infrastructure.Configuration.RabbitMQ
{
    public static class RabbitMQConfig
    {
        public static IServiceCollection AddRabbitMQ(this IServiceCollection services)
        {
            services.AddScoped<IMessageBusService, RabbitMqService>();

            return services;
        }
    }
}
