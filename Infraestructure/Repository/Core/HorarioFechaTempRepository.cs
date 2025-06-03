using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Core
{
    public class HorarioFechaTempRepository : GenericCoreRepository<HorarioFechaTemp>, IHorarioFechaTempRepository
    {
        public HorarioFechaTempRepository(ZeusCoreContext context) : base(context)
        {
        }


        public override async Task<IEnumerable<HorarioFechaTemp>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.HorarioFechaTemps.AsNoTracking()
                    : _context.HorarioFechaTemps;

            return await query
                                .ToListAsync();
        }

        public override async Task<HorarioFechaTemp> GetByIdAsync(int idPlan, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.HorarioFechaTemps.AsNoTracking()
                                   : _context.HorarioFechaTemps;

            return await query
                                .FirstOrDefaultAsync(x => x.IdPlanTemp == idPlan);
        }
        public override async Task<(int totalRegistros, IEnumerable<HorarioFechaTemp> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.HorarioFechaTemps.AsNoTracking()
                                  : _context.HorarioFechaTemps;

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
        public bool insertHorarioModularTemp(int idplanificacion, List<HorarioModularDto> horariomodular)
        {
            if (horariomodular.Count > 0)
            {
                int contador = 0;
                string eliminado = Conexion.deleteZeus("[HORARIO_FECHA_TEMP]", "ID_PLAN_TEMP=" + idplanificacion);
                if (eliminado == "1")
                {
                    foreach (var item in horariomodular)
                    {
                        Conexion.ExecZeusCore("GuardarHorarioModularTemp",
                        idplanificacion + ",'" +
                        //Convert.ToDateTime(item.FechaI).ToString("yyyy-MM-dd HH:mm:ss") + "','" +
                        //Convert.ToDateTime(item.FechaF).ToString("yyyy-MM-dd HH:mm:ss") + "','" +
                        Convert.ToDateTime(item.FechaPlanificada).ToString("yyyy-MM-dd HH:mm:ss") + "','" +
                        Convert.ToDateTime(item.FechaPlanificada).ToString("yyyy-MM-dd HH:mm:ss") + "','" +
                        item.HoraI + "','" +
                        item.HoraF + "'," +
                        contador + "," +
                        item.IdEspacioFisico);
                        contador++;
                    }
                }
            }
            return true;
        }
        public List<HorarioModularDto> GetHorarioFechasPlanificadoTemp(int idplanificacion)
        {
            List<HorarioModularDto> lsthorario = new List<HorarioModularDto>();
            HorarioModularDto horario = new HorarioModularDto();
            DataSet ds_horario = Conexion.BuscarZEUS_ds("HORARIO_FECHA_TEMP", " * ", "where ID_PLAN_TEMP=" + idplanificacion + " order by FECHA asc ");
            if (ds_horario.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_horario.Tables[0].Rows)
                {
                    horario.FechaI = Convert.ToDateTime(row["FECHA"].ToString());
                    horario.FechaF = Convert.ToDateTime(row["FECHA"].ToString());
                    horario.HoraI = row["HORA_INI"].ToString();
                    horario.HoraF = row["HORA_FIN"].ToString();
                    horario.IdEspacioFisico= Convert.ToInt32(row["ID_ESPACIOS_FISICOS"]);
                    horario.FechaPlanificada = Convert.ToDateTime(row["FECHA"].ToString());
                    lsthorario.Add(horario);
                    horario = new HorarioModularDto();

                }

            }
            return lsthorario;
        }
        public bool delete(HorarioFechaTempDto item)
        {
            Conexion.deleteZeus("[HORARIO_FECHA_TEMP]", " ID_PLAN_TEMP=" + item.IdPlanTemp + " and HORA_INI='" + item.HoraIni + "' and HORA_FIN='" + item.HoraFin + "' and ID_ESPACIOS_FISICOS=" + item.IdEspacioFisico);
            return true;
        }
    }
}
