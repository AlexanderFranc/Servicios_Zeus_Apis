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
            CreateMap<Pai, PaisDto>().ReverseMap();
            CreateMap<EspaciosFisico, EspaciosFisicosDto>()
                .ForMember(dest => dest.NombreTipoEspacio, opt => opt.MapFrom(src => src.IdTipoEspacioNavigation != null ? src.IdTipoEspacioNavigation.NombreTipoEspacio : null))
                .ForMember(dest => dest.NombreEstadoEspacio, opt => opt.MapFrom(src => src.IdEstadoEspacioNavigation != null ? src.IdEstadoEspacioNavigation.NombreEstadoEspacio : null))
                .ForMember(dest => dest.NombreNivelInfraestructura, opt => opt.MapFrom(src => src.IdNivelInfraestructuraNavigation != null ? src.IdNivelInfraestructuraNavigation.NombreNivelInfraestructura : null))
                .ForMember(dest => dest.NombreInfraestructura, opt => opt.MapFrom(src => src.IdNivelInfraestructuraNavigation != null && src.IdNivelInfraestructuraNavigation.IdInfraestructuraNavigation != null ? src.IdNivelInfraestructuraNavigation.IdInfraestructuraNavigation.NombreInfraestructura : null))
                .ForMember(dest => dest.NombreCampus, opt => opt.MapFrom(src => src.IdNivelInfraestructuraNavigation != null && src.IdNivelInfraestructuraNavigation.IdInfraestructuraNavigation != null && src.IdNivelInfraestructuraNavigation.IdInfraestructuraNavigation.IdCampusNavigation != null ? src.IdNivelInfraestructuraNavigation.IdInfraestructuraNavigation.IdCampusNavigation.NombreCampus : null))
                .ReverseMap();
            CreateMap<Campus, CampusDto>().ReverseMap();
            CreateMap<Infraestructura, InfraestructuraDto>()
                .ForMember(dest => dest.NombreCampus, opt => opt.MapFrom(src => src.IdCampusNavigation != null ? src.IdCampusNavigation.NombreCampus : null))
                .ReverseMap();
            CreateMap<NivelInfraestructura, NivelInfraestructuraDto>()
                .ForMember(dest => dest.NombreInfraestructura, opt => opt.MapFrom(src => src.IdInfraestructuraNavigation != null ? src.IdInfraestructuraNavigation.NombreInfraestructura : null))
                .ReverseMap();
            CreateMap<TipoEspacio, TipoEspacioDto>().ReverseMap();
            CreateMap<EstadoEspacio, EstadoEspacioDto>()
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.NombreEstadoEspacio))
                .ForMember(dest => dest.Label, opt => opt.MapFrom(src => src.NombreEstadoEspacio))
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.DescripcionEstadoEsapcio))
                .ReverseMap();
        }
    }
}
