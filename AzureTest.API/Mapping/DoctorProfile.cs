using AutoMapper;
using VetClinic.API.DTO.Doctor;
using VetClinic.DAL.Entities;

namespace VetClinic.API.Mapping
{
    public class DoctorProfile : Profile
    {
        public DoctorProfile()
        {
            CreateMap<ReadDoctorDto, Doctor>().ReverseMap()
                .ForMember(c => c.PositionName,
                d => d.MapFrom(p => p.Position.PositionName))
                .ForMember(d => d.UserId,
                opt => opt.MapFrom(src => src.UserId))
                .ForMember(d => d.UserName,
                opt => opt.MapFrom(src => src.User.UserName))
                .ForMember(d => d.FirstName,
                opt => opt.MapFrom(src => src.User.FirstName))
                .ForMember(d => d.LastName,
                opt => opt.MapFrom(src => src.User.LastName))
                .ForMember(d => d.Email,
                opt => opt.MapFrom(src => src.User.Email))
                .ForMember(d => d.PhoneNumber,
                opt => opt.MapFrom(src => src.User.PhoneNumber))
                .ForMember(d => d.IsDeleted,
                opt => opt.MapFrom(src => src.User.IsDeleted));

            CreateMap<ReadDoctorDto, Position>()
                .ForMember(x => x.PositionName, opt => opt.MapFrom(model => model.PositionName));

            CreateMap<CreateDoctorDto, Doctor>();

            CreateMap<CreateDoctorDto, User>()
                .ForMember(d => d.UserName,
                opt => opt.MapFrom(src => src.UserName))
                .ForMember(d => d.FirstName,
                opt => opt.MapFrom(src => src.FirstName))
                .ForMember(d => d.LastName,
                opt => opt.MapFrom(src => src.LastName))
                .ForMember(d => d.Email,
                opt => opt.MapFrom(src => src.Email))
                .ForMember(d => d.PhoneNumber,
                opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(d => d.PasswordHash,
                opt => opt.MapFrom(src => src.Password));

            CreateMap<UpdateDoctorDto, Doctor>();

            CreateMap<UpdateDoctorDto, User>()
                .ForMember(d => d.UserName,
                opt => opt.MapFrom(src => src.UserName))
                .ForMember(d => d.FirstName,
                opt => opt.MapFrom(src => src.FirstName))
                .ForMember(d => d.LastName,
                opt => opt.MapFrom(src => src.LastName))
                .ForMember(d => d.Email,
                opt => opt.MapFrom(src => src.Email))
                .ForMember(d => d.PhoneNumber,
                opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(d => d.IsDeleted,
                opt => opt.MapFrom(src => src.IsDeleted));
        }
    }
}
