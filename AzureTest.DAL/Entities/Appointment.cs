using System;
using System.Collections.Generic;

namespace VetClinic.DAL.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTimeOffset AppointmentDate { get; set; }
        public string Complaints { get; set; }
        public string TreatmentDescription { get; set; }

        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public int? DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public ICollection<AppointmentProcedures> AppointmentProcedures { get; set; }
    }
}