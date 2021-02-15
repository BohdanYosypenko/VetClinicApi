using FluentValidation;
using VetClinic.API.DTO;

namespace VetClinic.API.Validators
{
    public class ServiceDtoValidator : AbstractValidator<ServiceDto>
    {
        public ServiceDtoValidator()
        {
            RuleFor(service => service.ServiceName).NotEmpty().WithMessage("The service name can not be empty")
                .MaximumLength(50).WithMessage("The service name can not be longer than 50 characters");
            RuleFor(service => service.Description).NotEmpty().WithMessage("The service description can not be empty")
                .MaximumLength(2000).WithMessage("The service description can not be longer than 2000 characters"); 
        }
    }
}
