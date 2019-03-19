namespace CheAuto.Models.Dto
{
    public class CarModelDto : NamedDto
    {
        public CarManufacturerUpdateDto CarManufacturer { get; set; }
        public CarComplectationDto Complectation { get; set; }
        public BodyTypeDto BodyType { get; set; }
    }
}
