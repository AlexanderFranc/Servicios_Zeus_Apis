using System;
using System.Linq.Expressions;
using AutoMapper;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class HorariosSemestralRepository : GenericCoreRepository<HorarioDto>, IHorariosSemestralRepository
    {
        public HorariosSemestralRepository(ZeusCoreContext context) : base(context)
        {
        }
        public  async Task<IEnumerable<HorarioDto>> GetByPlanificacionAsync(int id)
        {

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Horario, HorarioDto>()
                    .ForMember(dest => dest.HoraIni, opt => opt.MapFrom(src => src.HoraIni))
                    .ForMember(dest => dest.HoraFin, opt => opt.MapFrom(src => src.HoraFin))
                    .ForMember(dest => dest.IdDia, opt => opt.MapFrom(src => src.IdDia));
            });

            IQueryable<Horario> query = _context.Horarios.Where(x => x.IdPlanificacion == id);
            IMapper mapper = config.CreateMapper();

            List<HorarioDto> horarioDto =await mapper.ProjectTo<HorarioDto>(query).ToListAsync();

            return horarioDto;

        }


    }
}
