using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Core
{
    public class PlanificacionCruceRepository : GenericCoreRepository<PlanificacionCruceDto>, IPlanificacionCruceRepository
    {
        public PlanificacionCruceRepository(ZeusCoreContext context) : base(context)
        {
        }

        public List<PlanificacionCruceDto> GetPlanificacionCruce(string opcion, int idplanificacion, int idperiodo, int idespaciosfisicos, string codprofe) 
        {
            PlanificacionCruceDto cruce = new PlanificacionCruceDto();
            List<PlanificacionCruceDto> listaCruce = new List<PlanificacionCruceDto>();
            DataSet ds_cruce = Conexion.ExecZeusCore("sp_ValidaCruceHorario", "'V'," + idplanificacion + "," + idperiodo + "," + idespaciosfisicos + "," + "'" + codprofe + "'" );
            if (ds_cruce.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_cruce.Tables[0].Rows)
                {
                    cruce.Cedula = row["CEDULA"].ToString();
                    cruce.Docente = row["DOCENTE"].ToString();
                    cruce.CodCarrera = row["CODIGO_CARRERA"].ToString();
                    cruce.Carrera = row["NOMBRE_CARRERA"].ToString();
                    cruce.Malla = row["CODIGO_PLAN_ESTUDIO_MALLA"].ToString();
                    cruce.Codigo = row["CODIGO"].ToString();
                    cruce.Materia = row["MATERIA"].ToString();
                    cruce.Aula = row["AULA"].ToString();
                    cruce.Dia = row["DIA"].ToString();
                    cruce.HoraIni = row["HORA_INI"].ToString();
                    cruce.HoraFin = row["HORA_FIN"].ToString();


                    listaCruce.Add(cruce);
                    cruce = new PlanificacionCruceDto();
                }
            }
            return listaCruce;
        }
    }
}
