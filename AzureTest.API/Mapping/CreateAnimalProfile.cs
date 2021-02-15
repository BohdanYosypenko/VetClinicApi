using AutoMapper;
using VetClinic.API.DTO.Animal;
using VetClinic.DAL.Entities;

namespace VetClinic.API.Mapping
{
    public class CreateAnimalProfile : Profile
    {
        public CreateAnimalProfile()
        {
            CreateMap<CreateAnimalDto, Animal>()
                .ForMember(d => d.Name, t => t.MapFrom(o => o.Name))
                .ForMember(d => d.Age, t => t.MapFrom(o => o.Age))
                .ForMember(d => d.Photo, t => t.MapFrom(o => o.Photo))
                .ForMember(d => d.ClientId, t => t.MapFrom(o => o.ClientId))
                .ForMember(d => d.AnimalTypeId, t => t.MapFrom(o => o.AnimalTypeId))
                .ReverseMap();
        }
    }
}
