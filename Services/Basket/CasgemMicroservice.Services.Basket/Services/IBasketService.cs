using CasgemMicroservice.Services.Basket.Dtos;
using CasgemMicroservice.Shared.Dtos;

namespace CasgemMicroservice.Services.Basket.Services
{
    public interface IBasketService
    {
        Task<Response<BasketDto>> GetBasket(string UserID);
        Task<Response<bool>> SaveOrUpdate(BasketDto basketDto);
        Task<Response<bool>> DeleteBasket(string UserID);
    }
}
