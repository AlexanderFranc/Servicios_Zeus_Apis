using System.Linq.Expressions;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class NivelAcademicoRepository : GenericCoreRepository<NivelAcademico>, INivelAcademicoRepository
    {
        public NivelAcademicoRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<NivelAcademico>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.NivelAcademicos.AsNoTracking()
                    : _context.NivelAcademicos;

            return await query
                                .ToListAsync();
        }

        public override async Task<NivelAcademico> GetByIdAsync(int idnivelAcad, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.NivelAcademicos.AsNoTracking()
                                   : _context.NivelAcademicos;

            return await query
                                .FirstOrDefaultAsync(x => x.IdNivelAcademico == idnivelAcad);
        }

        public override async Task<(int totalRegistros, IEnumerable<NivelAcademico> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.NivelAcademicos.AsNoTracking()
                                  : _context.NivelAcademicos;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.NivelAcademico1.ToLower().Contains(search));
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
