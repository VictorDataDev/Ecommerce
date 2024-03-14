using Ecommerce.Purchase.Application.Models.VO;
using Ecommerce.Purchase.Core.Entities;
using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace Ecommerce.Purchase.Application.Models.Request
{
    public class PurchaseOrderRequest
    {
        public Guid? InternalOrderId { get; set; }

        public string? PublicOrderId { get; set; }

        public DataPaymentOrder? DataPaymentOrderRequest { get; set; }

        public DataOrder? DataOrderRequest { get; set; }

        public DataUser? DataUserRequest { get; set; }


        public PurchaseOrder ToEntity()
        {
            string jsonDataPaymentOrderRequest = JsonConvert.SerializeObject(DataPaymentOrderRequest);
            string jsonDataOrderRequest = JsonConvert.SerializeObject(DataOrderRequest);
            string jsonDataUserRequest = JsonConvert.SerializeObject(DataUserRequest);

            return new PurchaseOrder(jsonDataPaymentOrderRequest, jsonDataOrderRequest, jsonDataUserRequest);
        }

    }
}
