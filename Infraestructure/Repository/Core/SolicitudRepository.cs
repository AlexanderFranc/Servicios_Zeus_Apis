using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Core
{
    public class SolicitudRepository : GenericCoreRepository<Solicitud>, ISolicitudRepository
    {
        public SolicitudRepository(ZeusCoreContext context) : base(context)
        {
        }


        public override async Task<IEnumerable<Solicitud>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.Solicituds.AsNoTracking()
                    : _context.Solicituds;

            return await query
                                .ToListAsync();
        }

        public override async Task<Solicitud> GetByIdAsync(int idSolicitud, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.Solicituds.AsNoTracking()
                                   : _context.Solicituds;

            return await query
                                .FirstOrDefaultAsync(x => x.IdSolicitud == idSolicitud);
        }
        public override async Task<(int totalRegistros, IEnumerable<Solicitud> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.Solicituds.AsNoTracking()
                                  : _context.Solicituds;

            if (!String.IsNullOrEmpty(search))
            {
                //query = query.Where(p => p.IdPlanificacion.Contains(search));
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
