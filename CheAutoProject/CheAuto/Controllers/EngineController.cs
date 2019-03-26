using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheAuto.Controllers.Common;
using CheAuto.Models.Dto;
using CheAuto.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CheAuto.Controllers
{
    public class EngineController :BaseModelController<IEngineService, EngineDto, EngineDto>
    {
        public EngineController(IEngineService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("group")]
        public IActionResult GetGroup()
        {
            var result = _service.GetGroup();
            return Ok(result);
        }
        [HttpGet]
        [Route("sorted")]
        public IActionResult GetSorted()
        {
            var result = _service.GetSorted();
            return Ok(result);
        }
        [HttpGet]
        [Route("condition{id}")]
        public IActionResult GetCondition(int id)
        {
            var result = _service.GetCondition(id);
            return Ok(result);
        }
        [HttpGet]
        [Route("Avg")]
        public IActionResult GetAvg()
        {
            var result = _service.Avg();
            return Ok(result);
        }


    }
    
}
