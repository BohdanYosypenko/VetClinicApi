using FluentValidation;
using FluentValidation.Validators;
using VetClinic.API.DTO.User;
using VetClinic.BLL.Services.Interfaces;

namespace VetClinic.API.Validators.User
{
    public class CreateUserDtoValidator<T> : AbstractValidator<T> where T:CreateUserDto
    {
        public CreateUserDtoValidator(IUserService userService)
        {
            RuleFor(user => user.UserName).NotEmpty().WithMessage("Username cannot be empty")
                .MaximumLength(50).WithMessage("Username cannot be longer than 50 characters")
                .Must(name =>
                {
                    if(name != null)
                    {

                        return !userService.UserNameExistsAsync(name).Result;
                    }
                    return false;
                })
                .WithMessage("Username already exists");

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

            RuleFor(user => user.Password).NotEmpty().WithMessage("Password cannot be empty")
                .MinimumLength(8).WithMessage("Password must be longer than 8 characters")
                .Matches(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$")
                .WithMessage("Valid password must have only upper and lower case latin characters and digits and special characters")
                .MaximumLength(128).WithMessage("Password is too long");
        }
    }
}