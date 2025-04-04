using System.Data;
using System.Linq.Expressions;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class EmpleadoRepository : GenericCoreRepository<Empleado>, IEmpleadoRepository
    {
        public EmpleadoRepository(ZeusCoreContext context) : base(context)
        {

        }
        public async Task<Empleado> GetByDniAsync(string ced) => await
            _context.Empleados.Include(x => x.InfoAcademicaNews).ThenInclude(x => x.IdNivelAcademicoNavigation).Include(x => x.IdTipoDocumentoNavigation)
            .Include(x => x.IdPaisNacNavigation)
            .Where(x => x.IdentificacionEmp == ced).FirstOrDefaultAsync();

        public async Task<Empleado> GetByCedulaAsync(string ced) => await
            _context.Empleados.Where(x => x.IdentificacionEmp == ced).FirstOrDefaultAsync();

        public override async Task<IEnumerable<Empleado>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.Empleados.AsNoTracking()
                    : _context.Empleados;

            return await query
                                .Include(x => x.IdCantonNavigation)
                                .Include(x => x.IdEstadoEmpNavigation)
                                .Include(x => x.IdEtniaNavigation)
                                .Include(x => x.IdPaisNacNavigation)
                                .Include(x => x.IdPaisNavigation)
                                .Include(x => x.IdParroquiaNavigation)
                                .Include(x => x.IdProvinciaNavigation)
                                .Include(x => x.IdTipoDiscapacidadNavigation)
                                .Include(x => x.IdTipoDocumentoNavigation)
                                .Include(x => x.IdTipoEmpNavigation)
                                .Include(x => x.IdUnidadNavigation)
                                .ToListAsync();
        }
        public async Task<List<EmpleadoDto>> GetEmployees()
        {
            EmpleadoDto empleadoDto = new EmpleadoDto();
            List<EmpleadoDto> listEmpleados = new();
            DataSet ds_empl = Conexion.BuscarZEUS_ds(
                "EMPLEADO emp\r\ninner join PROFESOR prof on emp.IDENTIFICACION_EMP = prof.DNI_PROFESORC",
                "IDENTIFICACION_EMP, NOMBRES_EMP, APELLIDO_EMP",
                "where emp.ID_TIPO_EMP in (1,4,5) AND activo_emp=1 ORDER BY APELLIDO_EMP"
                );
            if (ds_empl.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_empl.Tables[0].Rows)
                {
                    empleadoDto.IdentificacionEmp = row["IDENTIFICACION_EMP"].ToString();
                    empleadoDto.NombresEmp = row["NOMBRES_EMP"].ToString();
                    empleadoDto.ApellidoEmp = row["APELLIDO_EMP"].ToString();
                    listEmpleados.Add(empleadoDto);
                    empleadoDto = new EmpleadoDto();
                }
            }
            return listEmpleados;
        }
        public async Task<List<EmpleadoDto>> ListarEmpleadosInactivos()
        {
            EmpleadoDto empleadoDto = new EmpleadoDto();
            List<EmpleadoDto> listEmpleados = new();
            DataSet ds_empl = Conexion.BuscarZEUS_ds(
                "EMPLEADO emp",
                "IDENTIFICACION_EMP, NOMBRES_EMP, APELLIDO_EMP, CORREO_EMP, CORREO_INST, CELULAR_EMP,ID_TIPO_DOCUMENTO",
                "where emp.ID_TIPO_EMP = 1 AND activo_emp=0 ORDER BY APELLIDO_EMP"
                );
            if (ds_empl.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_empl.Tables[0].Rows)
                {
                    empleadoDto.IdentificacionEmp = row["IDENTIFICACION_EMP"].ToString();
                    empleadoDto.NombresEmp = row["NOMBRES_EMP"].ToString();
                    empleadoDto.ApellidoEmp = row["APELLIDO_EMP"].ToString();
                    empleadoDto.CorreoEmp = row["CORREO_EMP"].ToString();
                    empleadoDto.CorreoInst = row["CORREO_INST"].ToString();
                    empleadoDto.CelularEmp = row["CELULAR_EMP"].ToString();
                    empleadoDto.IdTipoDocumento = Convert.ToInt32(row["ID_TIPO_DOCUMENTO"].ToString());
                    listEmpleados.Add(empleadoDto);
                    empleadoDto = new EmpleadoDto();
                }
            }
            return listEmpleados;
        }

        public override async Task<Empleado> GetByIdAsync(int idemp, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.Empleados.AsNoTracking()
                                   : _context.Empleados;

            return await query
                                .Include(x => x.IdCantonNavigation)
                                .Include(x => x.IdEstadoEmpNavigation)
                                .Include(x => x.IdEtniaNavigation)
                                .Include(x => x.IdPaisNacNavigation)
                                .Include(x => x.IdPaisNavigation)
                                .Include(x => x.IdParroquiaNavigation)
                                .Include(x => x.IdProvinciaNavigation)
                                .Include(x => x.IdTipoDiscapacidadNavigation)
                                .Include(x => x.IdTipoDocumentoNavigation)
                                .Include(x => x.IdTipoEmpNavigation)
                                .Include(x => x.IdUnidadNavigation)
                                .FirstOrDefaultAsync(x => x.IdEmp == idemp);
        }

        public override async Task<(int totalRegistros, IEnumerable<Empleado> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.Empleados.AsNoTracking()
                                  : _context.Empleados;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.IdentificacionEmp.ToLower().Contains(search));
            }


            var totalRegistros = await query
                                        .CountAsync();

            var registros = await query

                                .Include(x => x.IdCantonNavigation)
                                .Include(x => x.IdEstadoEmpNavigation)
                                .Include(x => x.IdEtniaNavigation)
                                .Include(x => x.IdPaisNacNavigation)
                                .Include(x => x.IdPaisNavigation)
                                .Include(x => x.IdParroquiaNavigation)
                                .Include(x => x.IdProvinciaNavigation)
                                .Include(x => x.IdTipoDiscapacidadNavigation)
                                .Include(x => x.IdTipoDocumentoNavigation)
                                .Include(x => x.IdTipoEmpNavigation)
                                .Include(x => x.IdUnidadNavigation)
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            return (totalRegistros, registros);
        }

        public List<EmpleadoDto> GetAllEmpleado()
        {
            EmpleadoDto empleado = new EmpleadoDto();
            List<EmpleadoDto> listaEmpleado = new List<EmpleadoDto>();
            DataSet ds_empleado = Conexion.BuscarZEUS_ds("EMPLEADO", "ID_EMP, NOMBRES_EMP, APELLIDO_EMP, IDENTIFICACION_EMP", "");
            if (ds_empleado.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_empleado.Tables[0].Rows)
                {
                    empleado.IdEmp = Convert.ToInt32(row["ID_EMP"].ToString());
                    empleado.NombresEmp = row["NOMBRES_EMP"].ToString();
                    empleado.ApellidoEmp = row["APELLIDO_EMP"].ToString();
                    empleado.IdentificacionEmp = row["IDENTIFICACION_EMP"].ToString();
                    //empleado.EdadEmp = Convert.ToInt32(row["EDAD_EMP"].ToString());

                    listaEmpleado.Add(empleado);
                    empleado = new EmpleadoDto();
                }
            }
            return listaEmpleado;
        }

        public async Task<IEnumerable<Empleado>> getDocentesPlanificacion()
        {
            var query = await (from a in _context.Empleados
                               join b in _context.Planificacions on a.IdentificacionEmp equals b.DniProfesorc
                               where a.ActivoEmp == true && a.NombresEmp != "" && a.ApellidoEmp != ""
                               select new Empleado
                               {
                                   NombresEmp = a.ApellidoEmp.Trim() + " " + a.NombresEmp.Trim(),
                                   IdentificacionEmp = a.IdentificacionEmp,
                               }

                ).Distinct().ToListAsync();
            return query;
        }

        public async Task<IEnumerable<Empleado>> getDocentesPlanificacionByFacu(int id)
        {
            var query = await (from a in _context.Empleados
                               join b in _context.Planificacions on a.IdentificacionEmp equals b.DniProfesorc
                               join c in _context.Mallas on b.IdMalla equals c.IdMalla
                               join d in _context.PlanEstudios on c.IdPlanEstudio equals d.IdPlanEstudio
                               join e in _context.Carreras on d.IdCarrera equals e.IdCarrera
                               join f in _context.Facultads on e.IdFacultad equals f.IdFacultad
                               where a.ActivoEmp == true && a.NombresEmp != "" && a.ApellidoEmp != "" && f.IdFacultad == id
                               select new Empleado
                               {
                                   NombresEmp = a.ApellidoEmp.Trim() + " " + a.NombresEmp.Trim(),
                                   IdentificacionEmp = a.IdentificacionEmp,
                               }

                             ).Distinct().ToListAsync();
            return query;

        }

        public async Task<IEnumerable<Empleado>> getDocentesPlanificacionByCarr(int id)
        {
            var query = await (from a in _context.Empleados
                               join b in _context.Planificacions on a.IdentificacionEmp equals b.DniProfesorc
                               join c in _context.Mallas on b.IdMalla equals c.IdMalla
                               join d in _context.PlanEstudios on c.IdPlanEstudio equals d.IdPlanEstudio
                               join e in _context.Carreras on d.IdCarrera equals e.IdCarrera
                               join f in _context.Facultads on e.IdFacultad equals f.IdFacultad
                               where a.ActivoEmp == true && a.NombresEmp != "" && a.ApellidoEmp != "" && e.IdCarrera == id
                               select new Empleado
                               {
                                   NombresEmp = a.ApellidoEmp.Trim() + " " + a.NombresEmp.Trim(),
                                   IdentificacionEmp = a.IdentificacionEmp,
                               }

                                    ).Distinct().ToListAsync();
            return query;

        }
        public bool DatosPersonales(EmpleadoDatosPersonalesDto empDto)
        {
            try
            {
                bool response;
                int aceptaPd = empDto.AceptaPd ? 1 : 0;
                response = Conexion.ActualizarZeus("EMPLEADO", "ACEPTA_PD = " + aceptaPd + ", FECHA_ACEPTA_PD=GETDATE()", " Where IDENTIFICACION_EMP = '" + empDto.IdentificacionEmp + "'");
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public bool AceptadoDatosPersonales(string identificacionEmp)
        {
            try
            {
                DataSet ds_empleado = Conexion.BuscarZEUS_ds("EMPLEADO", "ACEPTA_PD", "where IDENTIFICACION_EMP ='" + identificacionEmp + "'");
                if (ds_empleado.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds_empleado.Tables[0].Rows)
                    {
                        var q = row["ACEPTA_PD"].ToString();
                        if (row["ACEPTA_PD"].ToString() == null)
                        {
                            return false;
                        }
                        else if (string.IsNullOrEmpty(row["ACEPTA_PD"].ToString()))
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    throw new Exception("el empleado no existe.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar el proceso, " + ex.Message);
            }
        }

    }
}
