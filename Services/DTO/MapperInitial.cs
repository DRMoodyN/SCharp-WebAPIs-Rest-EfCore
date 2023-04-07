using System;

namespace Services
{
    public class MapperInitial : Profile
    {
        public MapperInitial()
        {
            CreateMap<User, UserRegister>().ReverseMap();
        }
    }
}
