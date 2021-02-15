using System;
using System.Collections.Generic;

namespace VetClinic.API.DTO.Appointments
{
    public class UpdateAppointmentDto
    {
        public int AnimalId { get; set; }
        public int ServiceId { get; set; }
        public int StatusId { get; set; }
        public int DoctorId { get; set; }
        public IEnumerable<int> ProceduresIds { get; set; }
        public DateTimeOffset AppointmentDate { get; set; }
        public string Complaints { get; set; }
        public string TreatmentDescription { get; set; }
    }
}