namespace VetClinic.API.DTO.Queries
{
    public class DoctorsFiltrationQuery
    {
        public string Name { get; set; }
        public int? PositionId { get; set; }
        public string UserId { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
