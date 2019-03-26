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

                cfg.CreateMap<CarComplectationReadDto, CarComplectation>();
                cfg.CreateMap<CarComplectation, CarComplectationReadDto>();

                cfg.CreateMap<CarManufacturerUpdateDto, CarManufacturer>();
                cfg.CreateMap<CarManufacturer, CarManufacturerUpdateDto>();
                cfg.CreateMap<CarManufacturerReadDto, CarManufacturer>();
                cfg.CreateMap<CarManufacturer, CarManufacturerReadDto>();

                cfg.CreateMap<CarModelReadDto, CarModel>();
                cfg.CreateMap<CarModel, CarModelReadDto>();

                cfg.CreateMap<CarModelUpdateDto, CarModel>();
                cfg.CreateMap<CarModel, CarModelUpdateDto>();

                cfg.CreateMap<CountryDto, Country>();
                cfg.CreateMap<Country, CountryDto>();

                cfg.CreateMap<DealerDto, Dealer>();
                cfg.CreateMap<Dealer, DealerDto>();

                cfg.CreateMap<EngineDto, Engine>();
                cfg.CreateMap<Engine, EngineDto>();

                cfg.CreateMap<DealerDto, Dealer>();
                cfg.CreateMap<Dealer, DealerDto>();

            });
        }
    }
}
