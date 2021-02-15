using FluentValidation;
using VetClinic.API.DTO.ProcedureDTO;

namespace VetClinic.API.Validators.Procedure
{
    public class UpdateProcedureDtoValidator : AbstractValidator<UpdateProcedureDto>
    {
        public UpdateProcedureDtoValidator()
        {
            RuleFor(proc => proc.ProcedureName).NotEmpty().WithMessage("Procedure name cannot be empty")
                .MaximumLength(100).WithMessage("Procedure name cannot be longer than 100 symbols");

            RuleFor(proc => proc.Description).NotEmpty().WithMessage("Description cannot be empty");

            RuleFor(proc => proc.Price).GreaterThan(0M).WithMessage("Price cannot be negative");
        }
    }
}
