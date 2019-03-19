using System;

namespace CheAuto.Models.Dto
{
    public class EngineDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int PistonsCount { get; set; }
        public double Volume { get; set; }
        public double Power { get; set; }
        public double Torque { get; set; }
    }
}