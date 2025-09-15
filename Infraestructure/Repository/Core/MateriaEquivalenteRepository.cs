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


        public List<ComponentesPlanificacionDto> getPlanificacionE(string periodo, int idMallaEquiv)
        {
            ComponentesPlanificacionDto planificacion = new ComponentesPlanificacionDto();
            List<ComponentesPlanificacionDto> listaPlanificacion = new List<ComponentesPlanificacionDto>();
            DataSet ds_planificacion = Conexion.ExecZeusCore("MateriasEquivalentes", "'LP','" + periodo + "'," + idMallaEquiv);
            //DataSet ds_planificacion = Conexion.BuscarZEUS_ds("PLANIFICACION pln inner join PERIODO per on per.ID_PERIODO=pln.ID_PERIODO inner join MALLA m on m.ID_MALLA = pln.ID_MALLA inner join COMPONENTE cpt on pln.ID_TIPO_COMPONENTE=cpt.ID_SUBTIPO_COMPONENTE and cpt.ID_MATERIA = m.ID_MATERIA and cpt.ID_PLAN_ESTUDIO = m.ID_PLAN_ESTUDIO \r\ninner join MATERIA mat on cpt.ID_MATERIA=mat.ID_MATERIA\r\ninner join PLAN_ESTUDIO ple on cpt.ID_PLAN_ESTUDIO=ple.ID_PLAN_ESTUDIO\r\ninner join MODALIDAD_PE mo on mo.ID_MODALIDAD_PE=pln.ID_MODALIDAD_PLANIFICACION\r\ninner join EMPLEADO pro on pro.IDENTIFICACION_EMP=pln.DNI_PROFESORC\r\ninner join MODALIDAD_PERIODO mope on per.ID_MODALIDAD=mope.ID_MODALIDAD\r\ninner join ESPACIOS_FISICOS ef on ef.ID_ESPACIOS_FISICOS=pln.ID_ESPACIOS_FISICOS inner join NIVEL_INFRAESTRUCTURA ninf on ninf.ID_NIVEL_INFRAESTRUCTURA=ef.ID_NIVEL_INFRAESTRUCTURA\r\ninner join INFRAESTRUCTURA inf on inf.ID_INFRAESTRUCTURA=ninf.ID_INFRAESTRUCTURA \r\ninner join SUBTIPO_COMPONENTE scpt ON pln.ID_TIPO_COMPONENTE = scpt.ID_SUBTIPO_COMPONENTE ", "pln.FECHA_INICIO_PLANIFICACION,pln.FECHA_FIN_PLANIFICACION,pln.ID_MALLA,\r\nmat.HORAS_SEMESTRALES_MATERIA,\r\nmat.CREDITOS_MATERIA,\r\nper.ID_PERIODO,\r\nper.CODIGO_PERIODO,\r\nmat.ID_MATERIA,\r\nmat.CODIGO_MATERIA,\r\nmat.NOMBRE_MATERIA,\r\nPARALELO,CUPO,\r\npln.DNI_PROFESORC,\r\npro.NOMBRES_EMP,\r\npro.APELLIDO_EMP,\r\npln.ID_MODALIDAD_PLANIFICACION,\r\nmo.NOMBRE_MODALIDAD_PE,\r\nmope.NOMBRE_MODALIDADP,\r\nef.CODIGO_ESPACIOS_FISICOS, \r\nple.ID_PLAN_ESTUDIO,\r\nple.CODIGO_PLAN_ESTUDIO_MALLA,\r\nID_PLANIFICACION,\r\npln.ID_TIPO_COMPONENTE,\r\npln.ID_PERIODICIDAD_PLANIFICACION,\r\nef.ID_ESPACIOS_FISICOS,\r\nper.ID_MODALIDAD,\r\nper.ID_ESTADO_PERIODO,\r\nef.ID_NIVEL_INFRAESTRUCTURA,\r\ninf.ID_INFRAESTRUCTURA,\r\nscpt.CODIGO_SUBTIPO_COMPONENTE,\r\npln.ACTIVO   ", "where pln.ID_PERIODO=" + idperiodo + " and ple.ID_PLAN_ESTUDIO=" + idplanestudio + " and pln.ID_MODALIDAD_PLANIFICACION=" + idmodalidadplanificacio);
            if (ds_planificacion.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_planificacion.Tables[0].Rows)
                {
                    var fi = row["FECHA_INICIO_PLANIFICACION"].ToString();
                    var ff = row["FECHA_FIN_PLANIFICACION"].ToString();
                    //planificacion.idNivelEstudio = Convert.ToInt32(row["ID_NIVEL_ESTUDIO"].ToString());
                    planificacion.idMalla = Convert.ToInt32(row["ID_MALLA"].ToString());
                    planificacion.horasSemestralesMateria = Convert.ToInt32(row["HORAS_SEMESTRALES_MATERIA"].ToString());
                    planificacion.creditosMateria = float.Parse(row["CREDITOS_MATERIA"].ToString());
                    planificacion.idPlanificacion = Convert.ToInt32(row["ID_PLANIFICACION"].ToString());
                    planificacion.idPeriodo = Convert.ToInt32(row["ID_PERIODO"].ToString());
                    planificacion.codigoPeriodo = row["CODIGO_PERIODO"].ToString();
                    planificacion.idMateria = Convert.ToInt32(row["ID_MATERIA"].ToString());
                    planificacion.codigoMateria = row["CODIGO_MATERIA"].ToString();
                    planificacion.nombreMateria = row["NOMBRE_MATERIA"].ToString();
                    planificacion.paralelo = row["PARALELO"].ToString();
                    planificacion.cupo = Convert.ToInt32(row["CUPO"].ToString());
                    planificacion.dniProfesorc = row["DNI_PROFESORC"].ToString();
                    planificacion.nombresEmp = row["NOMBRES_EMP"].ToString();
                    planificacion.apellidoEmp = row["APELLIDO_EMP"].ToString();
                    planificacion.idModalidadPlanificacion = Convert.ToInt32(row["ID_MODALIDAD_PLANIFICACION"].ToString());
                    planificacion.NombreModalidadPe = row["NOMBRE_MODALIDAD_PE"].ToString();
                    planificacion.NombreModalidadp = row["NOMBRE_MODALIDADP"].ToString();
                    planificacion.codigoEspaciosFisicos = row["CODIGO_ESPACIOS_FISICOS"].ToString();
                    planificacion.idPlanEstudio = Convert.ToInt32(row["ID_PLAN_ESTUDIO"].ToString());
                    planificacion.idTipoComponente = Convert.ToInt32(row["ID_TIPO_COMPONENTE"].ToString());
                    planificacion.idPeriodicidad = Convert.ToInt32(row["ID_PERIODICIDAD_PLANIFICACION"].ToString());
                    planificacion.idEspaciosFisicos = Convert.ToInt32(row["ID_ESPACIOS_FISICOS"].ToString());
                    planificacion.idModalidad = Convert.ToInt32(row["ID_MODALIDAD"].ToString());
                    planificacion.IdEstadoPeriodo = Convert.ToInt32(row["ID_ESTADO_PERIODO"].ToString());
                    planificacion.IdNivelInfraestructura = Convert.ToInt32(row["ID_NIVEL_INFRAESTRUCTURA"].ToString());
                    planificacion.IdInfraestructura = Convert.ToInt32(row["ID_INFRAESTRUCTURA"].ToString());
                    planificacion.CodigoSubtipoComponente = row["CODIGO_SUBTIPO_COMPONENTE"].ToString();
                    planificacion.activo = Convert.ToBoolean(row["ACTIVO"].ToString());
                    planificacion.FechaInicioPlanificacion = fi == "" ? null : Convert.ToDateTime(row["FECHA_INICIO_PLANIFICACION"].ToString());
                    planificacion.FechaFinPlanificacion = ff == "" ? null : Convert.ToDateTime(row["FECHA_FIN_PLANIFICACION"].ToString());
                    listaPlanificacion.Add(planificacion);
                    planificacion = new ComponentesPlanificacionDto();
                }
            }
            return listaPlanificacion;
        }
    }
}
