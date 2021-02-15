using AutoMapper;
using VetClinic.API.DTO.Post;
using VetClinic.DAL.Entities;
namespace VetClinic.API.Mapping
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<Post, ReadPostDto>()
                .ForMember(d => d.Id, t => t.MapFrom(o => o.Id))
                .ForMember(d => d.Title, t => t.MapFrom(o => o.Title))
                .ForMember(d => d.Subtitle, t => t.MapFrom(o => o.Subtitle))
                .ForMember(d => d.MainText, t => t.MapFrom(o => o.MainText))
                .ForMember(d => d.Photo, t => t.MapFrom(o => o.Photo))
                .ReverseMap();

            CreateMap<CreatePostDto, Post>()
                .ForMember(d => d.Title, t => t.MapFrom(o => o.Title))
                .ForMember(d => d.Subtitle, t => t.MapFrom(o => o.Subtitle))
                .ForMember(d => d.MainText, t => t.MapFrom(o => o.MainText))
                .ForMember(d => d.Photo, t => t.MapFrom(o => o.Photo))
                .ReverseMap();

            CreateMap<Post, UpdatePostDto>()
               .ForMember(d => d.Title, t => t.MapFrom(o => o.Title))
               .ForMember(d => d.Subtitle, t => t.MapFrom(o => o.Subtitle))
               .ForMember(d => d.MainText, t => t.MapFrom(o => o.MainText))
               .ForMember(d => d.Photo, t => t.MapFrom(o => o.Photo))
               .ReverseMap();
        }
    }
}
