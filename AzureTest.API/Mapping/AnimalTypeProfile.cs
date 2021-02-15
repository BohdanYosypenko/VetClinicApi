using AutoMapper;
using VetClinic.API.DTO.AnimalType;
using VetClinic.DAL.Entities;

namespace VetClinic.API.Mapping
{
    public class AnimalTypeProfile:Profile
    {
        public AnimalTypeProfile()
        {
            CreateMap<AnimalTypeDto, AnimalType>()
                .ForMember(d => d.AnimalTypeName, t => t.MapFrom(o => o.AnimalTypeName))
                .ReverseMap()
                .ForAllOtherMembers(d => d.Ignore());

            CreateMap<ReadAnimalTypeDto,AnimalType>()
                .ForMember(d => d.Id, t => t.MapFrom(o => o.Id))
                .ForMember(d => d.AnimalTypeName, t => t.MapFrom(o => o.AnimalTypeName))
                .ReverseMap()
                .ForAllOtherMembers(d => d.Ignore());

        }
    }
}
