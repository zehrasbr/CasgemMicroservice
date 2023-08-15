using CasgemMicroservice.Services.Payment.WebApi.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroservice.Services.Payment.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly PaymentContext _context;

        public PaymentController(PaymentContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult PaymentList()
        {
            var values = _context.PaymentDetails.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult PaymentCreate(PaymentDetail paymentDetail)
        {
            _context.PaymentDetails.Add(paymentDetail);
            return Ok("Ödeme Yapıldı");
        }
    }
}
