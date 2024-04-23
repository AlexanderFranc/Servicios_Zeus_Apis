using System.Linq.Expressions;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;


namespace Infraestructure.Repository.Core
{
    public class FacultadRepository : GenericCoreRepository<Facultad>, IFacultadRepository
    {
        public FacultadRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Facultad>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.Facultads.AsNoTracking()
                    : _context.Facultads;

            return await query
                                .Include(x => x.IdCampusNavigation)
                                .Include(y => y.IdEstadoFacultadNavigation)
                                .ToListAsync();
        }

        public override async Task<Facultad> GetByIdAsync(int idfacultad, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.Facultads.AsNoTracking()
                                   : _context.Facultads;

            return await query
                                .Include(a => a.IdCampusNavigation)
                                .Include(b => b.IdEstadoFacultadNavigation)
                                .FirstOrDefaultAsync(x => x.IdFacultad == idfacultad);
        }

        public async Task<List<Facultad>> GetByCodeFacultadAsync(string cod) => await 
            _context.Facultads.Where(x => x.CodigoFacultad == cod).ToListAsync();

        public override async Task<(int totalRegistros, IEnumerable<Facultad> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.Facultads.AsNoTracking()
                                  : _context.Facultads;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.CodigoFacultad.ToLower().Contains(search));
            }


            var totalRegistros = await query
                                        .CountAsync();

            var registros = await query

                                .Include(x => x.IdCampusNavigation)
                                .Include(x => x.IdEstadoFacultadNavigation)
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            return (totalRegistros, registros);
        }

    }
}
