namespace Ecommerce.Purchase.Infrastructure.Configuration.MongoDB
{
    public  class MongoDbOptions
    {
        public string ConnectionString { get; set; } = string.Empty;
        public string Database { get; set; } = string.Empty;
    }
}
