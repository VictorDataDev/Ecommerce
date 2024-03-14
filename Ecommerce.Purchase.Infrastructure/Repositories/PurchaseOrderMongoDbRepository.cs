using Ecommerce.Purchase.Core.Entities;
using Ecommerce.Purchase.Core.Interfaces;
using MongoDB.Driver;

namespace Ecommerce.Purchase.Infrastructure.Repositories
{
    public class PurchaseOrderMongoDbRepository : IPurchaseOrderRepository
    {
        private readonly IMongoCollection<PurchaseOrder> _collection;

        public PurchaseOrderMongoDbRepository(IMongoDatabase database)
        {
            _collection = database.GetCollection<PurchaseOrder>("PurchaseOrder");
        }

        public PurchaseOrder Add(PurchaseOrder purchaseOrder)
        {
            _collection.InsertOneAsync(purchaseOrder);
            return purchaseOrder;
        }

        public PurchaseOrder Update(PurchaseOrder purchaseOrder)
        {
            var filter = Builders<PurchaseOrder>.Filter.Eq(p => p.InternalOrderId,purchaseOrder.InternalOrderId);

            var updatedObject = Builders<PurchaseOrder>.Update
                .Set(u => u.UpdateAt, purchaseOrder.UpdateAt)
                .Set(dtp => dtp.DataPaymentOrder, purchaseOrder.DataPaymentOrder)
                .Set(dto => dto.DataOrder, purchaseOrder.DataOrder)
                .Set(dtu => dtu.DataUser, purchaseOrder.DataUser);

            _collection.UpdateOneAsync(filter, updatedObject);

            return purchaseOrder;
        }

        public void Delete(Guid InternalOrderId)
        {
            _collection.DeleteOneAsync(c => c.InternalOrderId.Equals(InternalOrderId));
        }

        public List<PurchaseOrder> GetAll()
        {
            return _collection.Find(c => true).ToList();
        }

        public PurchaseOrder GetByInternalOrderId(Guid internalOrderId)
        {
           return _collection.Find(o => o.InternalOrderId.Equals(internalOrderId)).FirstOrDefault();
        }

        public PurchaseOrder GetByPublicOrderId(string publicOrderId)
        {
            return _collection.Find(o => o.PublicOrderId.Equals(publicOrderId)).FirstOrDefault();
        }
    }
}
