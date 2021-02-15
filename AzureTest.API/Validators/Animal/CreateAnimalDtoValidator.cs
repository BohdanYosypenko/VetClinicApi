using FluentValidation;
using VetClinic.API.DTO.Animal;

namespace VetClinic.API.Validators.Animal
{
    public class CreateAnimalDtoValidator : AbstractValidator<CreateAnimalDto>
    {
        public CreateAnimalDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Should not be empty")
                .MaximumLength(20)
                .WithMessage("Length should be less than 21");

            RuleFor(x => x.Age)
                .GreaterThan(-1)
                .WithMessage("Age can not be negative");

            RuleFor(x=>x.Photo)
                .MaximumLength(150)
                .WithMessage("Length should be less than 151");

            RuleFor(x => x.ClientId)
                .NotEmpty()
                .WithMessage("Should not be empty");

            RuleFor(x => x.AnimalTypeId)
                .NotEmpty()
                .WithMessage("Should not be empty");
        }
    }
}
