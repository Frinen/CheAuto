using CheAuto.Models.Schema.Common;
using System.Collections.Generic;

namespace CheAuto.Models.Schema
{
    public class BodyType : NamedEntity
    {
        public IEnumerable<CarModel> CarModels { get; set; }
    }
}
