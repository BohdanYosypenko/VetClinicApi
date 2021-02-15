namespace VetClinic.API.DTO.Queries
{
    public class AnimalsFiltrationQuery
    {
        public int? ClientId { get; set; }
        public int? AnimalTypeId { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
