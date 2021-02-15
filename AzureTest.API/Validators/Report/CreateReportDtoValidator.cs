using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetClinic.API.DTO.Accountant;

namespace VetClinic.API.Validators.Report
{
    public class CreateReportDtoValidator : AbstractValidator<CreateReportDto>
    {
        public CreateReportDtoValidator()
        {
            RuleFor(createReportDto => createReportDto.DateReport).NotEmpty().WithMessage("Date report can not be empty");
           
            RuleFor(createReportDto => createReportDto.RentExpense).NotEmpty().WithMessage("Rent expenses can not be empty");
            RuleFor(createReportDto => createReportDto.RentExpense).GreaterThanOrEqualTo(0).WithMessage("Rent expenses can not be less then 0");

            RuleFor(createReportDto => createReportDto.AdvertisingExpense).NotEmpty().WithMessage("Advertising expenses can not be empty");
            RuleFor(createReportDto => createReportDto.AdvertisingExpense).GreaterThanOrEqualTo(0).WithMessage("Advertising expenses can not be less then 0");

            RuleFor(createReportDto => createReportDto.UtilitiesExpense).NotEmpty().WithMessage("Utilities expenses can not be empty");
            RuleFor(createReportDto => createReportDto.UtilitiesExpense).GreaterThanOrEqualTo(0).WithMessage("Utilities expenses can not be less then 0");

        }

    }
}
