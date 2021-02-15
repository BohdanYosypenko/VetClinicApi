using AutoMapper;
using VetClinic.API.DTO;
using VetClinic.API.DTO.Service;
using VetClinic.DAL.Entities;

namespace VetClinic.API.Mapping
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            CreateMap<Service, ServiceDto>().ReverseMap();
            CreateMap<Service, ServiceCreateDto>().ReverseMap();
            CreateMap<Service, ServiceUpdateDto>().ReverseMap();
        }
    }
}
