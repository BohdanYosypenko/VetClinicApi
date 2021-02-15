using AutoMapper;
using Microsoft.AspNetCore.Identity;
using VetClinic.API.DTO.Role;

namespace VetClinic.API.Mapping
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<CreateRoleDto, IdentityRole>().ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ReverseMap()
                .ForAllOtherMembers(o => o.Ignore());

            CreateMap<RoleDto, IdentityRole>().ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Name, o => o.MapFrom(s => s.Name))
                .ReverseMap()
                .ForAllOtherMembers(o => o.Ignore());
        }
    }
}
