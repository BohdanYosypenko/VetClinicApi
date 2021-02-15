namespace VetClinic.API.DTO.ProcedureDTO
{
    public class ReadProcedureDto
    {
        public int Id { get; set; }
        public string ProcedureName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
