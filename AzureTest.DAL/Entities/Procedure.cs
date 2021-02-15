using System.Collections.Generic;

namespace VetClinic.DAL.Entities
{
    public class Procedure 
    {
        public int Id { get; set; }
        public string ProcedureName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public ICollection<AppointmentProcedures> AppointmentProcedures { get; set; }
    }
}
