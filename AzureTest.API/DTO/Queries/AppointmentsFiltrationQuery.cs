using System;

namespace VetClinic.API.DTO.Queries
{
    public class AppointmentsFiltrationQuery
    {
        public int? StatusId { get; set; }
        public int? ServiceId { get; set; }
        public int? DoctorId { get; set; }
        public int? AnimalId { get; set; }
        public int? ClientId { get; set; }
    }
}