using AutoMapper;
using VetClinic.API.DTO.Animal;
using VetClinic.DAL.Entities;

namespace VetClinic.API.Mapping
{
    public class AnimalProfile : Profile
    {
        public AnimalProfile()
        {
            CreateMap<CreateAnimalDto, Animal>()
                .ForMember(d => d.Name, t => t.MapFrom(o => o.Name))
                .ForMember(d => d.Age, t => t.MapFrom(o => o.Age))
                .ForMember(d => d.AnimalTypeId, t => t.MapFrom(o => o.AnimalTypeId))
                .ForMember(d => d.ClientId, t => t.MapFrom(o => o.ClientId))
                .ForMember(d => d.Photo, t => t.MapFrom(o => o.Photo))
                .ForAllOtherMembers(d => d.Ignore());

            CreateMap<Animal, ReadAnimalDto>()
                .ForPath(d=> d.AnimalTypeName,t=>t.MapFrom(o=>o.AnimalType.AnimalTypeName))
                .ForPath(dest => dest.Client.Id,
                    opt => opt.MapFrom(src => src.Client.Id))
                .ForPath(dest => dest.Client.FirstName,
                    opt => opt.MapFrom(src => src.Client.User.FirstName))
                .ForPath(dest => dest.Client.LastName,
                    opt => opt.MapFrom(src => src.Client.User.LastName))
                .ForMember(d => d.Id, t => t.MapFrom(o => o.Id))
                .ForMember(d => d.Name, t => t.MapFrom(o => o.Name))
                .ForMember(d => d.Age, t => t.MapFrom(o => o.Age))
                .ForMember(d => d.Photo, t => t.MapFrom(o => o.Photo))
                .ForMember(d => d.AnimalTypeId, t => t.MapFrom(o => o.AnimalTypeId))
                .ForMember(d => d.IsDeleted, t => t.MapFrom(o => o.IsDeleted))
                .ForAllOtherMembers(d => d.Ignore());

            CreateMap<Animal, UpdateAnimalDto>()
                .ForMember(d => d.Name, t => t.MapFrom(o => o.Name))
                .ForMember(d => d.Age, t => t.MapFrom(o => o.Age))
                .ForMember(d => d.Photo, t => t.MapFrom(o => o.Photo))
                .ForMember(d => d.AnimalTypeId, t => t.MapFrom(o => o.AnimalTypeId))
                .ForMember(d => d.IsDeleted, t => t.MapFrom(o => o.IsDeleted))
                .ReverseMap();
        }
    }
}
