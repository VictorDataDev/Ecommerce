
namespace Ecommerce.Purchase.Application.Models.VO
{
    public class OrderItem
    {
        public string? ProductName { get; set; }
        public string? CodeProduct { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
    }
}
