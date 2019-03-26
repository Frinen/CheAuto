using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using CheAuto.Models;
using CheAuto.Models.Dto;
using CheAuto.Models.Schema;
using CheAuto.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CheAuto.Services
{
    public class CarManufacturerService : BaseService<CarManufacturer, CarManufacturerReadDto, CarManufacturerUpdateDto>, ICarManufacturerService
    {
        public CarManufacturerService(AppDbContext context) : base(context)
        {
        }

        public override List<CarManufacturerReadDto> GetList()
        {
            var list = Context.CarManufacturers.Where(x => x.Id != null).Include(x => x.Country);

            return list.Select(item => new CarManufacturerReadDto()
            {
                Country = item.Country.Name,
                Name = item.Name,
                Id = item.Id
            }).ToList();

        }

        public override CarManufacturerUpdateDto Create(CarManufacturerUpdateDto model)
        {
            var dbModel = new CarManufacturer
            {
                CountryId = model.CountryId,
                Id = model.Id,
                Name = model.Name
            };
            Context.CarManufacturers.Add(dbModel);
            Context.SaveChanges();
            return model;
        }

        public override CarManufacturerUpdateDto Update(Guid id, CarManufacturerUpdateDto model)
        {
            var dbModel = Context.CarManufacturers.Find(id);
            dbModel.CountryId = model.Id;
            dbModel.Name = model.Name;

            Context.CarManufacturers.Update(dbModel);
            Context.SaveChanges();

            return model;
        }
    }
}
