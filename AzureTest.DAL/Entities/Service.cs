using System.Collections.Generic;

namespace VetClinic.DAL.Entities
{
    public class Service 
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
