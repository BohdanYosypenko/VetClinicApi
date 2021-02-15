namespace VetClinic.DAL.Entities
{
    public class AppointmentProcedures 
    {
        public int Id { get; set; }

        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; }
        public int ProcedureId { get; set; }
        public Procedure Procedure { get; set; }
    }
}
