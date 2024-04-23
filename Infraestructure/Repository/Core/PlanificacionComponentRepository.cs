using Core.Entidades.Core;
using Core.Interfaces.Core;
using Core.Interfaces.Generico;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Core
{
    public class PlanificacionComponentRepository : GenericCoreRepository<Planificacion>, IPlanificacionComponentRepository
    {
        public PlanificacionComponentRepository(ZeusCoreContext context) : base(context)
        {

        }
        //SERVICIO CAMBIADO
        public override async Task<Planificacion> GetByIdAsync(int id, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.Planificacions.AsNoTracking()
                                   : _context.Planificacions;

            return await query.Include(x=>x.IdModalidadPlanificacionNavigation)
                .Include(x=>x.IdPeriodicidadPlanificacionNavigation)
                .Include(x => x.IdEspaciosFisicosNavigation)
                .ThenInclude(x => x.IdNivelInfraestructuraNavigation)
                .Include(x => x.DniProfesorcNavigation)
                .FirstOrDefaultAsync(x => x.IdPlanificacion == id);

        }
    }
}
