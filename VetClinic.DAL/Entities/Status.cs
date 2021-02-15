using System.Collections.Generic;
using VetClinic.DAL.Enums;

namespace VetClinic.DAL.Entities
{
    public class Status
    {
        public int Id { get; set; }

        public StatusName StatusName { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
