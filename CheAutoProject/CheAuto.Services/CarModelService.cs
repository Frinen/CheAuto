using System;
using System.Collections.Generic;
using System.Linq;
using CheAuto.Models;
using CheAuto.Models.Dto;
using CheAuto.Models.Schema;
using CheAuto.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CheAuto.Services
{
    public class CarModelService : BaseService<CarModel, CarModelReadDto, CarModelUpdateDto>, ICarModelService
    {
        public CarModelService(AppDbContext context) : base(context)
        {
        }

        public override List<CarModelReadDto> GetList()
        {
            var result = Context.CarModels.Where(x => x.Id != null)
                .Include(x => x.CarManufacturer)
                .Include(x => x.BodyType)
                .Include(x => x.CarComplectation)
                .Select(x => new CarModelReadDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    CarManufacturer = new CarManufacturerReadDto()
                    {
                        Id = x.CarManufacturerId,
                        Name = x.CarManufacturer.Name
                    },
                    Complectation = new CarComplectationReadDto
                    {
                        Id = x.CarComplectationId,
                        Name = x.CarComplectation.Name,
                        Price = x.CarComplectation.Price,
                        DriveType = x.CarComplectation.DriveType,
                        Interior = x.CarComplectation.Interior,
                        PassengerCount = x.CarComplectation.PassengerCount,
                        LoadCapacity = x.CarComplectation.LoadCapacity,
                        Engine = null
                    },
                    BodyType = new BodyTypeDto() { Id = x.BodyTypeId, Name = x.BodyType.Name}
                }).ToList();
            return result;
        }

        public override CarModelUpdateDto Create(CarModelUpdateDto model)
        {
            var dbModel = new CarModel
            {
                Id = model.Id,
                Name = model.Name,
                CarManufacturerId = model.CarManufacturerId,
                BodyTypeId = model.BodyTypeId,
                CarComplectationId = model.CarComplectationId
            };
            Context.CarModels.Add(dbModel);
            Context.SaveChanges();
            return model;
        }
    }
}
