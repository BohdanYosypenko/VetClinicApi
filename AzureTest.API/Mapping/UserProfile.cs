using AutoMapper;
using VetClinic.API.DTO.User;
using VetClinic.DAL.Entities;

namespace VetClinic.API.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, CreateUserDto>().ForMember(d => d.UserName, o => o.MapFrom(s => s.UserName))
                .ForMember(d => d.FirstName, o => o.MapFrom(s => s.FirstName))
                .ForMember(d => d.LastName, o => o.MapFrom(s => s.LastName))
                .ForMember(d => d.Email, o => o.MapFrom(s => s.Email))
                .ForMember(d => d.PhoneNumber, o => o.MapFrom(s => s.PhoneNumber))
                .ForMember(d => d.Password, o => o.MapFrom(s => s.PasswordHash))
                .ForAllOtherMembers(o => o.Ignore());

            CreateMap<User, CreateUserDto>().ReverseMap().ForMember(d => d.UserName, o => o.MapFrom(s => s.UserName))
                .ForMember(d => d.FirstName, o => o.MapFrom(s => s.FirstName))
                .ForMember(d => d.LastName, o => o.MapFrom(s => s.LastName))
                .ForMember(d => d.Email, o => o.MapFrom(s => s.Email))
                .ForMember(d => d.PhoneNumber, o => o.MapFrom(s => s.PhoneNumber))
                .ForMember(d => d.PasswordHash, o => o.MapFrom(s => s.Password))
                .ForAllOtherMembers(o => o.Ignore());


            CreateMap<User, UserDto>().ForMember(d => d.UserName, o => o.MapFrom(s => s.UserName))
                .ForMember(d => d.FirstName, o => o.MapFrom(s => s.FirstName))
                .ForMember(d => d.LastName, o => o.MapFrom(s => s.LastName))
                .ForMember(d => d.Email, o => o.MapFrom(s => s.Email))
                .ForMember(d => d.PhoneNumber, o => o.MapFrom(s => s.PhoneNumber))
                .ForMember(d => d.IsDeleted, o => o.MapFrom(s => s.IsDeleted))
                .ForAllOtherMembers(o => o.Ignore());

            CreateMap<User, UserDto>().ReverseMap().ForMember(d => d.UserName, o => o.MapFrom(s => s.UserName))
                .ForMember(d => d.FirstName, o => o.MapFrom(s => s.FirstName))
                .ForMember(d => d.LastName, o => o.MapFrom(s => s.LastName))
                .ForMember(d => d.Email, o => o.MapFrom(s => s.Email))
                .ForMember(d => d.PhoneNumber, o => o.MapFrom(s => s.PhoneNumber))
                .ForMember(d => d.IsDeleted, o => o.MapFrom(s => s.IsDeleted))
                .ForAllOtherMembers(o => o.Ignore());

            CreateMap<UpdateUserDto, User>().ForMember(d => d.UserName, o => o.MapFrom(s => s.UserName))
               .ForMember(d => d.FirstName, o => o.MapFrom(s => s.FirstName))
               .ForMember(d => d.LastName, o => o.MapFrom(s => s.LastName))
               .ForMember(d => d.Email, o => o.MapFrom(s => s.Email))
               .ForMember(d => d.PhoneNumber, o => o.MapFrom(s => s.PhoneNumber))
               .ForMember(d => d.IsDeleted, o => o.MapFrom(s => s.IsDeleted))
               .ForAllOtherMembers(o => o.Ignore());

        }
    }
}
