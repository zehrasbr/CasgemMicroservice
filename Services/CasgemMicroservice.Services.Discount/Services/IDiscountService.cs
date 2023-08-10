using CasgemMicroservice.Services.Discount.Dtos;
using CasgemMicroservice.Services.Discount.Models;
using CasgemMicroservice.Shared.Dtos;

namespace CasgemMicroservice.Services.Discount.Services
{
	public interface IDiscountService
	{
		Task<Response<List<ResultDiscountDto>>> GetAllDiscountCouponsAsync();
		Task<Response<ResultDiscountDto>> GetByIdDiscountCouponAsync(int id);
		Task<Response<NoContent>> CreateDiscountCoupunsAsync(CreateDiscountDto createDiscountDto);
		Task<Response<NoContent>> UpdateDiscountCouponsAsync(UpdateDiscountDto updateDiscountDto);
		Task<Response<NoContent>> DeleteDiscountCouponsAsync(int id);
	}
}
