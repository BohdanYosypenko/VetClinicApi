using VetClinic.API.DTO.User;

namespace VetClinic.API.DTO.Doctor
{
    public class ReadDoctorDto : UserDto
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Education { get; set; }
        public string Biography { get; set; }
        public string Experience { get; set; }
        public string Photo { get; set; }
        public int PositionId { get; set; }
        public string PositionName { get; set; }
    }
}
