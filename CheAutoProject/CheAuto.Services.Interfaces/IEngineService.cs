using System.Collections.Generic;
using System.Linq;
using CheAuto.Models.Dto;
using CheAuto.Models.Schema;

namespace CheAuto.Services.Interfaces
{
    public interface IEngineService : IBaseService<EngineDto, EngineDto>
    {
        IQueryable<IGrouping<int, Engine>> GetGroup();
        List<EngineDto> GetSorted();
        List<EngineDto> GetCondition(int piston);
        double Avg();
    }
}
