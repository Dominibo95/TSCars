using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSCars.Entities;

namespace TSCars.Data
{
    public class TSCarsDbContext : DbContext
    {
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<BussinessPartners>Parts => Set<BussinessPartners>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageAppDb");
        }
    }
}
