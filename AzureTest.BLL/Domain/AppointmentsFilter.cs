namespace VetClinic.BLL.Domain
{
    public class AppointmentsFilter
    {
        public int? StatusId { get; set; }
        public int? ServiceId { get; set; }
        public int? DoctorId { get; set; }
        public int? AnimalId { get; set; }
        public int? ClientId { get; set; }
    }
}