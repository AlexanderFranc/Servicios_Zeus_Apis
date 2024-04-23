using System.Linq.Expressions;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class EstadoEmpleadoRepository : GenericCoreRepository<EstadoEmpleado>, IEstadoEmpleadoRepository
    {
        public EstadoEmpleadoRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<EstadoEmpleado>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.EstadoEmpleados.AsNoTracking()
                    : _context.EstadoEmpleados;

            return await query
                                .ToListAsync();
        }

        public override async Task<EstadoEmpleado> GetByIdAsync(int idestadoemp, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.EstadoEmpleados.AsNoTracking()
                                   : _context.EstadoEmpleados;

            return await query
                                .FirstOrDefaultAsync(x => x.IdEstadoEmp == idestadoemp);
        }

        public override async Task<(int totalRegistros, IEnumerable<EstadoEmpleado> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.EstadoEmpleados.AsNoTracking()
                                  : _context.EstadoEmpleados;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.NombreEstadoEmp.ToLower().Contains(search));
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
