namespace Ecommerce.Purchase.Infrastructure.Interfaces
{
    public interface IMessageBusService
    {
        void SendMessage(object data, string routingKey);
    }
}
