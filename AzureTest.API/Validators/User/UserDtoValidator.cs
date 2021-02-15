using FluentValidation;
using FluentValidation.Validators;
using VetClinic.API.DTO.User;

namespace VetClinic.API.Validators.User
{
    public class UserDtoValidator : AbstractValidator<UserDto>
    {
        public UserDtoValidator()
        {
            RuleFor(user => user.UserName).NotEmpty().WithMessage("Username cannot be empty")
                .MaximumLength(50).WithMessage("Username cannot be longer than 50 characters");

            RuleFor(user => user.FirstName).NotEmpty().WithMessage("First name cannot be empty")
                .MaximumLength(30).WithMessage("First name cannot be longer than 50 characters");

            RuleFor(user => user.LastName).NotEmpty().WithMessage("Last name cannot be empty")
                .MaximumLength(30).WithMessage("Last name cannot be longer than 30 characters");

            RuleFor(user => user.Email).NotEmpty().WithMessage("Email cannot be empty")
                //.EmailAddress(EmailValidationMode.AspNetCoreCompatible).WithMessage("Invalid email")
                .MaximumLength(50).WithMessage("Email cannot be longer than 50 characters");

            RuleFor(user => user.PhoneNumber).NotEmpty().WithMessage("Phone number cannot be empty")
                .MaximumLength(12).WithMessage("Phone number cannot be longer than 12 digits");
                //.Matches("^[0-9]{12}$").WithMessage("Valid phone number contains only digits");
        }
    }
}