using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CheAuto.Models;
using CheAuto.Models.Dto;
using CheAuto.Models.Schema;
using CheAuto.Services.Interfaces;

namespace CheAuto.Services
{
    public class CountryService : BaseService<Country, CountryDto, CountryDto>, ICountryService
    {
        public CountryService(AppDbContext context) : base(context)
        {
        }

        public override List<CountryDto> GetList()
        {
            var list = Context.Countries.Where(x => x.Id != null).ToList();
            var result = Mapper.Map<List<Country>, List<CountryDto>>(list);
            return result;
            
        }
    }
}
