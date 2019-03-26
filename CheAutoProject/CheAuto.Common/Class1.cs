using System;
using System.Threading.Tasks;
using CheAuto.Models;
using CheAuto.Models.Enums;
using CheAuto.Models.Schema;
using Microsoft.EntityFrameworkCore.Internal;

namespace CheAuto.Common
{
    public class Seeder
    {
        readonly AppDbContext _context;

        public Seeder(AppDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.CarModels.Any())
            {
                var country = new Country
                {
                    Id = new Guid(),
                    Name = "Country"
                };
                _context.Countries.Add(country);
                await _context.SaveChangesAsync();

                var carManufacturer = new CarManufacturer
                {
                    Id = new Guid(),
                    Name = "Manufacturer",
                    CountryId = country.Id
                };
                _context.CarManufacturers.Add(carManufacturer);
                _context.SaveChanges();

                var engine = new Engine
                {
                    Id = new Guid(),
                    Name = "Engine",
                    PistonsCount = 4,
                    Volume = 1.6,
                    Power = 70,
                    Torque = 120
                };
                _context.Engines.Add(engine);
                await _context.SaveChangesAsync();

                var carComplectation = new CarComplectation
                {
                    Id = new Guid(),
                    Name = "Complectation",
                    Price = 1140,
                    DriveType = DriveType.FWD,
                    Interior = "interior",
                    PassengerCount = 4,
                    LoadCapacity = 1200,
                    EngineId = engine.Id
                };
                _context.CarComplectations.Add(carComplectation);
                await _context.SaveChangesAsync();

                var bodyType = new BodyType
                {
                    Id = new Guid(),
                    Name = "Body"
                };
                _context.BodyTypes.Add(bodyType);
                await _context.SaveChangesAsync();

                var carModel = new CarModel
                {
                    Id = new Guid(),
                    Name = "Car",
                    CarManufacturerId = carManufacturer.Id,
                    BodyTypeId = bodyType.Id,
                    CarComplectationId = carComplectation.Id
                };
                _context.CarModels.Add(carModel);
                await _context.SaveChangesAsync();
            }
        }
    }
}
