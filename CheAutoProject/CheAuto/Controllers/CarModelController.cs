using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheAuto.Controllers.Common;
using CheAuto.Models.Dto;
using CheAuto.Services.Interfaces;

namespace CheAuto.Controllers
{
    public class CarModelController : BaseModelController<ICarModelService, CarModelReadDto, CarModelUpdateDto>
    {
        public CarModelController(ICarModelService service)
        {
            _service = service;
        }
    }
}
