using AutoMapper;

namespace APISecurity.Models
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<UserDTO, User>();
        }

        
    }
}