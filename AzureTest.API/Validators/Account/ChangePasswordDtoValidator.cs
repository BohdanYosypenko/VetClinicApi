using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetClinic.API.DTO.Account;
using VetClinic.BLL.Services.Interfaces;

namespace VetClinic.API.Validators.Account
{
    public class ChangePasswordDtoValidator : AbstractValidator<ChangePasswordDto>
    {
        public ChangePasswordDtoValidator(IUserService userService)
        {

            RuleFor(form => form.OldPassword).NotEmpty().WithMessage("Password cannot be empty")
                .MinimumLength(8).WithMessage("Password must be longer than 8 characters")
                .Matches(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$")
                .WithMessage("Valid password must have only upper and lower case latin characters and digits and special characters")
                .MaximumLength(128).WithMessage("Password is too long");

            RuleFor(form => form).Must(form => 
            {

                return userService.OldPasswordExists(form.Id, form.OldPassword).Result;
            }).WithMessage("Old password is incorrect");

            RuleFor(form => form.NewPassword).NotEmpty().WithMessage("Password cannot be empty")
                .MinimumLength(8).WithMessage("Password must be longer than 8 characters")
                .Matches(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$")
                .WithMessage("Valid password must have only upper and lower case latin characters and digits and special characters")
                .MaximumLength(128).WithMessage("Password is too long");
        }
    }
}
