using System;
using System.Collections.Generic;
using CheAuto.Models;
using CheAuto.Models.Dto;
using CheAuto.Models.Schema;
using System.Linq;
using CheAuto.Models.Enums;
using CheAuto.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CheAuto.Services
{
    public class CarComplectationService : BaseService<CarComplectation, CarComplectationReadDto, CarComplectationUpdateDto>, ICarComplectationService
    {
        public CarComplectationService(AppDbContext context) : base(context)
        {
        }
        
        public override List<CarComplectationReadDto> GetList()
        {
            var list = Context.CarComplectations.Where(x => x.Id != null).Include(y => y.Engine).Select(x => new CarComplectationReadDto
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                DriveType = x.DriveType,
                Interior = x.Interior,
                PassengerCount = x.PassengerCount,
                LoadCapacity = x.LoadCapacity,
                Engine = new EngineDto
                {
                    Id = x.EngineId,
                    Name = x.Engine.Name,
                    PistonsCount = x.Engine.PistonsCount,
                    Volume = x.Engine.Volume,
                    Power = x.Engine.Power,
                    Torque = x.Engine.Torque 
                }
            }).ToList();
            return list;
        }

        public override CarComplectationUpdateDto Create(CarComplectationUpdateDto model)
        {
            var dbModel = new CarComplectation
            {
                Id = model.Id,
                Name = model.Name,
                Price = model.Price,
                DriveType = model.DriveType,
                Interior = model.Interior,
                PassengerCount = model.PassengerCount,
                LoadCapacity = model.LoadCapacity,
                EngineId = model.EngineId
            };
            Context.CarComplectations.Add(dbModel);
            Context.SaveChanges();
            return model;
        }

        public override CarComplectationReadDto GetById(Guid id)
        {
            var dbModel = Context.CarComplectations.Include(x => x.Engine).FirstOrDefault(x => x.Id == id);
            
            var result = new CarComplectationReadDto
            {
                Id = dbModel.Id,
                Name = dbModel.Name,
                Price = dbModel.Price,
                DriveType = dbModel.DriveType,
                Interior = dbModel.Interior,
                PassengerCount = dbModel.PassengerCount,
                LoadCapacity = dbModel.LoadCapacity,
                Engine = new EngineDto
                {
                    Id = dbModel.Engine.Id,
                    Name = dbModel.Engine.Name,
                    PistonsCount = dbModel.Engine.PistonsCount,
                    Volume = dbModel.Engine.Volume,
                    Power = dbModel.Engine.Power,
                    Torque = dbModel.Engine.Torque
                } 
            };
            return result;
        }

        public override CarComplectationUpdateDto Update(Guid id, CarComplectationUpdateDto model)
        {
            var dbModel = Context.CarComplectations.Find(id);

            dbModel.EngineId = model.EngineId;
            dbModel.DriveType = model.DriveType;
            dbModel.Interior = model.Interior;
            dbModel.LoadCapacity = model.LoadCapacity;
            dbModel.Price = model.Price;

            Context.CarComplectations.Update(dbModel);
            Context.SaveChanges();
            return model;
        }
    }
}
