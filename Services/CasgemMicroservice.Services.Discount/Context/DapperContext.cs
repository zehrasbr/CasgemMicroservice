using CasgemMicroservice.Services.Discount.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CasgemMicroservice.Services.Discount.Context
{
	public class DapperContext : DbContext
	{
		private readonly IConfiguration _configuration;
		private readonly string _connectionstring;
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=localhost,1433;Database=CasgemDiscountDb;User=sa;Password=123456Aa*");
		}
		public DbSet<DiscountCoupons> DiscountCouponses { get; set; }
		public DapperContext(IConfiguration configuration)
		{
			_configuration = configuration;
			_connectionstring = _configuration.GetConnectionString("DefaultConnection");
		}
		public IDbConnection CreateConnection() => new SqlConnection(_connectionstring);

	}
}
