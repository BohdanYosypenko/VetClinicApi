using AutoMapper;
using VetClinic.DAL.Entities;
using VetClinic.API.DTO.ClientDto;

namespace VetClinic.API.Mapping
{
    public class ClientProfile : Profile
    {
        public ClientProfile()
        {
            CreateMap<Client, ReadClientDto>().
                ForMember(d => d.Id,
                opt => opt.MapFrom(src => src.Id)).
                ForMember(d => d.UserId,
                opt => opt.MapFrom(src => src.UserId)).
                ForMember(d => d.UserName,
                opt => opt.MapFrom(src => src.User.UserName)).
                ForMember(d => d.FirstName,
                opt => opt.MapFrom(src => src.User.FirstName)).
                ForMember(d => d.LastName,
                opt => opt.MapFrom(src => src.User.LastName)).
                ForMember(d => d.Email,
                opt => opt.MapFrom(src => src.User.Email)).
                ForMember(d => d.PhoneNumber,
                opt => opt.MapFrom(src => src.User.PhoneNumber))
                .ForMember(d => d.IsDeleted,
                opt => opt.MapFrom(src => src.User.IsDeleted));
        }
    }
}
