using Ecommerce.Purchase.Core.Entities;

namespace Ecommerce.Purchase.Core.Interfaces
{
    public interface IPurchaseOrderRepository
    {
        PurchaseOrder Add(PurchaseOrder purchaseOrder);
        PurchaseOrder Update(PurchaseOrder purchaseOrder);
        void Delete(Guid InternalOrderId);
        PurchaseOrder GetByInternalOrderId(Guid internalOrderId);
        PurchaseOrder GetByPublicOrderId(string publicOrderId);
        List<PurchaseOrder> GetAll();
    }
}
