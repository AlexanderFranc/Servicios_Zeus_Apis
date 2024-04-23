using AutoMapper;
using Core.Dtos.Core;
using Core.Entidades.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Mappers
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            var config = new MapperConfiguration(cfg =>
            {
                CreateMap<Pai, PaisDto>().
                ReverseMap();
                CreateMap<PaisDto, Pai>();
            });
            var mapper = new Mapper(config);


        }
    }
}
