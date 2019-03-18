using CheAuto.Models.Schema.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheAuto.Models.Schema
{
    public class CarManufacturer : NamedEntity
    {
        public Guid CountryId { get; set; }
        public Country Country { get; set; }
    }
}
