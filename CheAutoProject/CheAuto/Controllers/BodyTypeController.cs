using CheAuto.Controllers.Common;
using CheAuto.Models.Dto;
using CheAuto.Models.Schema;
using CheAuto.Services.Interfaces;

namespace CheAuto.Controllers
{
    public class BodyTypeController : BaseModelController<IBodyTypeService, BodyTypeDto, BodyTypeDto>
    {
        public BodyTypeController(IBodyTypeService service)
        {
            _service = service;
        }
    }
}
