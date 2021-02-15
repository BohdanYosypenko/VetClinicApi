using System.Collections.Generic;

namespace VetClinic.DAL.Entities
{
    public class Position 
    {
        public int Id { get; set; }
        public string PositionName { get; set; }
        public decimal Salary { get; set; }

        public ICollection<Doctor> Doctors { get; set; }
    }
}
