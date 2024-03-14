namespace Ecommerce.Purchase.Core.Entities
{
    public class PurchaseOrder
    {
        public Guid InternalOrderId { get; internal set; }

        public string? PublicOrderId { get; internal set; }

        public DateTime CreateAt { get; internal set; }

        public DateTime? UpdateAt { get; set; }

        public string? DataPaymentOrder { get; internal set; }

        public string? DataOrder { get; internal set; }

        public string? DataUser { get; internal set; }


        public PurchaseOrder(string dataPaymentOrder, string dataOrder, string dataUser)
        {
            this.DataOrder = dataOrder;
            this.DataUser = dataUser;
            this.DataPaymentOrder = dataPaymentOrder;

            this.InternalOrderId = Guid.NewGuid();
            this.PublicOrderId = GeneratePublicOrderNumber();
            this.CreateAt = DateTime.Now;
        }

        public void Edit(string dataPaymentOrder, string dataOrder, string dataUser)
        {
            this.DataOrder = dataOrder;
            this.DataUser = dataUser;
            this.DataPaymentOrder = dataPaymentOrder;

            this.UpdateAt = DateTime.Now;
        }

        public string GeneratePublicOrderNumber()
        {
            return $"ORD{new Random().Next(1,Int32.MaxValue)}";
        }
    }
}
