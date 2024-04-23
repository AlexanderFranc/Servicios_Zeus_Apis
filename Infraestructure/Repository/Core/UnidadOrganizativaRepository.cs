using System.Linq.Expressions;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class UnidadOrganizativaRepository : GenericCoreRepository<UnidadOrganizativa>, IUnidadOrganizativaRepository
    {
        public UnidadOrganizativaRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<UnidadOrganizativa>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.UnidadOrganizativas.AsNoTracking()
                    : _context.UnidadOrganizativas;

            return await query
                                .ToListAsync();
        }

        public override async Task<UnidadOrganizativa> GetByIdAsync(int idunidadOrg, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.UnidadOrganizativas.AsNoTracking()
                                   : _context.UnidadOrganizativas;

            return await query
                                .FirstOrDefaultAsync(x => x.IdUo == idunidadOrg);
        }

        public override async Task<(int totalRegistros, IEnumerable<UnidadOrganizativa> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.UnidadOrganizativas.AsNoTracking()
                                  : _context.UnidadOrganizativas;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.CodigoUo.ToLower().Contains(search));
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
