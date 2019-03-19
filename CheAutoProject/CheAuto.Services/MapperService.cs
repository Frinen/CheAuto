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

            });
        }
    }
}
