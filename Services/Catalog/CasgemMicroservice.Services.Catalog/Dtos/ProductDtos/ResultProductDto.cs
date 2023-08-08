using CasgemMicroservice.Services.Catalog.Models;

namespace CasgemMicroservice.Services.Catalog.Dtos.ProductDtos
{
    public class ResultProductDto
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImage { get; set; }
        public string CategoryID { get; set; }
    }
}
