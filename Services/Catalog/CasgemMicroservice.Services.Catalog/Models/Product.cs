using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CasgemMicroservice.Services.Catalog.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImage { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryID { get; set; }
        [BsonIgnore]
        public Category Category { get; set; }
    }
}
