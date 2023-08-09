using CasgemMicroservice.Services.Basket.Dtos;
using CasgemMicroservice.Shared.Dtos;
using System.Text.Json;

namespace CasgemMicroservice.Services.Basket.Services
{
    public class BasketService : IBasketService
    {
        private readonly RedisService _redisService;

        public BasketService(RedisService redisService)
        {
            _redisService = redisService;
        }

        public async Task<Response<bool>> DeleteBasket(string userID)
        {
            var status = await _redisService.GetDb().KeyDeleteAsync(userID);
            return status ? Response<bool>.Success(204) : Response<bool>.Fail("Sepet Bulunamadı", 404);
        }

        public async Task<Response<BasketDto>> GetBasket(string userID)
        {
            var existBasket = await _redisService.GetDb().StringGetAsync(userID);
            if (string.IsNullOrEmpty(existBasket))
            {
                return Response<BasketDto>.Fail("Sepet Bulunamadı", 404);
            }
            return Response<BasketDto>.Success(JsonSerializer.Deserialize<BasketDto>(existBasket), 200);
        }

        public async Task<Response<bool>> SaveOrUpdate(BasketDto basketDto)
        {
            var status = await _redisService.GetDb().StringSetAsync(basketDto.UserID, JsonSerializer.Serialize(basketDto));
            return status ? Response<bool>.Success(204) : Response<bool>.Fail("Sepet Güncelleme veya Ekleme yapılamadı", 500);

        }
    }
}
