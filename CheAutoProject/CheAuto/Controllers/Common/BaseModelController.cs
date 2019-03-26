using System;
using CheAuto.Models;
using CheAuto.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebSockets;

namespace CheAuto.Controllers.Common
{
    public class BaseModelController<TService, TReadDto, TUpdateDto> : BaseController where TService : IBaseService<TReadDto, TUpdateDto>
    {
        protected TService _service;
        [HttpGet]
        public IActionResult Get()
        {
            var result = _service.GetList();
            return Ok(result);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(Guid id)
        {
            var result = _service.GetById(id);
            return Ok(result);
        }
        [HttpPost]
        public virtual IActionResult Create([FromBody] TUpdateDto model)
        {
            var createdModel = _service.Create(model);

            return new CreatedResult(string.Empty, createdModel);
        }
        [HttpPut("{id}")]
        public virtual IActionResult Update(Guid id, [FromBody] TUpdateDto model)
        {
            var updateModel = _service.Update(id, model);

            return new NoContentResult();
        }


        [HttpDelete("{id}")]
        public virtual IActionResult Delete(Guid id)
        {
            _service.Delete(id);

            return NoContent();
        }

    }
}
