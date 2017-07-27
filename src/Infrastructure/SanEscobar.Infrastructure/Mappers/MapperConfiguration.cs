using AutoMapper;

namespace SanEscobar.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
        => new MapperConfiguration(cfg =>
        {
            //cfg.CreateMap<OneClass, TwoClass>();
        })
            .CreateMapper();
    }
}


