using FluentValidation;
using VetClinic.API.DTO.Appointments;
using VetClinic.DAL.Repositories.Interfaces;

namespace VetClinic.API.Validators.Appointments
{
    public class CreateAppointmentDtoValidator : AbstractValidator<CreateAppointmentDto>
    {
        public CreateAppointmentDtoValidator(IRepositoryWrapper repositoryWrapper)
        {
            RuleFor(a => a.AnimalId)
                .NotEmpty()
                .WithMessage("Should not be empty")
                .MustAsync(async (id, cancellation) =>
                {
                    return await repositoryWrapper.AnimalRepository.IsAnyAsync(animal => animal.Id == id);
                })
                .WithMessage(appointment => $"Animal with id {appointment.AnimalId} doesn't exist");

            
            RuleFor(a => a.ServiceId)
                .NotEmpty()
                .WithMessage("Should not be empty")
                .MustAsync(async (id, cancellation) =>
                {
                    return await repositoryWrapper.ServiceRepository.IsAnyAsync(service => service.Id == id);
                })
                .WithMessage(appointment => $"Service with id {appointment.ServiceId} doesn't exist");
            
            
            RuleFor(a => a.AppointmentDate)
                .NotEmpty()
                .WithMessage("Should not be empty");

            
            RuleFor(a => a.Complaints)
                .NotEmpty()
                .WithMessage("Should not be empty")
                .MaximumLength(100)
                .WithMessage("Should contain less than 100 characters");
        }
    }
}