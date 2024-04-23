using System.Linq.Expressions;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class EspaciosFisicosRepository : GenericCoreRepository<EspaciosFisico>, IEspaciosFisicosRepository
    {
        public EspaciosFisicosRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<EspaciosFisico>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.EspaciosFisicos.AsNoTracking()
                    : _context.EspaciosFisicos;

            return await query
                                .Include(x => x.IdEstadoEspacioNavigation)
                                .Include(y => y.IdNivelInfraestructuraNavigation)
                                .Include(z => z.IdTipoEspacioNavigation)
                                .ToListAsync();
        }

        public override async Task<EspaciosFisico> GetByIdAsync(int idespaciofisc, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.EspaciosFisicos.AsNoTracking()
                                   : _context.EspaciosFisicos;

            return await query
                                .Include(a => a.IdEstadoEspacioNavigation)
                                .Include(b => b.IdNivelInfraestructuraNavigation)
                                .Include(z => z.IdTipoEspacioNavigation)
                                .FirstOrDefaultAsync(x => x.IdEspaciosFisicos == idespaciofisc);
        }

        public async Task<List<EspaciosFisico>> GetByCodEspaciosFiscAsync(string cod) => await 
            _context.EspaciosFisicos.Where(x => x.CodigoEspaciosFisicos == cod).ToListAsync();

        public async Task<List<EspaciosFisico>> GetByIdNivel(int idnivel) => await
            _context.EspaciosFisicos.Where(x => x.IdNivelInfraestructura == idnivel).ToListAsync();

        public override async Task<(int totalRegistros, IEnumerable<EspaciosFisico> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.EspaciosFisicos.AsNoTracking()
                                  : _context.EspaciosFisicos;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.CodigoEspaciosFisicos.ToLower().Contains(search));
            }


            var totalRegistros = await query
                                        .CountAsync();

            var registros = await query
                                .Include(x => x.IdEstadoEspacioNavigation)
                                .Include(y => y.IdNivelInfraestructuraNavigation)
                                .Include(z => z.IdTipoEspacioNavigation)
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            return (totalRegistros, registros);
        }
    }
}
