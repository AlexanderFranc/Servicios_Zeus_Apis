using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Core
{
    public class MateriasMatriculadasEstudianteRepository : IMateriasMatriculadasEstudianteRepository
    {


        public Task<IEnumerable<MateriasHorarioEstudianteDto>> GetMateriasHorarioEstudianteAC(string semestre,string malla, string codmateria, string identificacion)
        {
            List<MateriasHorarioEstudianteDto> materiasLst = new List<MateriasHorarioEstudianteDto>();

            DataSet ds = Conexion.ExecNavision("[sp_HorarioMateria]", "'HSE','" + semestre + "','" + malla + "','" + codmateria + "','"+identificacion+"'");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                MateriasHorarioEstudianteDto materiasMatriculadasEstudianteDto = new MateriasHorarioEstudianteDto
                {
                    IdPlanificacion = Convert.ToInt32(row["ID_PLANIFICACION"]),
                    CodigoPeriodo = row["CODIGO_PERIODO"].ToString(),
                    IdPeriodo = Convert.ToInt32(row["ID_PERIODO"]),
                    IdMalla = Convert.ToInt32(row["ID_MALLA"]),
                    CodigoCarrera = row["CODIGO_CARRERA"].ToString(),
                    CodigoPlanEstudioMalla = row["CODIGO_PLAN_ESTUDIO_MALLA"].ToString(),
                    ModPlan = row["MOD_PLAN"].ToString(),
                    CodigoMateria = row["CODIGO_MATERIA"].ToString(),
                    NombreMateria = row["NOMBRE_MATERIA"].ToString(),
                    NivelMateria = Convert.ToInt32(row["NIVEL_MATERIA"]),
                    DniProfesor = row["DNI_PROFESORC"].ToString(),
                    Profesor = row["PROFESOR"].ToString(),
                    Paralelo = row["PARALELO"].ToString(),
                    Cupo = Convert.ToInt32(row["CUPO"]),
                    Matriculados = Convert.ToInt32(row["MATRICULADOS"]),
                    Disponible = Convert.ToInt32(row["DISPONIBLE"]),
                    Habilitado = Convert.ToBoolean(row["HABILITADO"]),
                    IdTipoComponente = Convert.ToInt32(row["ID_TIPO_COMPONENTE"]),
                    CodigoSubtipoComponente = row["CODIGO_SUBTIPO_COMPONENTE"].ToString(),
                    CreditosMateria = Convert.ToDecimal(row["CREDITOS_MATERIA"]),
                    Lunes = row["LUNES"].ToString(),
                    Martes = row["MARTES"].ToString(),
                    Miercoles = row["MIERCOLES"].ToString(),
                    Jueves = row["JUEVES"].ToString(),
                    Viernes = row["VIERNES"].ToString(),
                    Sabado = row["SABADO"].ToString(),
                    Domingo = row["DOMINGO"].ToString(),
                    Seleccionado = Convert.ToBoolean(row["SELECCIONADO"])

                };
                materiasLst.Add(materiasMatriculadasEstudianteDto);
            }

            return Task.FromResult<IEnumerable<MateriasHorarioEstudianteDto>>(materiasLst);
        }

        public Task<IEnumerable<MateriasHorarioEstudianteDto>> GetMateriasHorarioEstudianteAPE(string semestre,string malla, string codmateria, string identificacion)
        {
            List<MateriasHorarioEstudianteDto> materiasLst = new List<MateriasHorarioEstudianteDto>();

            DataSet ds = Conexion.ExecNavision("[sp_HorarioMateria]", "'HSE','" + semestre + "','" + malla + "','" + codmateria + "','"+identificacion+"'");
            foreach (DataRow row in ds.Tables[1].Rows)
            {
                MateriasHorarioEstudianteDto materiasMatriculadasEstudianteDto = new MateriasHorarioEstudianteDto
                {
                    IdPlanificacion = Convert.ToInt32(row["ID_PLANIFICACION"]),
                    CodigoPeriodo = row["CODIGO_PERIODO"].ToString(),
                    IdPeriodo = Convert.ToInt32(row["ID_PERIODO"]),
                    IdMalla = Convert.ToInt32(row["ID_MALLA"]),
                    CodigoCarrera = row["CODIGO_CARRERA"].ToString(),
                    CodigoPlanEstudioMalla = row["CODIGO_PLAN_ESTUDIO_MALLA"].ToString(),
                    ModPlan = row["MOD_PLAN"].ToString(),
                    CodigoMateria = row["CODIGO_MATERIA"].ToString(),
                    NombreMateria = row["NOMBRE_MATERIA"].ToString(),
                    NivelMateria = Convert.ToInt32(row["NIVEL_MATERIA"]),
                    DniProfesor = row["DNI_PROFESORC"].ToString(),
                    Profesor = row["PROFESOR"].ToString(),
                    Paralelo = row["PARALELO"].ToString(),
                    Cupo = Convert.ToInt32(row["CUPO"]),
                    Matriculados = Convert.ToInt32(row["MATRICULADOS"]),
                    Disponible = Convert.ToInt32(row["DISPONIBLE"]),
                    Habilitado = Convert.ToBoolean(row["HABILITADO"]),
                    IdTipoComponente = Convert.ToInt32(row["ID_TIPO_COMPONENTE"]),
                    CodigoSubtipoComponente = row["CODIGO_SUBTIPO_COMPONENTE"].ToString(),
                    CreditosMateria = Convert.ToDecimal(row["CREDITOS_MATERIA"]),
                    Lunes = row["LUNES"].ToString(),
                    Martes = row["MARTES"].ToString(),
                    Miercoles = row["MIERCOLES"].ToString(),
                    Jueves = row["JUEVES"].ToString(),
                    Viernes = row["VIERNES"].ToString(),
                    Sabado = row["SABADO"].ToString(),
                    Seleccionado = Convert.ToBoolean(row["SELECCIONADO"])
                };
                materiasLst.Add(materiasMatriculadasEstudianteDto);
            }

            return Task.FromResult<IEnumerable<MateriasHorarioEstudianteDto>>(materiasLst);
        }

        public Task<IEnumerable<MateriasMatriculadasEstudianteDto>> GetMateriasMatriculadasEstudiante(string semestre, string identificacion, string codcarr)
        {
            List<MateriasMatriculadasEstudianteDto> materiasLst = new List<MateriasMatriculadasEstudianteDto>();

            DataSet ds = Conexion.ExecNavision("sp_MateriasMatriculadasEstudiante", "'MM','" + semestre + "','" + identificacion + "','" + codcarr + "'");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                MateriasMatriculadasEstudianteDto materiasMatriculadasEstudianteDto = new MateriasMatriculadasEstudianteDto
                {
                    Name = row["Name"].ToString(),
                    Cedula= row["Cedula"].ToString(),
                    NombreModalidadPe= row["NOMBRE_MODALIDAD_PE"].ToString(),
                    Mallau = row["Mallau+"].ToString(),
                    CodCli = row["CodCli"].ToString(),
                    CodAlumno = row["CodAlumno"].ToString(),
                    CodCentro = row["CodCentro"].ToString(),
                    Nivel = Convert.ToInt32(row["Nivel"]),
                    CodAsignatura = row["CodAsignatura"].ToString(),
                    NombreAsignatura = row["Nombre Asignatura"].ToString(),
                    CodEquivalente = row["CodEquivalente"].ToString(),
                    Creditos = Convert.ToDecimal(row["Creditos"]),
                    Seccion = row["Seccion"].ToString(),
                    Estado = row["Estado"].ToString(),

                    Fecha = Convert.ToDateTime(row["Fecha"]),
                    NFactura = row["NFactura"].ToString(),
                    MarcarEliminar = Convert.ToBoolean(row["MarcarEliminar"]),
                    Marcada = Convert.ToBoolean(row["Marcada"]),
                    Semestre = row["Semestre"].ToString(),
                    UserInsert = row["USERINSERT"].ToString(),

                    NFacturaBorrado = row["NFacturaBorrado"].ToString(),
                    Origen = row["Origen"].ToString(),
                    UserFactura = row["USERFACTURA"].ToString(),
                    NuevoCursoNAV = row["NuevoCursoNAV"].ToString(),
                    AlumnoAntiguo = Convert.ToBoolean(row["AlumnoAntiguo"]),
                    Tipo = row["Tipo"].ToString()
                };
                materiasLst.Add(materiasMatriculadasEstudianteDto);
            }

            return Task.FromResult<IEnumerable<MateriasMatriculadasEstudianteDto>>(materiasLst);
        }

        public  Task<IEnumerable<CruceHorarioEstudianteDto>> GetCruceHorarioEstudiante(ParametroEstudianteMatriculadoDto data)
        {
            List<CruceHorarioEstudianteDto> materiasLst = new List<CruceHorarioEstudianteDto>();

            DataSet ds = Conexion.ExecNavision("sp_ValidaHorarioEstudiante",
                "'VHC','" + data.Semestre + "','" + data.CodCli + "','" + data.IdPlanificacionAc + "'," +
                (data.IdPlanificacionApe == null ? "null" : "'" + data.IdPlanificacionApe + "'") + ",'" + data.CodMateria + "'");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                CruceHorarioEstudianteDto materiasMatriculadasEstudianteDto = new CruceHorarioEstudianteDto
                {
		

                    Semestre = row["Semestre"].ToString(),
                    CodCli = row["CodCli"].ToString(),
                    CodMateria = row["CodAsignatura"].ToString(),
                    Materia = row["Nombre Asignatura"].ToString(),
                    Seccion = Convert.ToInt32(row["Seccion"]),
                    Nivel = Convert.ToInt32(row["Nivel"]),
                    CodPlan = row["CodPlan"].ToString(),
                    CodMalla = row["CodMalla"].ToString(),
                    Creditos = Convert.ToDouble(row["Creditos"])

                };
                materiasLst.Add(materiasMatriculadasEstudianteDto);
            }

            return Task.FromResult<IEnumerable<CruceHorarioEstudianteDto>>(materiasLst);


        }

        public Task<bool> CambiarParalelo(ParametrosActualizarParaleloDto data)
        {
            //'AP','2025-3','1727876656','QMED','MEDBASM1EM',16153,15956

            try
            {
                DataSet ds = Conexion.ExecNavision("[sp_ActualizaParaleloEstud]",
                    "'AP','" + data.Semestre + "','" + data.Identificacion + "','" + data.CodCarr + "','" +
                    data.CodMateria + "','" + data.IdPlaniAC + "'," +
                    (data.IdPlaniAPE == null ? "null" : "'" + data.IdPlaniAPE + "'"));
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                return Task.FromResult(false);
            }
        }
    }
}
