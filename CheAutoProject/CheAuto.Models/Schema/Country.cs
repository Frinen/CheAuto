using CheAuto.Models.Schema.Common;
using System.Collections.Generic;

namespace CheAuto.Models.Schema
{
    public class Country : NamedEntity
    {
        IEnumerable <CarManufacturer> CarManufacturers { get; set; }
    }
}
