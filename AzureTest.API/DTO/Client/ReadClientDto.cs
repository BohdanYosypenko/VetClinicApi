using VetClinic.API.DTO.User;

namespace VetClinic.API.DTO.ClientDto
{
    public class ReadClientDto : UserDto
    {
        public int Id { get; set; }
        public string UserId { get; set; }
    }
}
