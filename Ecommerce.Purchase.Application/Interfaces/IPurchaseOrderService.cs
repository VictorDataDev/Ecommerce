
using Ecommerce.Purchase.Application.Models.Request;
using Ecommerce.Purchase.Application.Models.Response;
using Ecommerce.Purchase.Core.Entities;

namespace Ecommerce.Purchase.Application.Interfaces
{
    public interface IPurchaseOrderService
    {
        /*PurchaseOrderResponse*/
        PurchaseOrder Add(PurchaseOrderRequest purchaseOrderRequest);
        PurchaseOrderResponse Update(PurchaseOrderRequest purchaseOrderRequest);
        void Delete(Guid InternalOrderId);
        PurchaseOrderResponse GetByInternalOrderId(Guid internalOrderId);
        PurchaseOrderResponse GetByPublicOrderId(string publicOrderId);
        List<PurchaseOrderResponse> GetAll();
    }
}
