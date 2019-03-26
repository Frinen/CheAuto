
using CheAuto.Controllers.Common;
using CheAuto.Models.Dto;
using CheAuto.Services.Interfaces;

namespace CheAuto.Controllers
{
    public class CarManufacturerController : BaseModelController<ICarManufacturerService, CarManufacturerReadDto, CarManufacturerUpdateDto>
    {
        public CarManufacturerController(ICarManufacturerService service)
        {
            _service = service;
        }
    }
}
