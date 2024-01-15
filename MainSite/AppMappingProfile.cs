using AutoMapper;
using MainSite.News;
using MainSite.User;

namespace MainSite
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            CreateMap<UserEntity, UserDTO>();
            CreateMap<News_Entity, NewsDTO>();
        }
    }
}
