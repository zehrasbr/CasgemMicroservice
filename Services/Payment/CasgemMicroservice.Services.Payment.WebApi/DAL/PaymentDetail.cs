namespace CasgemMicroservice.Services.Payment.WebApi.DAL
{
    public class PaymentDetail
    {
        public int PaymentDetailID { get; set; }
        public string CardNumber { get; set; }
        public string CustomerNameSurname { get; set; }
        public decimal Price { get; set; }
        public string PaymentStatus { get; set; }
    }
}
