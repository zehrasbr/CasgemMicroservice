using CasgemMicroservice.Services.Discount.Dtos;
using CasgemMicroservice.Services.Discount.Models;
using CasgemMicroservice.Shared.Dtos;

namespace CasgemMicroservice.Services.Discount.Services
{
	public class DiscountService : IDiscountService
	{
		private readonly IDiscountService _discountService;
		public Task<Response<NoContent>> CreateDiscountCoupuns(DiscountCoupons discountCoupons)
		{
			
		}

		public Task<Response<NoContent>> DeleteDiscountCoupons(int id)
		{

		}

		public Task<Response<List<ResultDiscountDto>>> GetAllDiscountCouponsAsync()
		{

		}

		public Task<Response<ResultDiscountDto>> GetByIdDiscountCoupon(int id)
		{

		}

		public Task<Response<NoContent>> UpdateDiscountCouponsAsync(DiscountCoupons discountCoupons)
		{

		}
	}
}
