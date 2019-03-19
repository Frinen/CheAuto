using System.Collections.Generic;
using CheAuto.Models.Schema.Common;

namespace CheAuto.Models.Schema
{
    public class BodyType : NamedEntity
    {
        public IEnumerable<CarModel> CarModels { get; set; }
    }
}
