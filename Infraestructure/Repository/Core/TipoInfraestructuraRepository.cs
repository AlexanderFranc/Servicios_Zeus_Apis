using System.Linq.Expressions;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class TipoInfraestructuraRepository : GenericCoreRepository<TipoInfraestructura>, ITipoInfraestructuraRepository
    {
        public TipoInfraestructuraRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<TipoInfraestructura>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.TipoInfraestructuras.AsNoTracking()
                    : _context.TipoInfraestructuras;

            return await query.ToListAsync();
        }

        public override async Task<TipoInfraestructura> GetByIdAsync(int idtipoInfra, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.TipoInfraestructuras.AsNoTracking()
                                   : _context.TipoInfraestructuras;

            return await query.FirstOrDefaultAsync(x => x.IdTipoInfraestructura == idtipoInfra);
        }

        public override async Task<(int totalRegistros, IEnumerable<TipoInfraestructura> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.TipoInfraestructuras.AsNoTracking()
                                  : _context.TipoInfraestructuras;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.CodigoTipoInfraestructura.ToLower().Contains(search));
            }


            var totalRegistros = await query
                                        .CountAsync();

            var registros = await query
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            return (totalRegistros, registros);
        }
    }
}
