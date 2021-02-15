using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using VetClinic.API.DTO.Appointments;
using VetClinic.DAL.Entities;

namespace VetClinic.API.Mapping
{
    public class AppointmentProfile : Profile
    {
        public AppointmentProfile()
        {
            CreateMap<Client, ClientDto>();
            CreateMap<Animal, AnimalDto>();
            CreateMap<Service, ServiceDto>();
            CreateMap<Status, StatusDto>();
            CreateMap<Doctor, DoctorDto>();
            CreateMap<Procedure, ProcedureDto>();

            CreateMap<Appointment, Appointment>()
                .ForMember(a => a.Id, opt => opt.Ignore())
                .ForMember(a => a.Animal, opt => opt.Ignore())
                .ForMember(a => a.Service, opt => opt.Ignore())
                .ForMember(a => a.Status, opt => opt.Ignore())
                .ForMember(a => a.Doctor, opt => opt.Ignore())
                .ForMember(a => a.AppointmentProcedures, opt => opt.Ignore());

            CreateMap<Appointment, AppointmentDto>()
                .ForPath(dest => dest.Animal,
                    opt => opt.MapFrom(src => src.Animal))
                .ForPath(dest => dest.Client,
                    opt => opt.MapFrom(src => src.Animal.Client))
                .ForPath(dest => dest.Client.FirstName,
                    opt => opt.MapFrom(src => src.Animal.Client.User.FirstName))
                .ForPath(dest => dest.Client.LastName,
                    opt => opt.MapFrom(src => src.Animal.Client.User.LastName))
                .ForPath(dest => dest.Doctor
                    , opt => opt.MapFrom(src => src.Doctor))
                .ForPath(dest => dest.Doctor.FirstName,
                    opt => opt.MapFrom(src => src.Doctor.User.FirstName))
                .ForPath(dest => dest.Doctor.LastName,
                    opt => opt.MapFrom(src => src.Doctor.User.LastName))
                .ForPath(dest => dest.Animal.AnimalType,
                    opt => opt.MapFrom(src => src.Animal.AnimalType.AnimalTypeName))
                .ForPath(dest => dest.PerformedProcedures,
                    opt => opt.MapFrom(src => src.AppointmentProcedures.Select(ap => ap.Procedure)));

            CreateMap<CreateAppointmentDto, Appointment>();

            CreateMap<UpdateAppointmentDto, Appointment>()
                .ForMember(dest => dest.AppointmentProcedures, opt => opt.MapFrom<CustomResolver>());
        }

        private class CustomResolver : IValueResolver<UpdateAppointmentDto, Appointment, ICollection<AppointmentProcedures>>
        {
            public ICollection<AppointmentProcedures> Resolve(UpdateAppointmentDto source, Appointment destination,
                ICollection<AppointmentProcedures> destMember, ResolutionContext context)
            {
                var appointmentProcedures = new List<AppointmentProcedures>();

                foreach (var procedureId in source.ProceduresIds)
                {
                    var appointmentProcedure = new AppointmentProcedures { ProcedureId = procedureId };
                    appointmentProcedures.Add(appointmentProcedure);
                }

                return appointmentProcedures;
            }
        }
    }
}