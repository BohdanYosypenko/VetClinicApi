using System;
using System.Collections.Generic;

namespace VetClinic.API.DTO.Appointments
{
    public class AppointmentDto
    {
        public int Id { get; set; }
        public ClientDto Client { get; set; }
        public AnimalDto Animal { get; set; }
        public ServiceDto Service { get; set; }
        public StatusDto Status { get; set; }
        public DoctorDto Doctor { get; set; }
        public IEnumerable<ProcedureDto> PerformedProcedures { get; set; }
        public DateTimeOffset AppointmentDate { get; set; }
        public string Complaints { get; set; }
        public string TreatmentDescription { get; set; }
    }
}