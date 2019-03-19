using System.Collections.Generic;
using CheAuto.Models.Schema.Common;

namespace CheAuto.Models.Schema
{
    public class Country : NamedEntity
    {
        IEnumerable <CarManufacturer> CarManufacturers { get; set; }
    }
}
