using AutoMapper;
using VetClinic.API.DTO.Queries;
using VetClinic.BLL.Domain;

namespace VetClinic.API.Mapping
{
    public class RequestToDomainProfile : Profile
    {
        public RequestToDomainProfile()
        {
            CreateMap<PaginationQuery, PaginationFilter>();
            CreateMap<AppointmentsFiltrationQuery, AppointmentsFilter>();
            CreateMap<DoctorsFiltrationQuery, DoctorsFilter>();
            CreateMap<AnimalsFiltrationQuery, AnimalsFilter>();
            CreateMap<ClientsFiltrationQuery, ClientsFilter>();
        }
    }
}