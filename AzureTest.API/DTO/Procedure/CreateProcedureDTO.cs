namespace VetClinic.API.DTO.ProcedureDTO
{
    public class CreateProcedureDto
    {
        public string ProcedureName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
