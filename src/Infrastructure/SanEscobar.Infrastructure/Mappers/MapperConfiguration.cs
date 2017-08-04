using AutoMapper;
using SanEscobar.Domain.Core;
using SanEscobar.Infrastructure.DTO;

namespace SanEscobar.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
        => new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Player, PlayerDTO>().ForMember(x => x.PlayerName, 
                m => m.MapFrom(p => p.Name));
            //cfg.CreateMap
        })
            .CreateMapper();
    }
}


