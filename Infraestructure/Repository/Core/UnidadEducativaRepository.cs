using System.Linq.Expressions;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class UnidadEducativaRepository : GenericCoreRepository<UnidadEducativa>, IUnidadEducativaRepository
    {
        public UnidadEducativaRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<UnidadEducativa>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.UnidadEducativas.AsNoTracking()
                    : _context.UnidadEducativas;

            return await query
                                .ToListAsync();
        }
        public override async Task<UnidadEducativa> GetByIdAsync(int idunidaded, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.UnidadEducativas.AsNoTracking()
                                   : _context.UnidadEducativas;

            return await query
                                .FirstOrDefaultAsync(x => x.IdUnidadEducativa == idunidaded);
        }

        public override async Task<(int totalRegistros, IEnumerable<UnidadEducativa> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.UnidadEducativas.AsNoTracking()
                                  : _context.UnidadEducativas;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.CodigoUnidadEducativa.ToLower().Contains(search));
            }


            var totalRegistros = await query
                                        .CountAsync();

            var registros = await query

                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            return (totalRegistros, registros);
        }

        public async Task<List<UnidadEducativa>> GetByTipoUnidadEdu(int tipo) => await
            _context.UnidadEducativas.Where(x => x.TipoUnidadEducativa == tipo).ToListAsync();
    }
}
