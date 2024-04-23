using System.Linq.Expressions;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class TipoDocumentoRepository : GenericCoreRepository<TipoDocumento>, ITipoDocumentoRepository
    {
        public TipoDocumentoRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<TipoDocumento>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.TipoDocumentos.AsNoTracking()
                    : _context.TipoDocumentos;

            return await query
                                .ToListAsync();
        }

        public override async Task<TipoDocumento> GetByIdAsync(int idtipodoc, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.TipoDocumentos.AsNoTracking()
                                   : _context.TipoDocumentos;

            return await query
                                .FirstOrDefaultAsync(x => x.IdTipoDocumento == idtipodoc);
        }

        public override async Task<(int totalRegistros, IEnumerable<TipoDocumento> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.TipoDocumentos.AsNoTracking()
                                  : _context.TipoDocumentos;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.TipoDocumento1.ToLower().Contains(search));
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
