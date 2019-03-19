using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CheAuto.Models.Dto;
using CheAuto.Models.Schema;

namespace CheAuto.Services
{
    public static class MapperService
    {
        public static void Init()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<BodyType, BodyTypeDto>();
                cfg.CreateMap<BodyTypeDto, BodyType>();

                cfg.CreateMap<CarComplectationDto, CarComplectation>();
                cfg.CreateMap<CarComplectation, CarComplectationDto>();

                cfg.CreateMap<CarManufacturerUpdateDto, CarManufacturer>();
                cfg.CreateMap<CarManufacturer, CarManufacturerUpdateDto>();
                cfg.CreateMap<CarManufacturerReadDto, CarManufacturer>();
                cfg.CreateMap<CarManufacturer, CarManufacturerReadDto>();
            });
        }
    }
}
