using FluentValidation;
using VetClinic.API.DTO.Post;

namespace VetClinic.API.Validators.Post
{
    public class UpdatePostDtoValidator : AbstractValidator<UpdatePostDto>
    {
        public UpdatePostDtoValidator()
        {
            RuleFor(x => x.Title)
               .NotEmpty()
               .WithMessage("Should not be empty")
               .MaximumLength(25)
               .WithMessage("Length should be less than 26");

            RuleFor(x => x.Subtitle)
                .NotEmpty()
                .WithMessage("Should not be empty")
                .MaximumLength(50)
                .WithMessage("Length should be less than 51");

            RuleFor(x => x.MainText)
                .NotEmpty()
                .WithMessage("Should not be empty")
                .MaximumLength(500)
                .WithMessage("Length should be less than 501");

            RuleFor(x => x.Photo)
                .NotEmpty()
                .WithMessage("Should not be empty")
                .MaximumLength(150)
                .WithMessage("Length should be less than 151");
        }
    }
}
