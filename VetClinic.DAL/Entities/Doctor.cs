using System.Collections.Generic;

namespace VetClinic.DAL.Entities
{
    public class Doctor 
    {
        public int Id { get; set; }
        public string Education { get; set; }
        public string Biography { get; set; }
        public string Experience { get; set; }
        public string Photo { get; set; }
        public int PositionId { get; set; }


        public string UserId { get; set; }
        public User User { get; set; }
        public Position Position { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}