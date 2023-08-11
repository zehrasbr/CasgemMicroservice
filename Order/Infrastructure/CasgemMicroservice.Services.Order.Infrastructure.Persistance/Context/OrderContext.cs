using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Infrastructure.Persistance.Context
{
    public class OrderContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=CasgemOrderDb;User=sa;Password=123456Aa*");
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Ordering> Orders { get; set; }
        public DbSet<OrderDetail> Details { get; set; }
    }
}
