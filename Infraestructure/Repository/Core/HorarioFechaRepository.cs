using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Core
{


    public class HorarioFechaRepository : GenericCoreRepository<HorarioFecha>, IHorarioRepository
    {
        public HorarioFechaRepository(Configuration.Zeus.Core.ZeusCoreContext context) : base(context)
        {

        }

        public bool delete(int idplanificacion, string horaI, string horaF)
        {
           Conexion.deleteZeus("[HORARIO_FECHA]", " ID_PLANIFICACION=" + idplanificacion + " and HORA_INI='" + horaI + "' and HORA_FIN='" + horaF + "'");
            return true;
        }

        //SERVICIO CAMBIADO
        public async Task<IEnumerable<HorarioFecha>> GetAll(int idplanestudio, int idperiodo, int idmodalidad, string dniprofesor, int idtipocomponente, string paralelo, int idespaciofisico, int idmateria)
        {
             var query=_context.Planificacions.Where(
                 x=> x.IdPeriodo==idperiodo  && x.DniProfesorc==dniprofesor && x.IdTipoComponente==idtipocomponente 
                 && x.Paralelo==paralelo && x.IdEspaciosFisicos==idespaciofisico              
                 ).FirstOrDefault();
                var horario=_context.HorarioFechas.Where(x=>x.IdPlanificacion==query.IdPlanificacion).ToListAsync();
            return await horario;
            
        }

        public List<HorarioModularDto> GetHorarioFechasPlanificado(int idplanificacion)
        {
            List<HorarioModularDto> lsthorario = new List<HorarioModularDto>();
            HorarioModularDto horario = new HorarioModularDto();
            DataSet ds_horario = Conexion.BuscarZEUS_ds("HORARIO_FECHA", " * ", "where ID_PLANIFICACION=" + idplanificacion + " order by FECHA asc ");
            if (ds_horario.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_horario.Tables[0].Rows)
                {
                    horario.FechaI = Convert.ToDateTime(row["FECHA"].ToString());
                    horario.FechaF = Convert.ToDateTime(row["FECHA"].ToString());
                    horario.HoraI = row["HORA_INI"].ToString();
                    horario.HoraF = row["HORA_FIN"].ToString();
                    lsthorario.Add(horario);
                    horario = new HorarioModularDto();

                }

            }
            return lsthorario;
        }

        public List<HorarioModularDto> GetHorarioModularPlanificado(int idplanificacion)
        {
            List<HorarioModularDto> lsthorario = new List<HorarioModularDto>();
            HorarioModularDto horario = new HorarioModularDto();
            DataSet ds_horario = Conexion.BuscarZEUS_ds("HORARIO_FECHA", " ID_PLANIFICACION,ORDEN_FECHA,MIN(FECHA) AS FECHA_INI,MAX(FECHA) AS FECHA_FIN,MIN(HORA_INI) AS HORA_INI,MAX(HORA_FIN)AS HORA_FIN ", "where ID_PLANIFICACION="+idplanificacion+" group by ID_PLANIFICACION,ORDEN_FECHA ORDER BY ORDEN_FECHA ASC");
            if (ds_horario.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_horario.Tables[0].Rows)
                {
                    horario.FechaI = Convert.ToDateTime(row["FECHA_INI"].ToString());
                    horario.FechaF = Convert.ToDateTime(row["FECHA_FIN"].ToString());
                    horario.HoraI = row["HORA_INI"].ToString();
                    horario.HoraF = row["HORA_FIN"].ToString();
                    lsthorario.Add(horario);
                    horario = new HorarioModularDto();

                }

            }
            return lsthorario;

        }

        public bool insertHorarioModular(int idplanificacion, List<HorarioModularDto> horariomodular)
        {
            if (horariomodular.Count > 0)
            {
                int contador = 0;
                string eliminado = Conexion.deleteZeus("[HORARIO_FECHA]", "ID_PLANIFICACION="+idplanificacion);
                if (eliminado == "1")
                {
                    foreach(var item in horariomodular)
                    {
                        //Conexion.ExecZeusCore("GuardarHorarioModular", idplanificacion + ",'" + Convert.ToDateTime(item.FechaI).Date + "','" + Convert.ToDateTime(item.FechaF) + "','" + item.HoraI+ "','" + item.HoraF+ "',"+contador);
                        Conexion.ExecZeusCore("GuardarHorarioModular",
                        idplanificacion + ",'" +
                        Convert.ToDateTime(item.FechaI).ToString("yyyy-MM-dd HH:mm:ss") + "','" +
                        Convert.ToDateTime(item.FechaF).ToString("yyyy-MM-dd HH:mm:ss") + "','" +
                        item.HoraI + "','" +
                        item.HoraF + "'," +
                        contador+","+
                        item.IdEspacioFisico);
                        contador ++;
                    }
                }
            }
            return true;
        }
        public bool insertHorarioSemestral(int idplanificacion, List<HorarioDto> horariosemestral)
        {
            if (horariosemestral.Count > 0)
            {
                string eliminado = Conexion.deleteZeus("[HORARIO]", "ID_PLANIFICACION=" + idplanificacion);
                if (eliminado == "1")
                {
                    foreach (var item in horariosemestral)
                    {
                        Conexion.InsertarZeusCore("HORARIO", "ID_PLANIFICACION,ID_DIA,HORA_INI,HORA_FIN", idplanificacion + ","+item.IdDia+",'" + item.HoraIni + "','" + item.HoraFin + "'");
                    }
                }
            }
            return true;
        }

    }

}
