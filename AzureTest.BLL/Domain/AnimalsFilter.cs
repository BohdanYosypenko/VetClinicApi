namespace VetClinic.BLL.Domain
{
    public class AnimalsFilter
    {
        public int? ClientId { get; set; }
        public int? AnimalTypeId { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
