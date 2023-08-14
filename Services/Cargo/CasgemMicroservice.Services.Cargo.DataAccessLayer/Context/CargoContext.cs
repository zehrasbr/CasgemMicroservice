using CasgemMicroservice.Services.Cargo.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Cargo.DataAccessLayer.Context
{
    public class CargoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=CasgemCargoDb;User=sa;Password=123456Aa*");
        }
        public DbSet<CargoState> CargoStates { get; set; }
        public DbSet<CargoDetail> CargoDetails { get; set; }
    }
}
