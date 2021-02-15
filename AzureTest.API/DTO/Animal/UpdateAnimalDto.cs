namespace VetClinic.API.DTO.Animal
{
    public class UpdateAnimalDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Photo { get; set; }
        public int AnimalTypeId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
