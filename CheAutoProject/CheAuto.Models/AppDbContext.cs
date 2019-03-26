using System;
using CheAuto.Models.Schema;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace CheAuto.Models
{
    public class AppDbContext : IdentityDbContext<User,Role,Guid>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<Country> Countries{ get; set; }
        public DbSet<AvailableCar> AvailableCars { get; set; }
        public DbSet<BodyType> BodyTypes { get; set; }
        public DbSet<CarComplectation> CarComplectations{ get; set; }
        public DbSet<CarManufacturer> CarManufacturers { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<UserOrder> UserOrders{ get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserOrder>()
                .HasOne(uo => uo.User)
                .WithMany(uo => uo.UserOrders)
                .HasForeignKey(uo => uo.UserId);

            builder.Entity<UserOrder>()
                .HasOne(uo => uo.AvailableCar)
                .WithMany(uo => uo.UserOrders)
                .HasForeignKey(uo => uo.AvailableCarId);
        }
    }
}
