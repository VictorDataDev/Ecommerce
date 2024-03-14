
namespace Ecommerce.Purchase.Application.Models.VO
{
    public class DataOrder
    {
        public decimal TotalPrice { get; set; }
         
        public List<OrderItem> OrderItems { get; set; }  
    }
}
