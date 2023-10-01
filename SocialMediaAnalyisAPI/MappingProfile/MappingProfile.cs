using AutoMapper;
using SocialMediaAnalyis.Entities.Models;
using SocialMediaAnalyis.Shared.DataTransferObjects;

namespace SocialMediaAnalyis.API.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SocialMediaUsers, SocialUsersDto>().ReverseMap();
            CreateMap<Fifa, FifaTweetsDTO>().ReverseMap();
            CreateMap<Fifa, FollowersCountDTO1>().ForMember(d => d.Followers, s => s.MapFrom(x => x.FollowersCount)).ReverseMap();

        }
    }
}
