using CasgemMicroservice.Services.Discount.Dtos;
using CasgemMicroservice.Services.Discount.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroservice.Services.Discount.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DiscountCouponController : ControllerBase
	{
		private readonly IDiscountService _discountService;
		public DiscountCouponController(IDiscountService discountService)
		{
			_discountService = discountService;
		}
		[HttpGet]
		public async Task<IActionResult> GetAllDiscountsCouponAsync()
		{
			var values = await _discountService.GetAllDiscountCouponsAsync();
			return Ok(values);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetByIdDiscountCouponAsync(int id)
		{
			var values = await _discountService.GetByIdDiscountCouponAsync(id);
			return Ok(values);
		}
		[HttpPut]
		public async Task<IActionResult> UpdateDiscountCoupon(UpdateDiscountDto updateDiscountDto)
		{
			await _discountService.UpdateDiscountCouponsAsync(updateDiscountDto);
			return Ok("Kupon Başarıyla Güncellendi");
		}
		[HttpDelete]
		public async Task<IActionResult> DeleteDiscountCoupon(int id)
		{
			await _discountService.DeleteDiscountCouponsAsync(id);
			return Ok("Kupon Başarıyla Silindi");
		}
	}
}
