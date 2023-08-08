using MongoDB.Bson.Serialization.Attributes;

namespace CasgemMicroservice.Services.Catalog.Models
{
    public class Category
    {
        [BsonId]
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
