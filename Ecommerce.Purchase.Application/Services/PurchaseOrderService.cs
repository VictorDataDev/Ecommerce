using Ecommerce.Purchase.Application.Interfaces;
using Ecommerce.Purchase.Application.Models.Request;
using Ecommerce.Purchase.Application.Models.Response;
using Ecommerce.Purchase.Core.Entities;
using Ecommerce.Purchase.Core.Interfaces;
using Ecommerce.Purchase.Infrastructure.Enum;
using Ecommerce.Purchase.Infrastructure.Interfaces;

namespace Ecommerce.Purchase.Application.Services
{
    public class PurchaseOrderService : IPurchaseOrderService
    {
        private readonly IPurchaseOrderRepository _repository;
        private readonly IMessageBusService _messageBus;
        public PurchaseOrderService(IPurchaseOrderRepository repository, IMessageBusService messageBus)
        {
            _repository = repository;
            _messageBus = messageBus;
        }

        public /*PurchaseOrderResponse*/ PurchaseOrder Add(PurchaseOrderRequest purchaseOrderRequest)
        {
            var orderRequest = purchaseOrderRequest.ToEntity();
            var orderReponse = _repository.Add(orderRequest);

            _messageBus.SendMessage(purchaseOrderRequest.DataPaymentOrderRequest, nameof(RabbitMqQueues.purchase_order_payment));
            _messageBus.SendMessage(purchaseOrderRequest.DataOrderRequest, nameof(RabbitMqQueues.purchase_order));
            _messageBus.SendMessage(purchaseOrderRequest.DataUserRequest, nameof(RabbitMqQueues.purchase_order_notification));

            return orderReponse;
        }

        public void Delete(Guid InternalOrderId)
        {
            throw new NotImplementedException();
        }

        public List<PurchaseOrderResponse> GetAll()
        {
            throw new NotImplementedException();
        }

        public PurchaseOrderResponse GetByInternalOrderId(Guid internalOrderId)
        {
            throw new NotImplementedException();
        }

        public PurchaseOrderResponse GetByPublicOrderId(string publicOrderId)
        {
            throw new NotImplementedException();
        }

        public PurchaseOrderResponse Update(PurchaseOrderRequest purchaseOrderRequest)
        {
            throw new NotImplementedException();
        }
    }
}
