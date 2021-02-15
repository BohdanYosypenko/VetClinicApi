using FluentValidation;
using VetClinic.API.DTO.Appointments;
using VetClinic.DAL.Repositories.Interfaces;

namespace VetClinic.API.Validators.Appointments
{
    public class UpdateAppointmentDtoValidator : AbstractValidator<UpdateAppointmentDto>
    {
        public UpdateAppointmentDtoValidator(IRepositoryWrapper repositoryWrapper)
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


            RuleFor(a => a.StatusId)
                .NotEmpty()
                .WithMessage("Should not be empty")
                .MustAsync(async (id, cancellation) =>
                {
                    return await repositoryWrapper.StatusRepository.IsAnyAsync(service => service.Id == id);
                })
                .WithMessage(appointment => $"Status with id {appointment.StatusId} doesn't exist");


            RuleFor(a => a.DoctorId)
                .NotEmpty()
                .WithMessage("Should not be empty")
                .MustAsync(async (id, cancellation) =>
                {
                    return await repositoryWrapper.DoctorRepository.IsAnyAsync(service => service.Id == id);
                })
                .WithMessage(appointment => $"Doctor with id {appointment.DoctorId} doesn't exist");


            RuleForEach(a => a.ProceduresIds)
                .NotNull()
                .WithMessage("Shoulb not be null")
                .MustAsync(async (id, cancellation) =>
                {
                    return await repositoryWrapper.ProcedureRepository.IsAnyAsync(p => p.Id == id);
                })
                .WithMessage((appointment, id) => $"Procedure with id {id} doesn't exist");

            
            RuleFor(a => a.AppointmentDate)
                .NotEmpty()
                .WithMessage("Should not be empty");


            RuleFor(a => a.Complaints)
                .NotEmpty()
                .WithMessage("Should not be empty")
                .MaximumLength(100)
                .WithMessage("Should contain less than 100 characters");


            RuleFor(a => a.TreatmentDescription)
                .MaximumLength(500)
                .WithMessage("Should contain less than 100 characters");
        }
    }
}