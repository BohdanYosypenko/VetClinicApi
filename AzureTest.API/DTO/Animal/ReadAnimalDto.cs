namespace VetClinic.API.DTO.Animal
{
    public class ReadAnimalDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Photo { get; set; }
        public AnimalClientDto Client { get; set; }
        public int AnimalTypeId { get; set; }
        public string AnimalTypeName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
