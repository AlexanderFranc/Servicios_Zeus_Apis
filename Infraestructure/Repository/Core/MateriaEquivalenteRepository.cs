using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces;
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
    public class MateriaEquivalenteRepository : GenericCoreRepository<MateriaEquivalenteDto>, IMateriaEquivalenteRepository
    {
        public MateriaEquivalenteRepository(ZeusCoreContext context) : base(context)
        {
        }

        public List<MateriaEquivalenteDto> getPlanificacionEquivalente(string periodo, int idMallaEquiv)
        {
            MateriaEquivalenteDto plnMatEquiv = new MateriaEquivalenteDto();
            List<MateriaEquivalenteDto> listaPlnMatEquiv = new List<MateriaEquivalenteDto>();

            DataSet ds_plnMatEquiv = Conexion.ExecZeusCore("MateriasEquivalentes", "'L','" + periodo + "'," + idMallaEquiv);
            

            if (ds_plnMatEquiv.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_plnMatEquiv.Tables[0].Rows)
                {
                    //planificacion.idNivelEstudio = Convert.ToInt32(row["ID_NIVEL_ESTUDIO"].ToString());
                    plnMatEquiv.IdPlanificacion = Convert.ToInt32(row["ID_PLANIFICACION"].ToString());
                    plnMatEquiv.CodigoPeriodo = row["CODIGO_PERIODO"].ToString();
                    plnMatEquiv.CodigoPlanEstudio = row["CODIGO_PLAN_ESTUDIO_MALLA"].ToString();
                    plnMatEquiv.CodigoMateria = row["CODIGO_MATERIA"].ToString();
                    plnMatEquiv.NombreMateria  = row["NOMBRE_MATERIA"].ToString();
                    plnMatEquiv.CodigoSubtipoComponente = row["CODIGO_SUBTIPO_COMPONENTE"].ToString();
                    plnMatEquiv.DniProfesorc = row["DNI_PROFESORC"].ToString();
                    plnMatEquiv.Docente = row["DOCENTE"].ToString();
                    plnMatEquiv.Paralelo = row["PARALELO"].ToString();
                    
                    listaPlnMatEquiv.Add(plnMatEquiv);
                    plnMatEquiv = new MateriaEquivalenteDto();
                }
            }
            return listaPlnMatEquiv;
        }
    }
}
