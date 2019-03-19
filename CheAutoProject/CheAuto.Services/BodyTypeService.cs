using System;
using System.Collections.Generic;
using System.Text;
using CheAuto.Models;
using CheAuto.Models.Dto;
using CheAuto.Models.Schema;
using CheAuto.Services.Interfaces;

namespace CheAuto.Services
{
    public class BodyTypeService : BaseService<BodyType, BodyTypeDto, BodyTypeDto>, IBodyTypeService
    {
        public BodyTypeService(AppDbContext context) : base(context)
        {
        }

        public override List<BodyTypeDto> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
