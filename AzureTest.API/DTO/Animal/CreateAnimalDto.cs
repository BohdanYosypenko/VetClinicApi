namespace VetClinic.API.DTO.Animal
{
    public class CreateAnimalDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Photo { get; set; }
        public int ClientId { get; set; }
        public int AnimalTypeId { get; set; }
    }
}
