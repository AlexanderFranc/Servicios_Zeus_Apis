using System.Data;
using System.Linq.Expressions;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class HorariosPlanificacionRepository : GenericCoreRepository<HorariosPlanificacionDto>, IHorariosPlanificacionRepository
    {
        public HorariosPlanificacionRepository(ZeusCoreContext context) : base(context)
        {
        }

        public string GetDescripcionCruce(string id)
        {
            string resultado = "";
            string[] ids = id.Split(",");
            for(int i = 0; i < ids.Length; i++)
            {
                DataSet ds_data = Conexion.BuscarZEUS_ds("planificacion a \r\ninner join empleado e\r\non a.dni_profesorc = e.identificacion_emp and id_tipo_Emp=1\r\ninner join materia m\r\non a.id_materia = m.id_materia\r\ninner join espacios_fisicos ef\r\non ef.id_espacios_fisicos = a.id_espacios_fisicos", "a.id_planificacion,e.APELLIDO_EMP +' '+ e.NOMBRES_EMP + ' / '+m.codigo_materia +' - '+  m.NOMBRE_MATERIA +' / '+ef.CODIGO_ESPACIOS_FISICOS +' - '+ef.DESCRIPCION_ESPACIOS_FISICOS as Detalle", "where a.id_planificacion=" + ids[i]);
                resultado += ds_data.Tables[0].Rows[i]["Detalle"].ToString();
            }
            return resultado;
        }

        public List<HorariosPlanificacionDto> GetHorariosPlanificacionSemanal(string opcion, int idperiodo, int id_periodicidadplanificacion, int idmateria, int idtipocomponente, int idespaciosfisicos, string codprofe, string? fechaPlanificarIni, string? fechaPlanificarFin)
        {

            if (opcion == "S")
            {
                fechaPlanificarIni = fechaPlanificarIni.Replace("-", " ");
                fechaPlanificarFin = fechaPlanificarFin.Replace("-", " ");
            }
            else if (opcion == "F")
            {
                fechaPlanificarFin = fechaPlanificarFin.Replace("-", " ");
            }

            List<HorariosPlanificacionDto> listahoras = new List<HorariosPlanificacionDto>();
            DataSet ds_horas = Conexion.ExecZeusCore("HorariosPLanificacion",opcion+","+idperiodo+","+id_periodicidadplanificacion+","+idmateria+","+idtipocomponente+","+idespaciosfisicos+",'"+codprofe+"','"+fechaPlanificarIni+"',"+"'"+fechaPlanificarFin+"'");
            HorariosPlanificacionDto horasDto = new HorariosPlanificacionDto();
            if (ds_horas.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_horas.Tables[0].Rows)
                {
                    horasDto.id = Convert.ToInt32(row["id"].ToString());
                    horasDto.horai =TimeOnly.Parse(row["horai"].ToString());
                    horasDto.horaf = TimeOnly.Parse(row["horaf"].ToString());
                    if (opcion == "S")
                    {
                        horasDto.dLunes = row["1"].ToString();
                        horasDto.dMartes = row["2"].ToString();
                        horasDto.dMiercoles = row["3"].ToString();
                        horasDto.dJueves = row["4"].ToString();
                        horasDto.dViernes = row["5"].ToString();
                        horasDto.dSabado = row["6"].ToString();
                    }
                    else
                    {
                        horasDto.CalendarDate = row["CalendarDate"].ToString();
                        horasDto.idplanificacion = row["ID_PLANIFICACION"].ToString();
                    }
          
                    listahoras.Add(horasDto);
                    horasDto = new HorariosPlanificacionDto();
                }
            }
            return listahoras;
        }


    }
}
