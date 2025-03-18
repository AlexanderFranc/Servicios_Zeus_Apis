using System.Linq.Expressions;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Infraestructure.Repository.Core
{
    public class InfraestructuraRepository : GenericCoreRepository<Infraestructura>, IInfraestructuraRepository
    {
        public InfraestructuraRepository(ZeusCoreContext context) : base(context)
        {

        }
        public override async Task<IEnumerable<Infraestructura>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.Infraestructuras.AsNoTracking()
                    : _context.Infraestructuras;

            return await query
                                .Include(x => x.IdCampusNavigation)
                                .Include(y => y.IdTipoInfraestructuraNavigation)
                                .ToListAsync();
        }

        public override async Task<Infraestructura> GetByIdAsync(int idinfra, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.Infraestructuras.AsNoTracking()
                                   : _context.Infraestructuras;

            return await query
                                .Include(a => a.IdCampusNavigation)
                                .Include(b => b.IdTipoInfraestructuraNavigation)
                                .FirstOrDefaultAsync(x => x.IdInfraestructura == idinfra);
        }

        public async Task<List<Infraestructura>> GetByCodInfraestructuraAsync(string cod) => await
            _context.Infraestructuras.Where(x => x.CodigoInfraestructura == cod).ToListAsync();

        public async Task<List<Infraestructura>> GetByTipoInfraAsync(int idtipo) => await
            _context.Infraestructuras.Where(x => x.IdTipoInfraestructura == idtipo).ToListAsync();

        public override async Task<(int totalRegistros, IEnumerable<Infraestructura> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.Infraestructuras.AsNoTracking()
                                  : _context.Infraestructuras;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.CodigoInfraestructura.ToLower().Contains(search));
            }


            var totalRegistros = await query
                                        .CountAsync();

            var registros = await query

                                .Include(x => x.IdCampusNavigation)
                                .Include(x => x.IdTipoInfraestructuraNavigation)
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            return (totalRegistros, registros);
        }

        public async Task<List<Infraestructura>> GetAllByInfraestructuraAsync()
        {
            return await _context.Infraestructuras.
                            Include(x=>x.NivelInfraestructuras).
                            ThenInclude(x=>x.EspaciosFisicos.Where(x => x.ActivoEspaciosFisicos == true)).
                            ToListAsync();
                    //.Include(a => a.IdCampusNavigation)
                    //.Include(b => b.IdTipoInfraestructuraNavigation)
                    //.FirstOrDefaultAsync(x => x.IdInfraestructura == idinfra);
        }
    }
}
