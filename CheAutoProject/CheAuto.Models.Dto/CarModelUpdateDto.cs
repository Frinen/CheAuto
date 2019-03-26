using System;

namespace CheAuto.Models.Dto
{
    public class CarModelUpdateDto : NamedDto
    {
        public Guid CarManufacturerId { get; set; }
        public Guid CarComplectationId { get; set; }
        public Guid BodyTypeId { get; set; }
    }
}
