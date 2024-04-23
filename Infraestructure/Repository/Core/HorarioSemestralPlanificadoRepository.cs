using AutoMapper;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Core
{
    public class HorarioSemestralPlanificadoRepository :  GenericCoreRepository<HorarioSemestralPlanificadoDto>, IHorarioSemestralPlanificadoRepository
    {
        public HorarioSemestralPlanificadoRepository(ZeusCoreContext context) : base(context)
        {

        }
        public async Task<List<HorarioSemestralPlanificadoDto>> getHorarioSemestralPlanificado(int idplanificacion)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.SourceMemberNamingConvention = new PascalCaseNamingConvention();
                cfg.DestinationMemberNamingConvention = new PascalCaseNamingConvention();
                cfg.CreateMap<Horario, HorarioSemestralPlanificadoDto>()
                    .ForMember(dest => dest.HoraIni, opt => opt.MapFrom(src => src.HoraIni.ToString("HH:mm")))
                    .ForMember(dest => dest.HoraFin, opt => opt.MapFrom(src => src.HoraFin.ToString("HH:mm")))
                    .ForMember(dest => dest.IdDia, opt => opt.MapFrom(src => src.IdDia));
            });
            IQueryable<Horario> query = _context.Horarios.Where(x => x.IdPlanificacion == idplanificacion);
            IMapper mapper = config.CreateMapper();
            List<HorarioSemestralPlanificadoDto> horarioDto = await mapper.ProjectTo<HorarioSemestralPlanificadoDto>(query).ToListAsync();
            return horarioDto;
        }
    }
}
