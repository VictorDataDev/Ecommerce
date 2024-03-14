using Amazon.SecurityToken.Model.Internal.MarshallTransformations;
using Ecommerce.Purchase.Infrastructure.Interfaces;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace Ecommerce.Purchase.Infrastructure.Services
{
    public class RabbitMqService : IMessageBusService
    {
        private readonly IConnection _connection;
        private readonly IModel _channel;
        private const string _exchange = "purchase-service";
        public RabbitMqService()
        {
            var connectionFactory = new ConnectionFactory
            {
                HostName = "localhost",
                Port = 5672,
                UserName = "guest",
                Password = "guest"
            };

            _connection = connectionFactory.CreateConnection("purchase-service-publisher");

            _channel = _connection.CreateModel();

        }

        public void SendMessage(object data, string routingKey)
        {
            var payload = JsonConvert.SerializeObject(data);
            var byteArray = Encoding.UTF8.GetBytes(payload);

            _channel.QueueDeclare(routingKey,true,false,true);
            _channel.ExchangeDeclare(_exchange,"topic",true, true);
            _channel.QueueBind(routingKey, _exchange, _exchange);

            _channel.BasicPublish(_exchange,routingKey,null,byteArray);
        }
    }
}
