using VetClinic.BLL.Exceptions;

namespace VetClinic.API.DTO.Error
{
    public class ErrorDto
    {
        public int Status { get; set; }
        public string Title { get; set; }
        public FieldErrorModel[] Errors { get; set; } = new FieldErrorModel[] { };
    }
}