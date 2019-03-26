namespace CheAuto.Models.Dto
{
    public class CarModelReadDto : NamedDto
    {
        public CarManufacturerReadDto CarManufacturer { get; set; }
        public CarComplectationReadDto Complectation { get; set; }
        public BodyTypeDto BodyType { get; set; }
    }
}
