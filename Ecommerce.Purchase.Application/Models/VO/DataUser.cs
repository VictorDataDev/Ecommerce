namespace Ecommerce.Purchase.Application.Models.VO
{
    public class DataUser
    {
        public Guid UserId { get; set; }
        public string? Email { get; set; }
        public string? ResponsableName { get; set; }
        public string? DeliveryAddress { get; set; }
        public string? Phone { get; set; }
    }
}
