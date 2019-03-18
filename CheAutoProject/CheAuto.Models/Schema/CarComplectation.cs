using CheAuto.Models.Schema.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheAuto.Models.Schema
{
    public class CarComplectation : NamedEntity
    {
        public int Price { get; set; }

        public Engine Engine { get; set; }
        public Guid EngineId { get; set; }

        public BodyType BodyType { get; set; }
        public Guid BodyTypeId { get; set; }



    }
}
