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
    public class PlanificacionTempRepository : GenericCoreRepository<PlanificacionTemp>, IPlanificacionTempRepository
    {

        public PlanificacionTempRepository(ZeusCoreContext context) : base(context)
        {
        }


        public override async Task<IEnumerable<PlanificacionTemp>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.PlanificacionTemps.AsNoTracking()
                    : _context.PlanificacionTemps;

            return await query
                                .ToListAsync();
        }

        public override async Task<PlanificacionTemp> GetByIdAsync(int idPlanificacion, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.PlanificacionTemps.AsNoTracking()
                                   : _context.PlanificacionTemps;

            return await query
                                .FirstOrDefaultAsync(x => x.IdPlanificacion == idPlanificacion);
        }
        public override async Task<(int totalRegistros, IEnumerable<PlanificacionTemp> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.PlanificacionTemps.AsNoTracking()
                                  : _context.PlanificacionTemps;

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
        public bool EditPlanificacion(PlanificacionTempDto planificacionTemp) {
            bool response = false;
            string fechaInicio = planificacionTemp.FechaInicioPlanificacion.HasValue
                ? $"'{planificacionTemp.FechaInicioPlanificacion.Value:yyyy-MM-dd}'"
                : "NULL";

            string fechaFin = planificacionTemp.FechaFinPlanificacion.HasValue
                ? $"'{planificacionTemp.FechaFinPlanificacion.Value:yyyy-MM-dd}'"
                : "NULL";
            string campos = "DNI_PROFESORC= '" + planificacionTemp.DniProfesorc + "'" +
                            ", ID_ESPACIOS_FISICOS=" + planificacionTemp.IdEspaciosFisicos +
                            ", FECHA_INICIO_PLANIFICACION=" + fechaInicio +
                            ", FECHA_FIN_PLANIFICACION=" + fechaFin;
            response = Conexion.ActualizarZeus("PLANIFICACION_TEMP", campos, " WHERE ID_SOLICITUD = " + planificacionTemp.IdSolicitud);
            /*
             update PLANIFICACION_TEMP set DNI_PROFESORC='CEDPROFES',ID_ESPACIOS_FISICOS=123132132 where ID_SOLICITUD=15456
             */
            return response;
        }

    }
}
