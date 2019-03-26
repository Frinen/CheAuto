using System;
using CheAuto.Controllers.Common;
using CheAuto.Models.Dto;
using CheAuto.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CheAuto.Controllers
{
    public class CountryController : BaseModelController<ICountryService, CountryDto, CountryDto>
    {
        public CountryController(ICountryService service)
        {
            _service = service;
        }
        
    }
}
