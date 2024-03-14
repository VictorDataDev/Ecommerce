

namespace Ecommerce.Purchase.Application.Models.Response
{
    public class PurchaseOrderResponse
    {
        public Guid InternalOrderId { get; set; }

        public string? PublicOrderId { get; set; }
    }
}
