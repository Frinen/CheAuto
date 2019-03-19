using System;
using System.Collections.Generic;
using CheAuto.Models.Enums;
using CheAuto.Models.Schema.Common;

namespace CheAuto.Models.Schema
{
    public class CarComplectation : NamedEntity
    {
        public int Price { get; set; }
        public DriveType DriveType { get; set; }
        public string Interior { get; set; }

        public int PassangerCount { get; set; }
        public double LoadCapacity { get; set; }

        public Engine Engine { get; set; }
        public Guid EngineId { get; set; }

        public IEnumerable<CarModel> CarModels { get; set; }
    }
}
