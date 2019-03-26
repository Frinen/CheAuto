﻿using System;
using System.Collections.Generic;
using System.Text;
using CheAuto.Models.Enums;

namespace CheAuto.Models.Dto
{
    public class CarComplectationUpdateDto : NamedDto
    {
        public int Price { get; set; }
        public DriveType DriveType { get; set; }
        public string Interior { get; set; }

        public int PassengerCount { get; set; }
        public double LoadCapacity { get; set; }

        public Guid EngineId { get; set; }
    }
}
