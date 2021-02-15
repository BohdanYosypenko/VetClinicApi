using System.Collections.Generic;

namespace VetClinic.DAL.Entities
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Photo { get; set; }
        public bool IsDeleted { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int AnimalTypeId { get; set; }
        public AnimalType AnimalType { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}