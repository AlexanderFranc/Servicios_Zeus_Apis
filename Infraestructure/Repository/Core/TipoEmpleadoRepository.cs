using System.Linq.Expressions;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class TipoEmpleadoRepository : GenericCoreRepository<TipoEmpleado>, ITipoEmpleadoRepository
    {
        public TipoEmpleadoRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<TipoEmpleado>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.TipoEmpleados.AsNoTracking()
                    : _context.TipoEmpleados;

            return await query
                                .ToListAsync();
        }

        public override async Task<TipoEmpleado> GetByIdAsync(int idprovincia, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.TipoEmpleados.AsNoTracking()
                                   : _context.TipoEmpleados;

            return await query
                                .FirstOrDefaultAsync(x => x.IdTipoEmp == idprovincia);
        }

        public override async Task<(int totalRegistros, IEnumerable<TipoEmpleado> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.TipoEmpleados.AsNoTracking()
                                  : _context.TipoEmpleados;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.NombreTipoEmp.ToLower().Contains(search));
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
