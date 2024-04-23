using System.Linq.Expressions;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class ParroquiaRepository : GenericCoreRepository<Parroquium>, IParroquiaRepository
    {
        public ParroquiaRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Parroquium>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.Parroquia.AsNoTracking()
                    : _context.Parroquia;

            return await query
                                .Include(x => x.IdCantonNavigation)
                                .ToListAsync();
        }

        public override async Task<Parroquium> GetByIdAsync(int idparroquia, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.Parroquia.AsNoTracking()
                                   : _context.Parroquia;

            return await query
                                .Include(a => a.IdCantonNavigation)
                                .FirstOrDefaultAsync(x => x.IdParroquia == idparroquia);
        }

        public async Task<List<Parroquium>> GetByCodParroquia(string cod) => await 
            _context.Parroquia.Where(x => x.CodigoParroquia == cod).ToListAsync();

        public async Task<List<Parroquium>> GetByIdCantonAsync(int id) => await
            _context.Parroquia.Where(x => x.IdCanton == id).ToListAsync();

        public override async Task<(int totalRegistros, IEnumerable<Parroquium> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.Parroquia.AsNoTracking()
                                  : _context.Parroquia;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.CodigoParroquia.ToLower().Contains(search));
            }


            var totalRegistros = await query
                                        .CountAsync();

            var registros = await query

                                .Include(x => x.IdCantonNavigation)
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            return (totalRegistros, registros);
        }
    }
}
