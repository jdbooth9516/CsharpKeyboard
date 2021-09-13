using AutoMapper;
using customKeyboard.DataTransferObjects;
using customKeyboard.Models;

namespace customKeyboard.Manager
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForRegistrationDto, User>();
        }
    }
}