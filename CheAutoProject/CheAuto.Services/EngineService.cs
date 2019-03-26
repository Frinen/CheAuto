using System;
using System.Collections.Generic;
using CheAuto.Models;
using CheAuto.Models.Dto;
using CheAuto.Models.Schema;
using CheAuto.Services.Interfaces;
using  System.Linq;
namespace CheAuto.Services
{
    public class EngineService : BaseService<Engine, EngineDto, EngineDto>, IEngineService
    {
        public EngineService(AppDbContext context) : base(context)
        {
        }

        public override List<EngineDto> GetList()
        {
            var list = Context.Engines.Where(x => x.Id != null).Select(x => new EngineDto
            {
                Id = x.Id,
                Name = x.Name,
                PistonsCount = x.PistonsCount,
                Volume = x.Volume,
                Power = x.Power,
                Torque = x.Torque
            }).ToList();
            return list;
        }

        public IQueryable<IGrouping<int, Engine>> GetGroup()
        {
            return Context.Engines.GroupBy(x => x.PistonsCount);
        }

        public double Avg()
        {
            return Context.Engines.Average(x => x.Volume);
        }

        public List<EngineDto> GetSorted()
        {
            var list = Context.Engines.Where(x => x.Id != null).Select(x => new EngineDto
            {
                Id = x.Id,
                Name = x.Name,
                PistonsCount = x.PistonsCount,
                Volume = x.Volume,
                Power = x.Power,
                Torque = x.Torque
            }).OrderBy(x => x.Volume).ToList();
            return list;
        }

        public List<EngineDto> GetCondition(int piston)
        {
            var list = Context.Engines.Where(x => x.PistonsCount > piston).Select(x => new EngineDto
            {
                Id = x.Id,
                Name = x.Name,
                PistonsCount = x.PistonsCount,
                Volume = x.Volume,
                Power = x.Power,
                Torque = x.Torque
            }).ToList();
            return list;
        }
    }
}
