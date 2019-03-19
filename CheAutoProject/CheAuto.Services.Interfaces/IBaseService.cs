using System;
using System.Collections.Generic;

namespace CheAuto.Services.Interfaces
{
    public interface IBaseService <TReadDto, TUpdateDto>
    {
        TUpdateDto Create(TUpdateDto model);
        TUpdateDto Update(Guid id, TUpdateDto model);
        List<TReadDto> GetList();
        TReadDto GetById(Guid id);
        void Delete(Guid id);
    }
}
