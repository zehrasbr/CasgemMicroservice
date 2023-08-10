using Microsoft.Data.SqlClient;
using System.Data;

namespace CasgemMicroservice.Services.Discount.Context
{
	public class DapperContext
	{
		private readonly IConfiguration _configuration;

		private readonly string _connectionstring;
		public DapperContext(IConfiguration configuration)
		{
			_configuration = configuration;
			_connectionstring = _configuration.GetConnectionString("DefaultConnection");
		}
		public IDbConnection CreateConnection() => new SqlConnection(_connectionstring);

	}
}
