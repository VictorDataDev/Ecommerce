
namespace Ecommerce.Purchase.Application.Models.VO
{
    public class DataPaymentOrder
    {
        internal Guid InternalOrderId { get; set; }
        public string? NumberCard { get; set; }
        public string? ExpirationDateCard { get; set; }
        public string? SecurityNumberCard { get; set; }
        public string? OwnerName { get; set; }
        public string? InvoiceAddress { get; set; }
        public double? TotalPrice { get; set; }
        public string? TypeCoin { get; set;}
        public string? AdditionalNote{ get; set;}
    }
}
