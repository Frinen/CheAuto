using CheAuto.Models.Schema.Common;
using System.Collections.Generic;

namespace CheAuto.Models.Schema
{
    public class Engine : NamedEntity
    {
        public int PistonsCount { get; set; }
        public double Volume { get; set; }
        public double Power { get; set; }
        public double Torque { get; set; }

        IEnumerable<CarComplectation> CarComplectations { get; set; }
    }
}
