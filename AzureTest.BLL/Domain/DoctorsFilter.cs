namespace VetClinic.BLL.Domain
{
    public class DoctorsFilter
    {
        public string Name { get; set; }
        public int? PositionId { get; set; }
        public string UserId { get; set; }
        public bool? IsDeleted { get; set; } 
    }
}
