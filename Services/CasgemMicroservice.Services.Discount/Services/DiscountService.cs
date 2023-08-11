using AutoMapper;
using CasgemMicroservice.Services.Discount.Context;
using CasgemMicroservice.Services.Discount.Dtos;
using CasgemMicroservice.Services.Discount.Models;
using CasgemMicroservice.Shared.Dtos;
using Microsoft.EntityFrameworkCore;

namespace CasgemMicroservice.Services.Discount.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly DapperContext _dapperContext;

        private readonly IMapper _mapper;
        public Task<Response<NoContent>> CreateDiscountCoupunsAsync(CreateDiscountDto createDiscountDto)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> DeleteDiscountCouponsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<ResultDiscountDto>>> GetAllDiscountCouponsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<ResultDiscountDto>> GetByIdDiscountCouponAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> UpdateDiscountCouponsAsync(UpdateDiscountDto updateDiscountDto)
        {
            throw new NotImplementedException();
        }
    }
}
