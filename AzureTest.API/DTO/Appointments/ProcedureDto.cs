namespace VetClinic.API.DTO.Appointments
{
    public class ProcedureDto
    {
        public int Id { get; set; }
        public string ProcedureName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}