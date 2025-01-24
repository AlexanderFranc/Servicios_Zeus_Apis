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
using System.Security.Cryptography;
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
        public List<SolicitudPlanificacionDto> getSolicitudPlanificacion(int idperiodo, int idplanestudio, int idmodalidadplanificacio)
        {
            SolicitudPlanificacionDto solicitudPlanificacion = new SolicitudPlanificacionDto();
            List<SolicitudPlanificacionDto> listaSolicitudPlanificacion = new List<SolicitudPlanificacionDto>();
            DataSet ds_solicitud = Conexion.BuscarZEUS_ds("PLANIFICACION_TEMP pln inner join PERIODO per on per.ID_PERIODO=pln.ID_PERIODO inner join MALLA m on m.ID_MALLA = pln.ID_MALLA inner join COMPONENTE cpt on pln.ID_TIPO_COMPONENTE=cpt.ID_SUBTIPO_COMPONENTE and cpt.ID_MATERIA = m.ID_MATERIA and cpt.ID_PLAN_ESTUDIO = m.ID_PLAN_ESTUDIO\r\ninner join MATERIA mat on cpt.ID_MATERIA=mat.ID_MATERIA\r\ninner join PLAN_ESTUDIO ple on cpt.ID_PLAN_ESTUDIO=ple.ID_PLAN_ESTUDIO\r\ninner join MODALIDAD_PE mo on mo.ID_MODALIDAD_PE=pln.ID_MODALIDAD_PLANIFICACION\r\ninner join EMPLEADO pro on pro.IDENTIFICACION_EMP=pln.DNI_PROFESORC\r\ninner join MODALIDAD_PERIODO mope on per.ID_MODALIDAD=mope.ID_MODALIDAD\r\ninner join ESPACIOS_FISICOS ef on ef.ID_ESPACIOS_FISICOS=pln.ID_ESPACIOS_FISICOS \r\ninner join NIVEL_INFRAESTRUCTURA ninf on ninf.ID_NIVEL_INFRAESTRUCTURA=ef.ID_NIVEL_INFRAESTRUCTURA\r\ninner join INFRAESTRUCTURA inf on inf.ID_INFRAESTRUCTURA=ninf.ID_INFRAESTRUCTURA\r\ninner join SUBTIPO_COMPONENTE scpt ON pln.ID_TIPO_COMPONENTE = scpt.ID_SUBTIPO_COMPONENTE inner join SOLICITUD s on S.ID_ASOCIADO = PLN.ID_PLANIFICACION  \r\ninner join ESTADO_SOLICITUD es on S.ID_ESTADO=ES.ID_ESTADO",
                "pln.ID_MALLA,\r\nmat.HORAS_SEMESTRALES_MATERIA,\r\nmat.CREDITOS_MATERIA,\r\nper.ID_PERIODO,\r\nper.CODIGO_PERIODO,\r\nmat.ID_MATERIA,\r\nmat.CODIGO_MATERIA,\r\nmat.NOMBRE_MATERIA,\r\nPARALELO,CUPO,\r\npln.DNI_PROFESORC,\r\npro.NOMBRES_EMP,\r\npro.APELLIDO_EMP,\r\npln.ID_MODALIDAD_PLANIFICACION,\r\nmo.NOMBRE_MODALIDAD_PE,\r\nmope.NOMBRE_MODALIDADP,\r\nef.CODIGO_ESPACIOS_FISICOS, \r\nple.ID_PLAN_ESTUDIO,\r\nple.CODIGO_PLAN_ESTUDIO_MALLA,\r\nID_PLANIFICACION,\r\npln.ID_TIPO_COMPONENTE,\r\npln.ID_PERIODICIDAD_PLANIFICACION,\r\nef.ID_ESPACIOS_FISICOS,\r\nper.ID_MODALIDAD,\r\nper.ID_ESTADO_PERIODO,\r\nef.ID_NIVEL_INFRAESTRUCTURA,\r\ninf.ID_INFRAESTRUCTURA,\r\nscpt.CODIGO_SUBTIPO_COMPONENTE,\r\npln.ACTIVO,S.TIPO_SOLICITUD,convert(varchar(20),s.FECHA_SOLICITUD, 23) FECHA_SOLICITUD,ES.ESTADO,S.ID_SOLICITUD,ES.ID_ESTADO ", 
                "where pln.ID_PERIODO=" + idperiodo + " and ple.ID_PLAN_ESTUDIO=" + idplanestudio + " and pln.ID_MODALIDAD_PLANIFICACION=" + idmodalidadplanificacio);
            //DataSet ds_solicitud = Conexion.ExecZeusCore("Solicitudes", "'" + opcion + "','" + tipo + "','" + periodo + "','" + codfac + "','" + codcar + "','" + estado + "'");
            if (ds_solicitud.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_solicitud.Tables[0].Rows)
                {
                    //planificacion.idNivelEstudio = Convert.ToInt32(row["ID_NIVEL_ESTUDIO"].ToString());
                    solicitudPlanificacion.idMalla = Convert.ToInt32(row["ID_MALLA"].ToString());
                    solicitudPlanificacion.horasSemestralesMateria = Convert.ToInt32(row["HORAS_SEMESTRALES_MATERIA"].ToString());
                    solicitudPlanificacion.creditosMateria = float.Parse(row["CREDITOS_MATERIA"].ToString());
                    solicitudPlanificacion.idPlanificacion = Convert.ToInt32(row["ID_PLANIFICACION"].ToString());
                    solicitudPlanificacion.idPeriodo = Convert.ToInt32(row["ID_PERIODO"].ToString());
                    solicitudPlanificacion.codigoPeriodo = row["CODIGO_PERIODO"].ToString();
                    solicitudPlanificacion.idMateria = Convert.ToInt32(row["ID_MATERIA"].ToString());
                    solicitudPlanificacion.codigoMateria = row["CODIGO_MATERIA"].ToString();
                    solicitudPlanificacion.nombreMateria = row["NOMBRE_MATERIA"].ToString();
                    solicitudPlanificacion.paralelo = row["PARALELO"].ToString();
                    solicitudPlanificacion.cupo = Convert.ToInt32(row["CUPO"].ToString());
                    solicitudPlanificacion.dniProfesorc = row["DNI_PROFESORC"].ToString();
                    solicitudPlanificacion.nombresEmp = row["NOMBRES_EMP"].ToString();
                    solicitudPlanificacion.apellidoEmp = row["APELLIDO_EMP"].ToString();
                    solicitudPlanificacion.idModalidadPlanificacion = Convert.ToInt32(row["ID_MODALIDAD_PLANIFICACION"].ToString());
                    solicitudPlanificacion.NombreModalidadPe = row["NOMBRE_MODALIDAD_PE"].ToString();
                    solicitudPlanificacion.NombreModalidadp = row["NOMBRE_MODALIDADP"].ToString();
                    solicitudPlanificacion.codigoEspaciosFisicos = row["CODIGO_ESPACIOS_FISICOS"].ToString();
                    solicitudPlanificacion.idPlanEstudio = Convert.ToInt32(row["ID_PLAN_ESTUDIO"].ToString());
                    solicitudPlanificacion.idTipoComponente = Convert.ToInt32(row["ID_TIPO_COMPONENTE"].ToString());
                    solicitudPlanificacion.idPeriodicidad = Convert.ToInt32(row["ID_PERIODICIDAD_PLANIFICACION"].ToString());
                    solicitudPlanificacion.idEspaciosFisicos = Convert.ToInt32(row["ID_ESPACIOS_FISICOS"].ToString());
                    solicitudPlanificacion.idModalidad = Convert.ToInt32(row["ID_MODALIDAD"].ToString());
                    solicitudPlanificacion.IdEstadoPeriodo = Convert.ToInt32(row["ID_ESTADO_PERIODO"].ToString());
                    solicitudPlanificacion.IdNivelInfraestructura = Convert.ToInt32(row["ID_NIVEL_INFRAESTRUCTURA"].ToString());
                    solicitudPlanificacion.IdInfraestructura = Convert.ToInt32(row["ID_INFRAESTRUCTURA"].ToString());
                    solicitudPlanificacion.CodigoSubtipoComponente = row["CODIGO_SUBTIPO_COMPONENTE"].ToString();
                    solicitudPlanificacion.activo = Convert.ToBoolean(row["ACTIVO"].ToString());
                    solicitudPlanificacion.TipoSolicitud = row["TIPO_SOLICITUD"].ToString();
                    solicitudPlanificacion.FechaSolicitud = row["FECHA_SOLICITUD"].ToString();
                    solicitudPlanificacion.Estado = row["ESTADO"].ToString();
                    solicitudPlanificacion.IdSolicitud = Convert.ToInt32(row["ID_SOLICITUD"].ToString());
                    solicitudPlanificacion.IdEstado = Convert.ToInt32(row["ID_ESTADO"].ToString());

                    listaSolicitudPlanificacion.Add(solicitudPlanificacion);
                    solicitudPlanificacion = new SolicitudPlanificacionDto();
                }
            }
            return listaSolicitudPlanificacion;
        }


        public List<SolicitudPlanificacionDto> getSolicitudPlanificacionVice(int idperiodo, int idfacultad, int idcarrera, string estado)
        {
            SolicitudPlanificacionDto solicitudPlanificacion = new SolicitudPlanificacionDto();
            List<SolicitudPlanificacionDto> listaSolicitudPlanificacion = new List<SolicitudPlanificacionDto>();
            //DataSet ds_solicitud = Conexion.BuscarZEUS_ds("PLANIFICACION pln inner join PERIODO per on per.ID_PERIODO=pln.ID_PERIODO inner join MALLA m on m.ID_MALLA = pln.ID_MALLA inner join COMPONENTE cpt on pln.ID_TIPO_COMPONENTE=cpt.ID_SUBTIPO_COMPONENTE and cpt.ID_MATERIA = m.ID_MATERIA and cpt.ID_PLAN_ESTUDIO = m.ID_PLAN_ESTUDIO \r\ninner join MATERIA mat on cpt.ID_MATERIA=mat.ID_MATERIA\r\ninner join PLAN_ESTUDIO ple on cpt.ID_PLAN_ESTUDIO=ple.ID_PLAN_ESTUDIO\r\ninner join MODALIDAD_PE mo on mo.ID_MODALIDAD_PE=pln.ID_MODALIDAD_PLANIFICACION\r\ninner join EMPLEADO pro on pro.IDENTIFICACION_EMP=pln.DNI_PROFESORC\r\ninner join MODALIDAD_PERIODO mope on per.ID_MODALIDAD=mope.ID_MODALIDAD\r\ninner join ESPACIOS_FISICOS ef on ef.ID_ESPACIOS_FISICOS=pln.ID_ESPACIOS_FISICOS inner join NIVEL_INFRAESTRUCTURA ninf on ninf.ID_NIVEL_INFRAESTRUCTURA=ef.ID_NIVEL_INFRAESTRUCTURA\r\ninner join INFRAESTRUCTURA inf on inf.ID_INFRAESTRUCTURA=ninf.ID_INFRAESTRUCTURA \r\ninner join SUBTIPO_COMPONENTE scpt ON pln.ID_TIPO_COMPONENTE = scpt.ID_SUBTIPO_COMPONENTE inner join SOLICITUD s on S.ID_ASOCIADO = PLN.ID_PLANIFICACION  ", "pln.ID_MALLA,\r\nmat.HORAS_SEMESTRALES_MATERIA,\r\nmat.CREDITOS_MATERIA,\r\nper.ID_PERIODO,\r\nper.CODIGO_PERIODO,\r\nmat.ID_MATERIA,\r\nmat.CODIGO_MATERIA,\r\nmat.NOMBRE_MATERIA,\r\nPARALELO,CUPO,\r\npln.DNI_PROFESORC,\r\npro.NOMBRES_EMP,\r\npro.APELLIDO_EMP,\r\npln.ID_MODALIDAD_PLANIFICACION,\r\nmo.NOMBRE_MODALIDAD_PE,\r\nmope.NOMBRE_MODALIDADP,\r\nef.CODIGO_ESPACIOS_FISICOS, \r\nple.ID_PLAN_ESTUDIO,\r\nple.CODIGO_PLAN_ESTUDIO_MALLA,\r\nID_PLANIFICACION,\r\npln.ID_TIPO_COMPONENTE,\r\npln.ID_PERIODICIDAD_PLANIFICACION,\r\nef.ID_ESPACIOS_FISICOS,\r\nper.ID_MODALIDAD,\r\nper.ID_ESTADO_PERIODO,\r\nef.ID_NIVEL_INFRAESTRUCTURA,\r\ninf.ID_INFRAESTRUCTURA,\r\nscpt.CODIGO_SUBTIPO_COMPONENTE,\r\npln.ACTIVO,S.TIPO_SOLICITUD,convert(varchar(20),s.FECHA_SOLICITUD, 23) FECHA_SOLICITUD,S.ESTADO   ", "where pln.ID_PERIODO=" + idperiodo + " and ple.ID_PLAN_ESTUDIO=" + idplanestudio + " and pln.ID_MODALIDAD_PLANIFICACION=" + idmodalidadplanificacio);

            //DataSet ds_horarioocupado = Conexion.ExecZeusCore("HorariosPLanificacion", "'S'," + idperiodo + "," + idperiodicidad + "," + idmateria + "," + idsubtipocomponente + "," + idespacio + "," + "'" + ceduladocente + "','2023-06-04','2023-07-11'," + idplanificacion);
            DataSet ds_solicitud = Conexion.ExecZeusCore("Solicitudes", "'LV','PLAN'," + idperiodo + "," + idfacultad + "," + idcarrera + ",'" + estado + "'");
            if (ds_solicitud.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_solicitud.Tables[0].Rows)
                {
                    //planificacion.idNivelEstudio = Convert.ToInt32(row["ID_NIVEL_ESTUDIO"].ToString());
                    solicitudPlanificacion.idMalla = Convert.ToInt32(row["ID_MALLA"].ToString());
                    solicitudPlanificacion.horasSemestralesMateria = Convert.ToInt32(row["HORAS_SEMESTRALES_MATERIA"].ToString());
                    solicitudPlanificacion.creditosMateria = float.Parse(row["CREDITOS_MATERIA"].ToString());
                    solicitudPlanificacion.idPlanificacion = Convert.ToInt32(row["ID_PLANIFICACION"].ToString());
                    solicitudPlanificacion.idPeriodo = Convert.ToInt32(row["ID_PERIODO"].ToString());
                    solicitudPlanificacion.codigoPeriodo = row["CODIGO_PERIODO"].ToString();
                    solicitudPlanificacion.idMateria = Convert.ToInt32(row["ID_MATERIA"].ToString());
                    solicitudPlanificacion.codigoMateria = row["CODIGO_MATERIA"].ToString();
                    solicitudPlanificacion.nombreMateria = row["NOMBRE_MATERIA"].ToString();
                    solicitudPlanificacion.paralelo = row["PARALELO"].ToString();
                    solicitudPlanificacion.cupo = Convert.ToInt32(row["CUPO"].ToString());
                    solicitudPlanificacion.dniProfesorc = row["DNI_PROFESORC"].ToString();
                    solicitudPlanificacion.nombresEmp = row["NOMBRES_EMP"].ToString();
                    solicitudPlanificacion.apellidoEmp = row["APELLIDO_EMP"].ToString();
                    solicitudPlanificacion.idModalidadPlanificacion = Convert.ToInt32(row["ID_MODALIDAD_PLANIFICACION"].ToString());
                    solicitudPlanificacion.NombreModalidadPe = row["NOMBRE_MODALIDAD_PE"].ToString();
                    solicitudPlanificacion.NombreModalidadp = row["NOMBRE_MODALIDADP"].ToString();
                    solicitudPlanificacion.codigoEspaciosFisicos = row["CODIGO_ESPACIOS_FISICOS"].ToString();
                    solicitudPlanificacion.idPlanEstudio = Convert.ToInt32(row["ID_PLAN_ESTUDIO"].ToString());
                    solicitudPlanificacion.idTipoComponente = Convert.ToInt32(row["ID_TIPO_COMPONENTE"].ToString());
                    solicitudPlanificacion.idPeriodicidad = Convert.ToInt32(row["ID_PERIODICIDAD_PLANIFICACION"].ToString());
                    solicitudPlanificacion.idEspaciosFisicos = Convert.ToInt32(row["ID_ESPACIOS_FISICOS"].ToString());
                    solicitudPlanificacion.idModalidad = Convert.ToInt32(row["ID_MODALIDAD"].ToString());
                    solicitudPlanificacion.IdEstadoPeriodo = Convert.ToInt32(row["ID_ESTADO_PERIODO"].ToString());
                    solicitudPlanificacion.IdNivelInfraestructura = Convert.ToInt32(row["ID_NIVEL_INFRAESTRUCTURA"].ToString());
                    solicitudPlanificacion.IdInfraestructura = Convert.ToInt32(row["ID_INFRAESTRUCTURA"].ToString());
                    solicitudPlanificacion.CodigoSubtipoComponente = row["CODIGO_SUBTIPO_COMPONENTE"].ToString();
                    solicitudPlanificacion.activo = Convert.ToBoolean(row["ACTIVO"].ToString());
                    solicitudPlanificacion.IdSolicitud = Convert.ToInt32(row["ID_SOLICITUD"].ToString());
                    solicitudPlanificacion.IdAsociado = Convert.ToInt32(row["ID_ASOCIADO"].ToString());
                    solicitudPlanificacion.TipoSolicitud = row["TIPO_SOLICITUD"].ToString();
                    solicitudPlanificacion.FechaSolicitud = row["FECHA_SOLICITUD"].ToString();
                    solicitudPlanificacion.Estado = row["ESTADO"].ToString();
                    solicitudPlanificacion.CodigoFacultad = row["CODIGO_FACULTAD"].ToString();
                    solicitudPlanificacion.NombreFacultad = row["NOMBRE_FACULTAD"].ToString();
                    solicitudPlanificacion.CodigoCarrera = row["CODIGO_CARRERA"].ToString();
                    solicitudPlanificacion.NombreCarrera = row["NOMBRE_CARRERA"].ToString();
                    solicitudPlanificacion.CODIGO_PLAN_ESTUDIO_MALLA = row["CODIGO_PLAN_ESTUDIO_MALLA"].ToString();
                    solicitudPlanificacion.IdEstado = Convert.ToInt32(row["ID_ESTADO"].ToString());
                    solicitudPlanificacion.motivo = row["MOTIVO"].ToString();

                    listaSolicitudPlanificacion.Add(solicitudPlanificacion);
                    solicitudPlanificacion = new SolicitudPlanificacionDto();
                }
            }
            return listaSolicitudPlanificacion;
        }

        public List<SolicitudEmpleadoDto> getSolicitudNuevoEmp(int idperiodo, int idfacultad, string estado)
        {
            SolicitudEmpleadoDto solicitudEmpleado = new SolicitudEmpleadoDto();
            List<SolicitudEmpleadoDto> listaSolicitudEmpleado = new List<SolicitudEmpleadoDto>();
            //DataSet ds_solicitud = Conexion.BuscarZEUS_ds("PLANIFICACION pln inner join PERIODO per on per.ID_PERIODO=pln.ID_PERIODO inner join MALLA m on m.ID_MALLA = pln.ID_MALLA inner join COMPONENTE cpt on pln.ID_TIPO_COMPONENTE=cpt.ID_SUBTIPO_COMPONENTE and cpt.ID_MATERIA = m.ID_MATERIA and cpt.ID_PLAN_ESTUDIO = m.ID_PLAN_ESTUDIO \r\ninner join MATERIA mat on cpt.ID_MATERIA=mat.ID_MATERIA\r\ninner join PLAN_ESTUDIO ple on cpt.ID_PLAN_ESTUDIO=ple.ID_PLAN_ESTUDIO\r\ninner join MODALIDAD_PE mo on mo.ID_MODALIDAD_PE=pln.ID_MODALIDAD_PLANIFICACION\r\ninner join EMPLEADO pro on pro.IDENTIFICACION_EMP=pln.DNI_PROFESORC\r\ninner join MODALIDAD_PERIODO mope on per.ID_MODALIDAD=mope.ID_MODALIDAD\r\ninner join ESPACIOS_FISICOS ef on ef.ID_ESPACIOS_FISICOS=pln.ID_ESPACIOS_FISICOS inner join NIVEL_INFRAESTRUCTURA ninf on ninf.ID_NIVEL_INFRAESTRUCTURA=ef.ID_NIVEL_INFRAESTRUCTURA\r\ninner join INFRAESTRUCTURA inf on inf.ID_INFRAESTRUCTURA=ninf.ID_INFRAESTRUCTURA \r\ninner join SUBTIPO_COMPONENTE scpt ON pln.ID_TIPO_COMPONENTE = scpt.ID_SUBTIPO_COMPONENTE inner join SOLICITUD s on S.ID_ASOCIADO = PLN.ID_PLANIFICACION  ", "pln.ID_MALLA,\r\nmat.HORAS_SEMESTRALES_MATERIA,\r\nmat.CREDITOS_MATERIA,\r\nper.ID_PERIODO,\r\nper.CODIGO_PERIODO,\r\nmat.ID_MATERIA,\r\nmat.CODIGO_MATERIA,\r\nmat.NOMBRE_MATERIA,\r\nPARALELO,CUPO,\r\npln.DNI_PROFESORC,\r\npro.NOMBRES_EMP,\r\npro.APELLIDO_EMP,\r\npln.ID_MODALIDAD_PLANIFICACION,\r\nmo.NOMBRE_MODALIDAD_PE,\r\nmope.NOMBRE_MODALIDADP,\r\nef.CODIGO_ESPACIOS_FISICOS, \r\nple.ID_PLAN_ESTUDIO,\r\nple.CODIGO_PLAN_ESTUDIO_MALLA,\r\nID_PLANIFICACION,\r\npln.ID_TIPO_COMPONENTE,\r\npln.ID_PERIODICIDAD_PLANIFICACION,\r\nef.ID_ESPACIOS_FISICOS,\r\nper.ID_MODALIDAD,\r\nper.ID_ESTADO_PERIODO,\r\nef.ID_NIVEL_INFRAESTRUCTURA,\r\ninf.ID_INFRAESTRUCTURA,\r\nscpt.CODIGO_SUBTIPO_COMPONENTE,\r\npln.ACTIVO,S.TIPO_SOLICITUD,convert(varchar(20),s.FECHA_SOLICITUD, 23) FECHA_SOLICITUD,S.ESTADO   ", "where pln.ID_PERIODO=" + idperiodo + " and ple.ID_PLAN_ESTUDIO=" + idplanestudio + " and pln.ID_MODALIDAD_PLANIFICACION=" + idmodalidadplanificacio);

            //DataSet ds_horarioocupado = Conexion.ExecZeusCore("HorariosPLanificacion", "'S'," + idperiodo + "," + idperiodicidad + "," + idmateria + "," + idsubtipocomponente + "," + idespacio + "," + "'" + ceduladocente + "','2023-06-04','2023-07-11'," + idplanificacion);
            DataSet ds_solicitud = Conexion.ExecZeusCore("Solicitudes", "'TH','PLAN'," + idperiodo + "," + idfacultad + ",null,'" + estado + "'");
            if (ds_solicitud.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_solicitud.Tables[0].Rows)
                {
                    //planificacion.idNivelEstudio = Convert.ToInt32(row["ID_NIVEL_ESTUDIO"].ToString());
                    solicitudEmpleado.IdEmpNuevo = Convert.ToInt32(row["ID_EMP_NUEVO"].ToString());
                    solicitudEmpleado.IdFacultad = Convert.ToInt32(row["id_facultad"].ToString());
                    solicitudEmpleado.CodigoFacultad = row["CODIGO_FACULTAD"].ToString();
                    solicitudEmpleado.NombreFacultad = row["NOMBRE_FACULTAD"].ToString();
                    solicitudEmpleado.Identificacion = row["identificacion"].ToString();
                    solicitudEmpleado.Nombre = row["nombre"].ToString();

                    solicitudEmpleado.Apellido = row["apellido"].ToString();
                    solicitudEmpleado.Celular = row["celular"].ToString();
                    solicitudEmpleado.TipoContrato = row["TIPO_CONTRATO"].ToString();
                    solicitudEmpleado.FC = Convert.ToDateTime(row["fc"].ToString());
                    solicitudEmpleado.IdEstado = Convert.ToInt32(row["ID_ESTADO"].ToString());
                    solicitudEmpleado.Estado = row["ESTADO"].ToString();
                    solicitudEmpleado.Motivo = row["MOTIVO"].ToString();
                    solicitudEmpleado.Observacion = row["OBSERVACION"].ToString();
                    solicitudEmpleado.IdPeriodo = Convert.ToInt32(row["ID_PERIODO"].ToString());
                    solicitudEmpleado.Periodo = row["CODIGO_PERIODO"].ToString();


                    listaSolicitudEmpleado.Add(solicitudEmpleado);
                    solicitudEmpleado = new SolicitudEmpleadoDto();
                }
            }
            return listaSolicitudEmpleado;
        }

        public List<EmpleadoTempNuevoDto> getNuevoEmp(int idEmpleadoN)
        {
            EmpleadoTempNuevoDto empleadoNuevoTemp = new EmpleadoTempNuevoDto();
            List<EmpleadoTempNuevoDto> listaempleadoNuevoTemp = new List<EmpleadoTempNuevoDto>();
            //DataSet ds_solicitud = Conexion.BuscarZEUS_ds("PLANIFICACION pln inner join PERIODO per on per.ID_PERIODO=pln.ID_PERIODO inner join MALLA m on m.ID_MALLA = pln.ID_MALLA inner join COMPONENTE cpt on pln.ID_TIPO_COMPONENTE=cpt.ID_SUBTIPO_COMPONENTE and cpt.ID_MATERIA = m.ID_MATERIA and cpt.ID_PLAN_ESTUDIO = m.ID_PLAN_ESTUDIO \r\ninner join MATERIA mat on cpt.ID_MATERIA=mat.ID_MATERIA\r\ninner join PLAN_ESTUDIO ple on cpt.ID_PLAN_ESTUDIO=ple.ID_PLAN_ESTUDIO\r\ninner join MODALIDAD_PE mo on mo.ID_MODALIDAD_PE=pln.ID_MODALIDAD_PLANIFICACION\r\ninner join EMPLEADO pro on pro.IDENTIFICACION_EMP=pln.DNI_PROFESORC\r\ninner join MODALIDAD_PERIODO mope on per.ID_MODALIDAD=mope.ID_MODALIDAD\r\ninner join ESPACIOS_FISICOS ef on ef.ID_ESPACIOS_FISICOS=pln.ID_ESPACIOS_FISICOS inner join NIVEL_INFRAESTRUCTURA ninf on ninf.ID_NIVEL_INFRAESTRUCTURA=ef.ID_NIVEL_INFRAESTRUCTURA\r\ninner join INFRAESTRUCTURA inf on inf.ID_INFRAESTRUCTURA=ninf.ID_INFRAESTRUCTURA \r\ninner join SUBTIPO_COMPONENTE scpt ON pln.ID_TIPO_COMPONENTE = scpt.ID_SUBTIPO_COMPONENTE inner join SOLICITUD s on S.ID_ASOCIADO = PLN.ID_PLANIFICACION  ", "pln.ID_MALLA,\r\nmat.HORAS_SEMESTRALES_MATERIA,\r\nmat.CREDITOS_MATERIA,\r\nper.ID_PERIODO,\r\nper.CODIGO_PERIODO,\r\nmat.ID_MATERIA,\r\nmat.CODIGO_MATERIA,\r\nmat.NOMBRE_MATERIA,\r\nPARALELO,CUPO,\r\npln.DNI_PROFESORC,\r\npro.NOMBRES_EMP,\r\npro.APELLIDO_EMP,\r\npln.ID_MODALIDAD_PLANIFICACION,\r\nmo.NOMBRE_MODALIDAD_PE,\r\nmope.NOMBRE_MODALIDADP,\r\nef.CODIGO_ESPACIOS_FISICOS, \r\nple.ID_PLAN_ESTUDIO,\r\nple.CODIGO_PLAN_ESTUDIO_MALLA,\r\nID_PLANIFICACION,\r\npln.ID_TIPO_COMPONENTE,\r\npln.ID_PERIODICIDAD_PLANIFICACION,\r\nef.ID_ESPACIOS_FISICOS,\r\nper.ID_MODALIDAD,\r\nper.ID_ESTADO_PERIODO,\r\nef.ID_NIVEL_INFRAESTRUCTURA,\r\ninf.ID_INFRAESTRUCTURA,\r\nscpt.CODIGO_SUBTIPO_COMPONENTE,\r\npln.ACTIVO,S.TIPO_SOLICITUD,convert(varchar(20),s.FECHA_SOLICITUD, 23) FECHA_SOLICITUD,S.ESTADO   ", "where pln.ID_PERIODO=" + idperiodo + " and ple.ID_PLAN_ESTUDIO=" + idplanestudio + " and pln.ID_MODALIDAD_PLANIFICACION=" + idmodalidadplanificacio);

            //DataSet ds_horarioocupado = Conexion.ExecZeusCore("HorariosPLanificacion", "'S'," + idperiodo + "," + idperiodicidad + "," + idmateria + "," + idsubtipocomponente + "," + idespacio + "," + "'" + ceduladocente + "','2023-06-04','2023-07-11'," + idplanificacion);
            DataSet ds_solicitud = Conexion.ExecZeusCore("Solicitudes", "'CI',null,null,null,null,null," + idEmpleadoN);
            if (ds_solicitud.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_solicitud.Tables[0].Rows)
                {
                    //planificacion.idNivelEstudio = Convert.ToInt32(row["ID_NIVEL_ESTUDIO"].ToString());
                    empleadoNuevoTemp.IdEmpNuevo = Convert.ToInt32(row["ID_EMP_NUEVO"].ToString());
                    empleadoNuevoTemp.TipoIdentificacion = Convert.ToInt32(row["TIPO_IDENTIFICACION"].ToString());
                    empleadoNuevoTemp.Identificacion = row["IDENTIFICACION"].ToString();
                    empleadoNuevoTemp.Nombre = row["NOMBRE"].ToString();
                    empleadoNuevoTemp.Apellido = row["APELLIDO"].ToString();
                    empleadoNuevoTemp.Celular = row["CELULAR"].ToString();
                    empleadoNuevoTemp.Email = row["EMAIL"].ToString();
                    empleadoNuevoTemp.IdUnidadEducativa = Convert.ToInt32(row["ID_UNIDAD_EDUCATIVA"].ToString());
                    empleadoNuevoTemp.NombreUnidadEducativa = row["NOMBRE_UNIDAD_EDUCATIVA"].ToString();
                    empleadoNuevoTemp.UnidadEducativa = row["UNIDAD_EDUCATIVA"].ToString();
                    empleadoNuevoTemp.Titulo = row["TITULO"].ToString();
                    empleadoNuevoTemp.IdCampoAmplio = Convert.ToInt32(row["ID_CAMPO_AMPLIO"].ToString());
                    empleadoNuevoTemp.CampoAmplio = row["CAMPO_AMPLIO"].ToString();
                    empleadoNuevoTemp.IdCampoEspecifico = Convert.ToInt32(row["ID_CAMPO_ESPECIFICO"].ToString());
                    empleadoNuevoTemp.CampoEspecifico = row["CAMPO_ESPECIFICO"].ToString();
                    empleadoNuevoTemp.IdFacultad = Convert.ToInt32(row["ID_FACULTAD"].ToString());
                    empleadoNuevoTemp.CodigoFacultad = row["CODIGO_FACULTAD"].ToString();
                    empleadoNuevoTemp.NombreFacultad = row["NOMBRE_FACULTAD"].ToString();
                    empleadoNuevoTemp.IdTipoEmpleado = Convert.ToInt32(row["ID_TIPO_EMP"].ToString());
                    empleadoNuevoTemp.TipoEmpleado = row["NOMBRE_TIPO_EMP"].ToString();
                    empleadoNuevoTemp.IdTipoContrato = Convert.ToInt32(row["ID_TIPO_CONTRATO"].ToString());
                    empleadoNuevoTemp.TipoContrato = row["TIPO_CONTRATO"].ToString();
                    empleadoNuevoTemp.IdDedicacion = Convert.ToInt32(row["ID_DEDICACION"].ToString());
                    empleadoNuevoTemp.Dedicacion = row["DEDICACION"].ToString();
                    empleadoNuevoTemp.Horario = row["HORARIO"].ToString();
                    empleadoNuevoTemp.IdTitularidad = row["ID_TITULARIDAD"] == null ? null : Convert.ToInt32(row["ID_TITULARIDAD"].ToString());
                    empleadoNuevoTemp.Titularidad = row["TITULARIDAD"].ToString();
                    empleadoNuevoTemp.IdCategoria = Convert.ToInt32(row["ID_CATEGORIA"].ToString());
                    empleadoNuevoTemp.Categoria = row["CATEGORIA"].ToString();
                    empleadoNuevoTemp.IdFormaPago = Convert.ToInt32(row["ID_FORMA_PAGO"].ToString());
                    empleadoNuevoTemp.FPago = row["FPAGO"].ToString();
                    empleadoNuevoTemp.IdEstado = Convert.ToInt32(row["ID_ESTADO"].ToString());
                    empleadoNuevoTemp.Estado = row["ESTADO"].ToString();
                    empleadoNuevoTemp.UC = row["UC"].ToString();
                    empleadoNuevoTemp.FC = Convert.ToDateTime(row["FC"].ToString());
                    //empleadoNuevoTemp.UA = row["UA"].ToString();
                    //empleadoNuevoTemp.FA = Convert.ToDateTime(row["FA"].ToString());



                    listaempleadoNuevoTemp.Add(empleadoNuevoTemp);
                    empleadoNuevoTemp = new EmpleadoTempNuevoDto();
                }
            }
            return listaempleadoNuevoTemp;
        }


        public List<SolicitudPlanificacionDto> getSolicitudPlanificacionNuevoEmp(int idEmpleadoN)
        {
            SolicitudPlanificacionDto solicitudPlanificacion = new SolicitudPlanificacionDto();
            List<SolicitudPlanificacionDto> listaSolicitudPlanificacion = new List<SolicitudPlanificacionDto>();
            DataSet ds_solicitud = Conexion.ExecZeusCore("Solicitudes", "'PSE','PLAN',null,null,null,null,"+ idEmpleadoN);
            //DataSet ds_solicitud = Conexion.ExecZeusCore("Solicitudes", "'" + opcion + "','" + tipo + "','" + periodo + "','" + codfac + "','" + codcar + "','" + estado + "'");
            if (ds_solicitud.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_solicitud.Tables[0].Rows)
                {
                    //planificacion.idNivelEstudio = Convert.ToInt32(row["ID_NIVEL_ESTUDIO"].ToString());
                    solicitudPlanificacion.idMalla = Convert.ToInt32(row["ID_MALLA"].ToString());
                    solicitudPlanificacion.horasSemestralesMateria = Convert.ToInt32(row["HORAS_SEMESTRALES_MATERIA"].ToString());
                    solicitudPlanificacion.horasSemanalesMateria = Convert.ToInt32(row["HORAS_SEMANALES_MATERIA"].ToString());
                    solicitudPlanificacion.creditosMateria = float.Parse(row["CREDITOS_MATERIA"].ToString());
                    solicitudPlanificacion.idPlanificacion = Convert.ToInt32(row["ID_PLANIFICACION"].ToString());
                    solicitudPlanificacion.idPeriodo = Convert.ToInt32(row["ID_PERIODO"].ToString());
                    solicitudPlanificacion.codigoPeriodo = row["CODIGO_PERIODO"].ToString();
                    solicitudPlanificacion.idMateria = Convert.ToInt32(row["ID_MATERIA"].ToString());
                    solicitudPlanificacion.codigoMateria = row["CODIGO_MATERIA"].ToString();
                    solicitudPlanificacion.nombreMateria = row["NOMBRE_MATERIA"].ToString();
                    solicitudPlanificacion.paralelo = row["PARALELO"].ToString();
                    solicitudPlanificacion.cupo = Convert.ToInt32(row["CUPO"].ToString());
                    solicitudPlanificacion.dniProfesorc = row["DNI_PROFESORC"].ToString();
                    solicitudPlanificacion.nombresEmp = row["NOMBRES_EMP"].ToString();
                    solicitudPlanificacion.apellidoEmp = row["APELLIDO_EMP"].ToString();
                    solicitudPlanificacion.idModalidadPlanificacion = Convert.ToInt32(row["ID_MODALIDAD_PLANIFICACION"].ToString());
                    solicitudPlanificacion.NombreModalidadPe = row["NOMBRE_MODALIDAD_PE"].ToString();
                    solicitudPlanificacion.NombreModalidadp = row["NOMBRE_MODALIDADP"].ToString();
                    solicitudPlanificacion.codigoEspaciosFisicos = row["CODIGO_ESPACIOS_FISICOS"].ToString();
                    solicitudPlanificacion.idPlanEstudio = Convert.ToInt32(row["ID_PLAN_ESTUDIO"].ToString());
                    solicitudPlanificacion.idTipoComponente = Convert.ToInt32(row["ID_TIPO_COMPONENTE"].ToString());
                    solicitudPlanificacion.idPeriodicidad = Convert.ToInt32(row["ID_PERIODICIDAD_PLANIFICACION"].ToString());
                    solicitudPlanificacion.idEspaciosFisicos = Convert.ToInt32(row["ID_ESPACIOS_FISICOS"].ToString());
                    solicitudPlanificacion.idModalidad = Convert.ToInt32(row["ID_MODALIDAD"].ToString());
                    solicitudPlanificacion.IdEstadoPeriodo = Convert.ToInt32(row["ID_ESTADO_PERIODO"].ToString());
                    solicitudPlanificacion.IdNivelInfraestructura = Convert.ToInt32(row["ID_NIVEL_INFRAESTRUCTURA"].ToString());
                    solicitudPlanificacion.IdInfraestructura = Convert.ToInt32(row["ID_INFRAESTRUCTURA"].ToString());
                    solicitudPlanificacion.CodigoSubtipoComponente = row["CODIGO_SUBTIPO_COMPONENTE"].ToString();
                    solicitudPlanificacion.activo = Convert.ToBoolean(row["ACTIVO"].ToString());
                    solicitudPlanificacion.TipoSolicitud = row["TIPO_SOLICITUD"].ToString();
                    solicitudPlanificacion.FechaSolicitud = row["FECHA_SOLICITUD"].ToString();
                    solicitudPlanificacion.Estado = row["ESTADO"].ToString();
                    solicitudPlanificacion.IdSolicitud = Convert.ToInt32(row["ID_SOLICITUD"].ToString());
                    solicitudPlanificacion.IdEstado = Convert.ToInt32(row["ID_ESTADO"].ToString());
                    solicitudPlanificacion.CODIGO_PLAN_ESTUDIO_MALLA = row["CODIGO_PLAN_ESTUDIO_MALLA"].ToString();

                    solicitudPlanificacion.IdPlanTemp = Convert.ToInt32(row["ID_PLAN_TEMP"].ToString());
                    solicitudPlanificacion.IdEmpNuevo = Convert.ToInt32(row["ID_EMP_NUEVO"].ToString());

                    listaSolicitudPlanificacion.Add(solicitudPlanificacion);
                    solicitudPlanificacion = new SolicitudPlanificacionDto();
                }
            }
            return listaSolicitudPlanificacion;
        }

        public List<SolicitudPlanificacionDto> getSolicitudPlanificacionTH(int idperiodo, int idfacultad, string estado)
        {
            SolicitudPlanificacionDto solicitudPlanificacion = new SolicitudPlanificacionDto();
            List<SolicitudPlanificacionDto> listaSolicitudPlanificacion = new List<SolicitudPlanificacionDto>();
            //DataSet ds_solicitud = Conexion.BuscarZEUS_ds("PLANIFICACION pln inner join PERIODO per on per.ID_PERIODO=pln.ID_PERIODO inner join MALLA m on m.ID_MALLA = pln.ID_MALLA inner join COMPONENTE cpt on pln.ID_TIPO_COMPONENTE=cpt.ID_SUBTIPO_COMPONENTE and cpt.ID_MATERIA = m.ID_MATERIA and cpt.ID_PLAN_ESTUDIO = m.ID_PLAN_ESTUDIO \r\ninner join MATERIA mat on cpt.ID_MATERIA=mat.ID_MATERIA\r\ninner join PLAN_ESTUDIO ple on cpt.ID_PLAN_ESTUDIO=ple.ID_PLAN_ESTUDIO\r\ninner join MODALIDAD_PE mo on mo.ID_MODALIDAD_PE=pln.ID_MODALIDAD_PLANIFICACION\r\ninner join EMPLEADO pro on pro.IDENTIFICACION_EMP=pln.DNI_PROFESORC\r\ninner join MODALIDAD_PERIODO mope on per.ID_MODALIDAD=mope.ID_MODALIDAD\r\ninner join ESPACIOS_FISICOS ef on ef.ID_ESPACIOS_FISICOS=pln.ID_ESPACIOS_FISICOS inner join NIVEL_INFRAESTRUCTURA ninf on ninf.ID_NIVEL_INFRAESTRUCTURA=ef.ID_NIVEL_INFRAESTRUCTURA\r\ninner join INFRAESTRUCTURA inf on inf.ID_INFRAESTRUCTURA=ninf.ID_INFRAESTRUCTURA \r\ninner join SUBTIPO_COMPONENTE scpt ON pln.ID_TIPO_COMPONENTE = scpt.ID_SUBTIPO_COMPONENTE inner join SOLICITUD s on S.ID_ASOCIADO = PLN.ID_PLANIFICACION  ", "pln.ID_MALLA,\r\nmat.HORAS_SEMESTRALES_MATERIA,\r\nmat.CREDITOS_MATERIA,\r\nper.ID_PERIODO,\r\nper.CODIGO_PERIODO,\r\nmat.ID_MATERIA,\r\nmat.CODIGO_MATERIA,\r\nmat.NOMBRE_MATERIA,\r\nPARALELO,CUPO,\r\npln.DNI_PROFESORC,\r\npro.NOMBRES_EMP,\r\npro.APELLIDO_EMP,\r\npln.ID_MODALIDAD_PLANIFICACION,\r\nmo.NOMBRE_MODALIDAD_PE,\r\nmope.NOMBRE_MODALIDADP,\r\nef.CODIGO_ESPACIOS_FISICOS, \r\nple.ID_PLAN_ESTUDIO,\r\nple.CODIGO_PLAN_ESTUDIO_MALLA,\r\nID_PLANIFICACION,\r\npln.ID_TIPO_COMPONENTE,\r\npln.ID_PERIODICIDAD_PLANIFICACION,\r\nef.ID_ESPACIOS_FISICOS,\r\nper.ID_MODALIDAD,\r\nper.ID_ESTADO_PERIODO,\r\nef.ID_NIVEL_INFRAESTRUCTURA,\r\ninf.ID_INFRAESTRUCTURA,\r\nscpt.CODIGO_SUBTIPO_COMPONENTE,\r\npln.ACTIVO,S.TIPO_SOLICITUD,convert(varchar(20),s.FECHA_SOLICITUD, 23) FECHA_SOLICITUD,S.ESTADO   ", "where pln.ID_PERIODO=" + idperiodo + " and ple.ID_PLAN_ESTUDIO=" + idplanestudio + " and pln.ID_MODALIDAD_PLANIFICACION=" + idmodalidadplanificacio);

            //DataSet ds_horarioocupado = Conexion.ExecZeusCore("HorariosPLanificacion", "'S'," + idperiodo + "," + idperiodicidad + "," + idmateria + "," + idsubtipocomponente + "," + idespacio + "," + "'" + ceduladocente + "','2023-06-04','2023-07-11'," + idplanificacion);
            DataSet ds_solicitud = Conexion.ExecZeusCore("Solicitudes", "'TH','PLAN'," + idperiodo + "," + idfacultad + ",null,'" + estado + "'");
            if (ds_solicitud.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_solicitud.Tables[0].Rows)
                {
                    //planificacion.idNivelEstudio = Convert.ToInt32(row["ID_NIVEL_ESTUDIO"].ToString());
                    solicitudPlanificacion.idMalla = Convert.ToInt32(row["ID_MALLA"].ToString());
                    solicitudPlanificacion.horasSemestralesMateria = Convert.ToInt32(row["HORAS_SEMESTRALES_MATERIA"].ToString());
                    solicitudPlanificacion.creditosMateria = float.Parse(row["CREDITOS_MATERIA"].ToString());
                    solicitudPlanificacion.idPlanificacion = Convert.ToInt32(row["ID_PLANIFICACION"].ToString());
                    solicitudPlanificacion.idPeriodo = Convert.ToInt32(row["ID_PERIODO"].ToString());
                    solicitudPlanificacion.codigoPeriodo = row["CODIGO_PERIODO"].ToString();
                    solicitudPlanificacion.idMateria = Convert.ToInt32(row["ID_MATERIA"].ToString());
                    solicitudPlanificacion.codigoMateria = row["CODIGO_MATERIA"].ToString();
                    solicitudPlanificacion.nombreMateria = row["NOMBRE_MATERIA"].ToString();
                    solicitudPlanificacion.paralelo = row["PARALELO"].ToString();
                    solicitudPlanificacion.cupo = Convert.ToInt32(row["CUPO"].ToString());
                    solicitudPlanificacion.dniProfesorc = row["DNI_PROFESORC"].ToString();
                    solicitudPlanificacion.nombresEmp = row["NOMBRES_EMP"].ToString();
                    solicitudPlanificacion.apellidoEmp = row["APELLIDO_EMP"].ToString();
                    solicitudPlanificacion.idModalidadPlanificacion = Convert.ToInt32(row["ID_MODALIDAD_PLANIFICACION"].ToString());
                    solicitudPlanificacion.NombreModalidadPe = row["NOMBRE_MODALIDAD_PE"].ToString();
                    solicitudPlanificacion.NombreModalidadp = row["NOMBRE_MODALIDADP"].ToString();
                    solicitudPlanificacion.codigoEspaciosFisicos = row["CODIGO_ESPACIOS_FISICOS"].ToString();
                    solicitudPlanificacion.idPlanEstudio = Convert.ToInt32(row["ID_PLAN_ESTUDIO"].ToString());
                    solicitudPlanificacion.idTipoComponente = Convert.ToInt32(row["ID_TIPO_COMPONENTE"].ToString());
                    solicitudPlanificacion.idPeriodicidad = Convert.ToInt32(row["ID_PERIODICIDAD_PLANIFICACION"].ToString());
                    solicitudPlanificacion.idEspaciosFisicos = Convert.ToInt32(row["ID_ESPACIOS_FISICOS"].ToString());
                    solicitudPlanificacion.idModalidad = Convert.ToInt32(row["ID_MODALIDAD"].ToString());
                    solicitudPlanificacion.IdEstadoPeriodo = Convert.ToInt32(row["ID_ESTADO_PERIODO"].ToString());
                    solicitudPlanificacion.IdNivelInfraestructura = Convert.ToInt32(row["ID_NIVEL_INFRAESTRUCTURA"].ToString());
                    solicitudPlanificacion.IdInfraestructura = Convert.ToInt32(row["ID_INFRAESTRUCTURA"].ToString());
                    solicitudPlanificacion.CodigoSubtipoComponente = row["CODIGO_SUBTIPO_COMPONENTE"].ToString();
                    solicitudPlanificacion.activo = Convert.ToBoolean(row["ACTIVO"].ToString());
                    solicitudPlanificacion.IdSolicitud = Convert.ToInt32(row["ID_SOLICITUD"].ToString());
                    solicitudPlanificacion.IdAsociado = Convert.ToInt32(row["ID_ASOCIADO"].ToString());
                    solicitudPlanificacion.TipoSolicitud = row["TIPO_SOLICITUD"].ToString();
                    solicitudPlanificacion.FechaSolicitud = row["FECHA_SOLICITUD"].ToString();
                    solicitudPlanificacion.Estado = row["ESTADO"].ToString();
                    solicitudPlanificacion.CodigoFacultad = row["CODIGO_FACULTAD"].ToString();
                    solicitudPlanificacion.NombreFacultad = row["NOMBRE_FACULTAD"].ToString();
                    solicitudPlanificacion.CodigoCarrera = row["CODIGO_CARRERA"].ToString();
                    solicitudPlanificacion.NombreCarrera = row["NOMBRE_CARRERA"].ToString();
                    solicitudPlanificacion.CODIGO_PLAN_ESTUDIO_MALLA = row["CODIGO_PLAN_ESTUDIO_MALLA"].ToString();

                    listaSolicitudPlanificacion.Add(solicitudPlanificacion);
                    solicitudPlanificacion = new SolicitudPlanificacionDto();
                }
            }
            return listaSolicitudPlanificacion;
        }


        public List<EmpNuevoObservacionLogDto> getLogObservacionesSolicitudNEmp(int idEmpNuevo)
        {
            EmpNuevoObservacionLogDto empNuevoObsLog = new EmpNuevoObservacionLogDto();
            List<EmpNuevoObservacionLogDto> listaempNuevoObsLog = new List<EmpNuevoObservacionLogDto>();
            DataSet ds_empNuevoObsLog = Conexion.BuscarZEUS_ds("LOG_OBSERVACION_SOLICITUD_EMP A\r\nINNER JOIN EMPLEADO B\r\nON A.UC = B.IDENTIFICACION_EMP", "A.ID,A.FC,A.UC,B.APELLIDO_EMP +' ' + B.NOMBRES_EMP USUARIO,A.OBSERVACION ", "WHERE A.ID_EMP_NUEVO="+ idEmpNuevo + " ORDER BY FC");
            //DataSet ds_solicitud = Conexion.ExecZeusCore("Solicitudes", "'" + opcion + "','" + tipo + "','" + periodo + "','" + codfac + "','" + codcar + "','" + estado + "'");
            if (ds_empNuevoObsLog.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_empNuevoObsLog.Tables[0].Rows)
                {
                    //planificacion.idNivelEstudio = Convert.ToInt32(row["ID_NIVEL_ESTUDIO"].ToString());
                    empNuevoObsLog.Id = Convert.ToInt32(row["ID"].ToString());
                    empNuevoObsLog.FC = Convert.ToDateTime(row["FC"].ToString());
                    empNuevoObsLog.UC = row["UC"].ToString();
                    empNuevoObsLog.Usuario = row["USUARIO"].ToString();
                    empNuevoObsLog.Observacion = row["OBSERVACION"].ToString();

                    listaempNuevoObsLog.Add(empNuevoObsLog);
                    empNuevoObsLog = new EmpNuevoObservacionLogDto();
                }
            }
            return listaempNuevoObsLog;
        }

        public string getDetallecruce(string desc)
        {
            string[] ids = desc.ToString().Split(",");
            string resultado = "";
            for (int i = 0; i < ids.Length; i++)
            {
                DataSet ds_data = Conexion.BuscarZEUS_ds("PLANIFICACION_TEMP pln \r\ninner join COMPONENTE comp on pln.ID_TIPO_COMPONENTE=comp.ID_SUBTIPO_COMPONENTE \r\ninner join MALLA ma on pln.ID_MALLA=ma.ID_MALLA and comp.ID_MATERIA=ma.ID_MATERIA and comp.ID_PLAN_ESTUDIO=ma.ID_PLAN_ESTUDIO\r\ninner join MATERIA mat on ma.ID_MATERIA=mat.ID_MATERIA\r\ninner join EMPLEADO emp on pln.DNI_PROFESORC=emp.IDENTIFICACION_EMP\r\ninner join ESPACIOS_FISICOS ef on pln.ID_ESPACIOS_FISICOS=ef.ID_ESPACIOS_FISICOS", "pln.ID_PLAN_TEMP,emp.APELLIDO_EMP +' '+ emp.NOMBRES_EMP + ' / '+mat.codigo_materia +' - '+  mat.NOMBRE_MATERIA +' / '+ef.CODIGO_ESPACIOS_FISICOS +' - '+ef.DESCRIPCION_ESPACIOS_FISICOS as Detalle", "where ID_PLAN_TEMP=" + ids[i]);
                resultado += ds_data.Tables[0].Rows[i]["Detalle"].ToString();
            }
            return resultado;
        }
        public List<HorarioSemestralDto> GetHorarioSolicitud(string tipohorario, int idplanestudio, int? idSolicitud, int idperiodo, int idperiodicidad, int idmateria, int idsubtipocomponente, int idespacio, string ceduladocente)
        {
            //if (idplanificacion == 0)
            //    idplanificacion = null;
            //idplanificacion = 2531;
            //lista que va a contener las horas
            List<HorarioSemestralDto> lstcontenedorhoras = new List<HorarioSemestralDto>();
            //lista contenedora de dias
            List<FechasHorarioSemetral> lstcontenedordias = new List<FechasHorarioSemetral>();
            // se extrae la franja horaria
            List<FechasHorarioSemetral> lstfechahorariosemetral = new List<FechasHorarioSemetral>();
            //0 no tiene nada,1 horarioocupado por algo de planificacion//2 horario ocupado por mi planifiacion
            List<HorasFranjaHorariaDto> listahoras = new List<HorasFranjaHorariaDto>();

            DataSet ds_horas = Conexion.ExecZeusCore("horasfranjahoraria", idplanestudio.ToString());
            //DataSet ds_horarioocupado= Conexion.ExecZeusCore("HorariosPLanificacion", "'S',"+10+","+4+","+420+","+ 1+"," +68 +","+"'1707833354','2023-06-04','2023-07-11'");
            DataSet ds_horarioocupado = Conexion.ExecZeusCore("HorariosPLanificacionSolicitud", "'S'," + idperiodo + "," + idperiodicidad + "," + idmateria + "," + idsubtipocomponente + "," + idespacio + "," + "'" + ceduladocente + "','2023-06-04','2023-07-11'," + idSolicitud);
            foreach (DataRow rowhora in ds_horas.Tables[0].Rows)
            {
                foreach (DataRow rowcruce in ds_horarioocupado.Tables[0].Rows)
                {
                    string[] horaInicial = rowcruce["horai"].ToString().Split(":");
                    string[] horaFinal = rowcruce["horaf"].ToString().Split(":");

                    if (Convert.ToInt32(rowhora["H_I"].ToString()) == Convert.ToInt32(horaInicial[0]) && Convert.ToInt32(rowhora["H_F"].ToString()) == Convert.ToInt32(horaFinal[0]))
                    {
                        if (!string.IsNullOrEmpty(rowcruce["1"].ToString()))//si tiene algo
                        {
                            FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                            fechahorariosemetralDto.dia = "1";
                            string resultado = "";
                            fechahorariosemetralDto.descripcion = getDetallecruce(rowcruce["1"].ToString()); ;
                            fechahorariosemetralDto.estado = true;
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
                            fechahorariosemetralDto.tipoOcupado = 1;
                            fechahorariosemetralDto.habilitado = true;
                            lstfechahorariosemetral.Add(fechahorariosemetralDto);
                        }
                        else
                        {
                            FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                            fechahorariosemetralDto.dia = "1";
                            fechahorariosemetralDto.descripcion = rowcruce["1"].ToString();
                            fechahorariosemetralDto.estado = false;
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
                            fechahorariosemetralDto.tipoOcupado = 0;
                            fechahorariosemetralDto.habilitado = false;
                            lstfechahorariosemetral.Add(fechahorariosemetralDto);
                        }


                        if (!string.IsNullOrEmpty(rowcruce["2"].ToString()))
                        {
                            FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                            fechahorariosemetralDto.dia = "2";
                            fechahorariosemetralDto.descripcion = getDetallecruce(rowcruce["2"].ToString());
                            fechahorariosemetralDto.estado = true;
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
                            fechahorariosemetralDto.tipoOcupado = 1;
                            fechahorariosemetralDto.habilitado = true;
                            lstfechahorariosemetral.Add(fechahorariosemetralDto);

                        }
                        else
                        {
                            FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                            fechahorariosemetralDto.dia = "2";
                            fechahorariosemetralDto.descripcion = rowcruce["2"].ToString();
                            fechahorariosemetralDto.estado = false;
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
                            fechahorariosemetralDto.tipoOcupado = 0;
                            fechahorariosemetralDto.habilitado = false;
                            lstfechahorariosemetral.Add(fechahorariosemetralDto);
                        }

                        if (!string.IsNullOrEmpty(rowcruce["3"].ToString()))
                        {
                            FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                            fechahorariosemetralDto.dia = "3";
                            fechahorariosemetralDto.descripcion = getDetallecruce(rowcruce["3"].ToString());
                            fechahorariosemetralDto.estado = true;
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
                            fechahorariosemetralDto.tipoOcupado = 1;
                            fechahorariosemetralDto.habilitado = true;
                            lstfechahorariosemetral.Add(fechahorariosemetralDto);


                        }
                        else
                        {
                            FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                            fechahorariosemetralDto.dia = "3";
                            fechahorariosemetralDto.descripcion = rowcruce["3"].ToString();
                            fechahorariosemetralDto.estado = false;
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
                            fechahorariosemetralDto.tipoOcupado = 0;
                            fechahorariosemetralDto.habilitado = false;
                            lstfechahorariosemetral.Add(fechahorariosemetralDto);

                        }

                        if (!string.IsNullOrEmpty(rowcruce["4"].ToString()))
                        {
                            FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                            fechahorariosemetralDto.dia = "4";
                            fechahorariosemetralDto.descripcion = getDetallecruce(rowcruce["4"].ToString());
                            fechahorariosemetralDto.estado = true;
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
                            fechahorariosemetralDto.tipoOcupado = 1;
                            fechahorariosemetralDto.habilitado = true;
                            lstfechahorariosemetral.Add(fechahorariosemetralDto);

                        }
                        else
                        {
                            FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                            fechahorariosemetralDto.dia = "4";
                            fechahorariosemetralDto.descripcion = rowcruce["4"].ToString();
                            fechahorariosemetralDto.estado = false;
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
                            fechahorariosemetralDto.tipoOcupado = 0;
                            fechahorariosemetralDto.habilitado = false;
                            lstfechahorariosemetral.Add(fechahorariosemetralDto);
                        }
                        if (!string.IsNullOrEmpty(rowcruce["5"].ToString()))
                        {
                            FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                            fechahorariosemetralDto.dia = "5";
                            fechahorariosemetralDto.descripcion = getDetallecruce(rowcruce["5"].ToString());
                            fechahorariosemetralDto.estado = true;
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
                            fechahorariosemetralDto.tipoOcupado = 1;
                            fechahorariosemetralDto.habilitado = true;

                            lstfechahorariosemetral.Add(fechahorariosemetralDto);

                        }
                        else
                        {
                            FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                            fechahorariosemetralDto.dia = "5";
                            fechahorariosemetralDto.descripcion = rowcruce["5"].ToString();
                            fechahorariosemetralDto.estado = false;
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
                            fechahorariosemetralDto.tipoOcupado = 0;
                            fechahorariosemetralDto.habilitado = false;
                            lstfechahorariosemetral.Add(fechahorariosemetralDto);

                        }
                        if (!string.IsNullOrEmpty(rowcruce["6"].ToString()))
                        {
                            FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                            fechahorariosemetralDto.dia = "6";
                            fechahorariosemetralDto.descripcion = getDetallecruce(rowcruce["6"].ToString());
                            fechahorariosemetralDto.estado = true;
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
                            fechahorariosemetralDto.tipoOcupado = 1;
                            fechahorariosemetralDto.habilitado = true;
                            lstfechahorariosemetral.Add(fechahorariosemetralDto);

                        }
                        else
                        {
                            FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                            fechahorariosemetralDto.dia = "6";
                            fechahorariosemetralDto.descripcion = rowcruce["6"].ToString();
                            fechahorariosemetralDto.estado = false;
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
                            fechahorariosemetralDto.tipoOcupado = 0;
                            fechahorariosemetralDto.habilitado = false;
                            lstfechahorariosemetral.Add(fechahorariosemetralDto);

                        }

                        if (!string.IsNullOrEmpty(rowcruce["7"].ToString()))
                        {
                            FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                            fechahorariosemetralDto.dia = "7";
                            fechahorariosemetralDto.descripcion = getDetallecruce(rowcruce["7"].ToString());
                            fechahorariosemetralDto.estado = true;
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
                            fechahorariosemetralDto.tipoOcupado = 1;
                            fechahorariosemetralDto.habilitado = true;
                            lstfechahorariosemetral.Add(fechahorariosemetralDto);

                        }
                        else
                        {
                            FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                            fechahorariosemetralDto.dia = "7";
                            fechahorariosemetralDto.descripcion = rowcruce["7"].ToString();
                            fechahorariosemetralDto.estado = false;
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
                            fechahorariosemetralDto.tipoOcupado = 0;
                            fechahorariosemetralDto.habilitado = false;
                            lstfechahorariosemetral.Add(fechahorariosemetralDto);

                        }

                    }
                }
            }
            List<FechasHorarioSemetral> lstcontenedordia = new List<FechasHorarioSemetral>();
            HorarioSemestralDto contenedorhoras = new HorarioSemestralDto();
            foreach (DataRow rowhora in ds_horas.Tables[0].Rows)
            {

                foreach (FechasHorarioSemetral rowdia in lstfechahorariosemetral)
                {
                    if (rowhora["H_I_F"].ToString() == rowdia.horaIF)
                    {

                        lstcontenedordia.Add(rowdia);
                        contenedorhoras = new HorarioSemestralDto();
                    }
                }
                contenedorhoras.horaIF = rowhora["H_I_F"].ToString();
                contenedorhoras.dias = lstcontenedordia;
                lstcontenedorhoras.Add(contenedorhoras);
                lstcontenedordia = new List<FechasHorarioSemetral>();
            }


            if (tipohorario == "E")
            {
                DataSet ds_planificacion = Conexion.BuscarZEUS_ds("horario_Temp a\r\ninner join PLANIFICACION_TEMP b\r\non a.ID_PLAN_TEMP = b.ID_PLAN_TEMP", "a.*", "where b.ID_SOLICITUD=" + idSolicitud);
                foreach (HorarioSemestralDto rowhoras in lstcontenedorhoras)
                {
                    foreach (DataRow rowdia in ds_planificacion.Tables[0].Rows)
                    {
                        string[] horaI = rowdia["HORA_INI"].ToString().Split(":");
                        string[] horaF = rowdia["HORA_FIN"].ToString().Split(":");
                        string hora = horaI[0] + ":" + horaI[1] + " - " + horaF[0] + ":" + horaF[1];
                        if (hora == rowhoras.horaIF)
                        {

                            foreach (FechasHorarioSemetral rowdiaplan in rowhoras.dias)
                            {
                                string dia = rowdia["ID_DIA"].ToString();
                                if (Convert.ToInt32(rowdia["ID_DIA"]) == Convert.ToInt32(rowdiaplan.dia))
                                {
                                    //var diaObject = rowdiaplan.Where(x => x.dia == rowdiaplan.dia).FirstOrDefault();
                                    if (rowdiaplan != null)
                                    {
                                        if (string.IsNullOrEmpty(rowdiaplan.descripcion))
                                        {
                                            rowdiaplan.estado = false;
                                        }
                                        else
                                        {
                                            rowdiaplan.descripcion = "";
                                            rowdiaplan.tipoOcupado = 2;
                                            rowdiaplan.estado = true;
                                            rowdiaplan.habilitado = false;
                                        }

                                    }
                                }

                            }
                        }
                    }
                }
            }
            return lstcontenedorhoras;
        }

        public bool EditSolicitudEstado(SolicitudDto solicitudDto, int idSolicitud)
        {
            bool response = false;

            response = Conexion.ActualizarZeus("SOLICITUD", "ID_ESTADO = " + solicitudDto.IdEstado + 
                                        ", OBSERVACION = '" + solicitudDto.Observacion + "'", " Where ID_SOLICITUD = " + idSolicitud);

            return response;
        }


        public bool EditSolicitudEmpleadoEstado(SolicitudEmpleadoDto solicitudEmpleadoDto, int idEmpleadoN)
        {
            bool response = false;

            response = Conexion.ActualizarZeus("EMPLEADO_TEMP_NUEVO", "ID_ESTADO = " + solicitudEmpleadoDto.IdEstado +
                                        ", OBSERVACION = '" + solicitudEmpleadoDto.Observacion + "'", " Where ID_EMP_NUEVO = " + idEmpleadoN);

            return response;
        }

        public bool SaveSolicitudPlanEmp(List<SolicitudDto> lstSolicitudDto, int idEmpleadoNuevo)
        {
            bool response = false;
            string ds_planTemp = "";
            string ds_solicitud = "";
            

            try 
            {
                //Eliminar
                ds_planTemp = Conexion.deleteZeus("PLANIFICACION_TEMP", "ID_SOLICITUD IN (SELECT ID_SOLICITUD FROM SOLICITUD WHERE ID_EMP_TEMP_N= " + idEmpleadoNuevo + ")");
                ds_solicitud = Conexion.deleteZeus("SOLICITUD", "ID_EMP_TEMP_N=" + idEmpleadoNuevo);                
            }
            catch
            {

            }

            //if (ds_planTemp == "1" && ds_solicitud == "1")
            //{ 
                foreach (SolicitudDto solicitudDto in lstSolicitudDto)
                {
                    if (solicitudDto.IdSolicitud == 0)
                    {
                    solicitudDto.FechaSolicitud = DateTime.Now;
                    string fechaSolicitud = solicitudDto.FechaSolicitud != null ? "'" + Convert.ToDateTime(solicitudDto.FechaSolicitud).ToString("yyyy-MM-dd") + "'" : "null";
                    //string fechaCrea = solicitudDto.FC != null ? "'" + Convert.ToDateTime(solicitudDto.FC).ToString("yyyy-MM-dd") + "'" : "null";
                    //string fechaActualiza = solicitudDto.FA != null ? "'" + Convert.ToDateTime(solicitudDto.FA).ToString("yyyy-MM-dd") + "'" : "null";
                    //solicitudDto.FC = DateTime.Now;
                    response = Conexion.InsertarZeusCore("SOLICITUD", "TIPO_SOLICITUD, FECHA_SOLICITUD, ID_ASOCIADO, ID_EMP_TEMP_N, ID_ESTADO, MOTIVO, OBSERVACION,UC,FC",
                                                   "'" + solicitudDto.TipoSolicitud + "'," + fechaSolicitud + "," + solicitudDto.IdAsociado + "," + solicitudDto.IdEmpTempN + "," +
                                                   solicitudDto.IdEstado + ",'" +
                                                   solicitudDto.Motivo + "','" + solicitudDto.Observacion + "','" + solicitudDto.UC + "',GETDATE()");
                    }
                }
            //}
            



            return response;
        }

    }
}
