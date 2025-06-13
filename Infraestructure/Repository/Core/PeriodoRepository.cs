using System.Linq.Expressions;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;


namespace Infraestructure.Repository.Core
{
    public class PeriodoRepository : GenericCoreRepository<Periodo>, IPeriodoRepository
    {
        public PeriodoRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Periodo>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.Periodos.AsNoTracking()
                    : _context.Periodos;

            return await query
                                .Include(x => x.IdEstadoPeriodoNavigation)
                                .Include(y => y.IdModalidadNavigation)
                                .Include(a => a.IdTipoPeriodoNavigation)
                                .OrderByDescending(z => z.CodigoPeriodo)
                                .ToListAsync();
        }
        //SERVICIO CAMBIADO
        public override async Task<Periodo> GetByIdAsync(int idper, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.Periodos.AsNoTracking()
                                   : _context.Periodos;

            return await query
                                .Include(x => x.IdEstadoPeriodoNavigation)
                                .Include(y => y.IdModalidadNavigation)
                               
                                .Include(a => a.IdTipoPeriodoNavigation)
                                .FirstOrDefaultAsync(x => x.IdPeriodo == idper);
        }

        public override async Task<(int totalRegistros, IEnumerable<Periodo> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.Periodos.AsNoTracking()
                                  : _context.Periodos;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.CodigoPeriodo.ToLower().Contains(search));
            }


            var totalRegistros = await query
                                        .CountAsync();

            var registros = await query

                                .Include(x => x.IdEstadoPeriodoNavigation)
                                .Include(y => y.IdModalidadNavigation)
                                .Include(a => a.IdTipoPeriodoNavigation)
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            return (totalRegistros, registros);
        }

        public async Task<IEnumerable<Periodo>> getCambioParalelo()
        {
            var query = await _context.Periodos.AsNoTracking().Where(x => x.ActivoPeriodoCambParal == true).ToListAsync();
            return query;

        }
    }
}
