using System;
using System.Collections.Generic;
using CheAuto.Models.Schema.Common;

namespace CheAuto.Models.Schema
{
    public class CarManufacturer : NamedEntity
    {
        public Guid CountryId { get; set; }
        public Country Country { get; set; }

        public IEnumerable<CarModel> CarModels { get; set; }
    }
}
