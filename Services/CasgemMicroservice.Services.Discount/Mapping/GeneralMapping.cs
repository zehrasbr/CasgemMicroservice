using AutoMapper;
using CasgemMicroservice.Services.Discount.Dtos;
using CasgemMicroservice.Services.Discount.Models;

namespace CasgemMicroservice.Services.Discount.Mapping
{
	public class GeneralMapping :Profile
	{
		public GeneralMapping() 
		{ 
			CreateMap<DiscountCoupons,ResultDiscountDto>().ReverseMap();
			CreateMap<DiscountCoupons,CreateDiscountDto>().ReverseMap();
			CreateMap<DiscountCoupons,UpdateDiscountDto>().ReverseMap();
		}

	}
}
