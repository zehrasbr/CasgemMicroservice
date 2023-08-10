using CasgemMicroservice.Services.Basket.Dtos;
using CasgemMicroservice.Services.Basket.Services;
using CasgemMicroservice.Shared.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroservice.Services.Basket.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BasketsController : ControllerBase
	{
		private readonly IBasketService _basketService;
		private readonly ISharedIdentityService _sharedIdentityService;

		public BasketsController(ISharedIdentityService sharedIdentityService, IBasketService basketService)
		{
			_sharedIdentityService = sharedIdentityService;
			_basketService = basketService;
		}
		[HttpGet]
		public async Task<IActionResult> GetBasket()
		{
			return Ok(await _basketService.GetBasket(_sharedIdentityService.GetUserID));
		}
		[HttpPost]
		public async Task<IActionResult> SaveOrUpdateBasket(BasketDto basketDto)
		{
			basketDto.UserID = _sharedIdentityService.GetUserID;
			var response = await _basketService.SaveOrUpdate(basketDto);
			return Ok(response);
		}
		[HttpDelete]
		public async Task<IActionResult> DeleteBasket()
		{
			return Ok(await _basketService.DeleteBasket(_sharedIdentityService.GetUserID));
		}
	}
}
