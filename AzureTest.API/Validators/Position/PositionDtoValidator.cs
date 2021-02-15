using FluentValidation;
using VetClinic.API.DTO.Position.PositionDTO;

namespace VetClinic.API.Validators.Position
{
    public class PositionDtoValidator: AbstractValidator<PositionDto>
    {
        public PositionDtoValidator()
        {
            RuleFor(position=>position.PositionName).NotEmpty().WithMessage("Job title cannot be empty")
                .MaximumLength(30).WithMessage("Job title cannot be longer than 30 characters");
        }
    }
}
