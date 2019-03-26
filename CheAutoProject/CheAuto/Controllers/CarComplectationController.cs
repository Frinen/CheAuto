using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheAuto.Controllers.Common;
using CheAuto.Models.Dto;
using CheAuto.Services.Interfaces;

namespace CheAuto.Controllers
{
    public class CarComplectationController : BaseModelController<ICarComplectationService, CarComplectationReadDto, CarComplectationUpdateDto>
    {
        public CarComplectationController(ICarComplectationService service)
        {
            _service = service;
        }
    }
}
