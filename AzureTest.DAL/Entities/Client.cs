using System.Collections.Generic;

namespace VetClinic.DAL.Entities
{
    public class Client
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
        public ICollection<Animal> Animals { get; set; }
    }
}