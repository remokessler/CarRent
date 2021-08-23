using CarRent.Backend.Domain.Cars;
using CarRent.Backend.Domain.Contracts;
using CarRent.Backend.Domain.Customers;

using Microsoft.EntityFrameworkCore;

namespace CarRent.Backend.Infrastructure.Persistance
{
    public class CarRentDbContext : DbContext
    {
        public DbSet<Car> Blogs { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<CarClass> CarClass { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<RentContract> RentContracts { get; set; }
        public DbSet<ReservationContract> ReservationContracts { get; set; }

        public CarRentDbContext(DbContextOptions builder) : base(builder)
        {
            
        }
    }
}
