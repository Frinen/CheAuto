using CheAuto.Models.Schema.Common;
using System;

namespace CheAuto.Models.Schema
{
    public class CarModel : NamedEntity
    {
        public CarManufacturer CarManufacturer { get; set; }
        public Guid CarManufacturerId { get; set; }

        public BodyType BodyType { get; set; }
        public Guid BodyTypeId { get; set; }
        
        public CarComplectation CarComplectation { get; set; }
        public Guid CarComplectationId { get; set; }


    }
}
