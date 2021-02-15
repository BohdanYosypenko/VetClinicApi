using FluentValidation;
using FluentValidation.Validators;
using VetClinic.API.DTO.ClientDto;
using VetClinic.API.Validators.User;
using VetClinic.BLL.Services.Interfaces;

namespace VetClinic.API.Validators.Client
{
    public class UpdateClientDtoValidator : UpdateUserDtoValidator<UpdateClientDto>
    {
        public UpdateClientDtoValidator(IUserService service ) : base(service) 
        {
        }
    }
}
