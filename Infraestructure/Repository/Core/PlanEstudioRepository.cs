using System.Collections;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using AutoMapper;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Mappers;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class PlanEstudioRepository : GenericCoreRepository<PlanEstudioDto>, IPlanEstudioRepository
    {
        public PlanEstudioRepository(Configuration.Zeus.Core.ZeusCoreContext context) : base(context)
        {

        }
        public override async Task<IEnumerable<PlanEstudioDto>> GetAllAsync(bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.PlanEstudios.AsNoTracking()
                       : _context.PlanEstudios;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PlanEstudio, PlanEstudioDto>();
                cfg.CreateMap<Malla, MallaDto>();
            });
            var mapper = new Mapper(config);
            var _planestudio =await query.Include(x => x.Mallas).ToListAsync();

            var model = mapper.Map<List<PlanEstudioDto>>(_planestudio);

            return model;
        }

        public async Task<IEnumerable<PlanEstudioDto>> GetAllByIdModalidad(string codmodalidad)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PlanEstudio, PlanEstudioDto>();
                cfg.CreateMap<ModalidadPe, ModalidadPEDto>();
            });
            var mapper = new Mapper(config);
            var _planestudio =await _context.PlanEstudios.Where(x => x.CodigoPlanEstudioMalla == codmodalidad).Include(x => x.IdModalidadPeNavigation).ToListAsync();

            var model = mapper.Map<List<PlanEstudioDto>>(_planestudio);

            return model;
        }


        public async Task<List<PlanEstudio>> GetAllByIdCarrera(int id) => await
            _context.PlanEstudios.Where(x => x.IdCarrera == id).ToListAsync();


        public async Task<IdPlanMateriaDto> GetByCodeAsync(string codplan, string codmateria)
        {
            var planestudio = _context.PlanEstudios.Where(x => x.CodigoPlanEstudioMalla == codplan).FirstOrDefault();
            var materia = _context.Materia.Where(x => x.CodigoMateria == codmateria).FirstOrDefault();

            IdPlanMateriaDto idplanmateriadto = new IdPlanMateriaDto()
            {
                idplanestudio = planestudio.IdPlanEstudio,
                idmateria = materia.IdMateria,
                codplanestudio = planestudio.CodigoPlanEstudioMalla,
                codmateria = materia.CodigoMateria


            };
            return idplanmateriadto;

        }

        public async Task<PlanEstudio> GetByMallaCarreraModalidad(int idCarrera, string codMalla, int idModalidad)
        {
            var planestudio = await _context.PlanEstudios.Where(x => x.CodigoPlanEstudioMalla == codMalla && x.IdModalidadPe==idModalidad && x.IdCarrera==idCarrera).FirstOrDefaultAsync();
            return  planestudio;
            
        }
    }
}
