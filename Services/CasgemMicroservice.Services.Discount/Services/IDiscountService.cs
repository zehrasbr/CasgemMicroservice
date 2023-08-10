using CasgemMicroservice.Services.Discount.Dtos;
using CasgemMicroservice.Services.Discount.Models;
using CasgemMicroservice.Shared.Dtos;

namespace CasgemMicroservice.Services.Discount.Services
{
	public interface IDiscountService
	{
		Task<Response<List<ResultDiscountDto>>> GetAllDiscountCouponsAsync();
		Task<Response<ResultDiscountDto>> GetByIdDiscountCoupon(int id);
		Task<Response<NoContent>> CreateDiscountCoupuns(DiscountCoupons discountCoupons);
		Task<Response<NoContent>> UpdateDiscountCouponsAsync(DiscountCoupons discountCoupons);
		Task<Response<NoContent>> DeleteDiscountCoupons(int id);
	}
}
