using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
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
        public bool insertHorarioSemestral(List<HorarioTempDto> lisHorariosemestral)
        {
            int activo;
            foreach (var horariosemestral in lisHorariosemestral)
            {
                activo = horariosemestral.Activo == true ? 1 : 0;
                Conexion.InsertarZeusCore("HORARIO_TEMP", "ID_PLAN_TEMP,ID_DIA,HORA_INI,HORA_FIN,ACTIVO",
                    horariosemestral.IdPlanTemp + "," + horariosemestral.IdDia + ",'" + horariosemestral.HoraIni + "','" + horariosemestral.HoraFin + "'," + activo);
            }
                return true;
        }
        public bool editHorarioSemestral(int idplanificacion, List<HorarioTempDto> lisHorariosemestral)
        {
            int activo;

            if (lisHorariosemestral.Count > 0)
            {
                string eliminado = Conexion.deleteZeus("[HORARIO_TEMP]", "ID_PLAN_TEMP=" + idplanificacion);
                if (eliminado == "1")
                {
                    foreach (var horariosemestral in lisHorariosemestral)
                    {
                        activo = horariosemestral.Activo == true ? 1 : 0;
                        Conexion.InsertarZeusCore("HORARIO_TEMP", "ID_PLAN_TEMP,ID_DIA,HORA_INI,HORA_FIN,ACTIVO",
                            horariosemestral.IdPlanTemp + "," + horariosemestral.IdDia + ",'" + horariosemestral.HoraIni + "','" + horariosemestral.HoraFin + "'," + activo);
                    }
                }
            }
            return true;
        }
    }
}
