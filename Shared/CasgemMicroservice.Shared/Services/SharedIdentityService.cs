using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Shared.Services
{
	public class SharedIdentityService : ISharedIdentityService
	{
		private readonly IHttpContextAccessor _httpContextAccessor;

		public string GetUserID => _httpContextAccessor.HttpContext.User.FindFirst("sub").Value;
	}
}
