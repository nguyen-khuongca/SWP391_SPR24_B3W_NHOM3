using AutoMapper;
using SWP391_BL3W.Database;
using SWP391_BL3W.DTO;

namespace SWP391_BL3W.Mapping
{
    public class MappingEntities : Profile
    {
        public MappingEntities()
        {
            CreateMap<CreateUserDTO, User>().ReverseMap();
            CreateMap<UserResponseDto, User>().ReverseMap();
        }
    }
}
