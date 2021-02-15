using AutoMapper;
using VetClinic.API.DTO.Position.PositionDTO;
using VetClinic.DAL.Entities;

namespace VetClinic.API.Mapping
{
    public class PositionProfile : Profile
    {
        public PositionProfile()
        {
            CreateMap<Position, PositionDto>();
            CreateMap<Position, PositionDto>().ReverseMap();
            CreateMap<Position, CreateUpdatePositionDto>();
            CreateMap<Position, CreateUpdatePositionDto>().ReverseMap();
        }
    }
}
