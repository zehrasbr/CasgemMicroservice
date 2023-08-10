using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Shared.Services
{
	public interface ISharedIdentityService
	{
		public string GetUserID { get; }
	}
}
