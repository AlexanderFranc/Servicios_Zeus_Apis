using System.Linq.Expressions;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class NivelInfraestructuraRepository : GenericCoreRepository<NivelInfraestructura>, INivelInfraestructuraRepository
    {
        public NivelInfraestructuraRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<NivelInfraestructura>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.NivelInfraestructuras.AsNoTracking()
                    : _context.NivelInfraestructuras;

            return await query
                                .Include(x => x.IdInfraestructuraNavigation)
                                .Include(x=>x.EspaciosFisicos)
                                .ToListAsync();
        }

        public override async Task<NivelInfraestructura> GetByIdAsync(int idnivelinfra, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.NivelInfraestructuras.AsNoTracking()
                                   : _context.NivelInfraestructuras;

            return await query
                                .Include(a => a.IdInfraestructuraNavigation)
                                .FirstOrDefaultAsync(x => x.IdNivelInfraestructura == idnivelinfra);
        }

        public async Task<List<NivelInfraestructura>> GetByIdInfraestructura(int idinfra) => await 
            _context.NivelInfraestructuras.Where(x => x.IdInfraestructura == idinfra).ToListAsync();

        public override async Task<(int totalRegistros, IEnumerable<NivelInfraestructura> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.NivelInfraestructuras.AsNoTracking()
                                  : _context.NivelInfraestructuras;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.NombreNivelInfraestructura.ToLower().Contains(search));
            }


            var totalRegistros = await query
                                        .CountAsync();

            var registros = await query
                                .Include(x => x.IdInfraestructuraNavigation)
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            return (totalRegistros, registros);
        }
    }
}
