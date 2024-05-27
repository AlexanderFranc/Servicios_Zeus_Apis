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
    public class HorarioTempRepository : GenericCoreRepository<HorarioTemp>, IHorarioTempRepository
    {
        public HorarioTempRepository(ZeusCoreContext context) : base(context)
        {
        }


        public override async Task<IEnumerable<HorarioTemp>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.HorarioTemps.AsNoTracking()
                    : _context.HorarioTemps;

            return await query
                                .ToListAsync();
        }

        public override async Task<HorarioTemp> GetByIdAsync(int idPlan, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.HorarioTemps.AsNoTracking()
                                   : _context.HorarioTemps;

            return await query
                                .FirstOrDefaultAsync(x => x.IdPlanTemp == idPlan);
        }
        public override async Task<(int totalRegistros, IEnumerable<HorarioTemp> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.HorarioTemps.AsNoTracking()
                                  : _context.HorarioTemps;

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
