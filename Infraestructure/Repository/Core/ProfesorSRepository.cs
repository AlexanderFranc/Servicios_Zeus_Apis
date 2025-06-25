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
    public class ProfesorSRepository : GenericCoreRepository<Profesor1>, IProfesorSRepository
    {
        public ProfesorSRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Profesor1>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.Profesors1.AsNoTracking()
                    : _context.Profesors1;

            return await query
                                .Include(x => x.IdPlanificacionNavigation)
                                .ToListAsync();
        }

        public override async Task<Profesor1> GetByIdAsync(int idcanton, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.Profesors1.AsNoTracking()
                                   : _context.Profesors1;

            return await query
                                .Include(a => a.IdPs)
                                .FirstOrDefaultAsync(x => x.IdPlanificacion == idcanton);
        }

        public async Task<List<Profesor1>> GetByIdPlanificacion(int idPlanificacion)
        {
            return await _context.Profesors1
                                    .Where(x => x.IdPlanificacion == idPlanificacion)
                                    .ToListAsync();
        }

        public override async Task<(int totalRegistros, IEnumerable<Profesor1> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.Profesors1.AsNoTracking()
                                  : _context.Profesors1;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.IdPlanificacion.ToString().Contains(search));
            }


            var totalRegistros = await query
                                        .CountAsync();

            var registros = await query

                                .Include(x => x.IdPlanificacionNavigation)
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            return (totalRegistros, registros);
        }

        public List<ProfesorSDto> GetAllByIdPlanificacion(int idPlanificacion)
        {
            ProfesorSDto profesorsDto;
            DateTime fInicio;
            DateTime fFin;
            List<ProfesorSDto> listprofesorsDto = new();
            var ds_profesors = Conexion.BuscarZEUS_ds("zeus_new.dbo.PROFESOR_s a inner join zeus_new.dbo.EMPLEADO b on a.dni_profesorc = b.IDENTIFICACION_EMP", "a.ID_PS,A.ID_PLANIFICACION,a.DNI_PROFESORC,b.APELLIDO_EMP +' ' +b.NOMBRES_EMP DOCENTE,a.FECHA_INICIO,a.FECHA_FIN,a.HORAS,a.TIPO,a.ACTIVO", "WHERE A.ID_PLANIFICACION=" + idPlanificacion + " order by fecha_inicio,fecha_fin");
            if (ds_profesors.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_profesors.Tables[0].Rows)
                {
                    profesorsDto = new();
                    profesorsDto.IdPs = Convert.ToInt32(row["ID_PS"].ToString());
                    profesorsDto.IdPlanificacion = Convert.ToInt32(row["ID_PLANIFICACION"].ToString());
                    profesorsDto.Docente = row["DOCENTE"].ToString() ?? string.Empty;
                    profesorsDto.DniProfesorc = row["DNI_PROFESORC"].ToString() ?? string.Empty;
                    fInicio = Convert.ToDateTime(row["FECHA_INICIO"].ToString());
                    fFin = Convert.ToDateTime(row["FECHA_FIN"].ToString());

                    profesorsDto.FechaInicio= DateOnly.FromDateTime(fInicio);
                    profesorsDto.FechaFin= DateOnly.FromDateTime(fFin);
                    //profesorsDto.FechaInicio = Convert.ToDateTime(row["FECHA_INICIO"].ToString());
                    //profesorsDto.FechaFin = Convert.ToDateTime(row["FECHA_FIN"].ToString());
                    profesorsDto.Horas = Convert.ToDecimal(row["HORAS"].ToString());
                    profesorsDto.Tipo = row["TIPO"].ToString();


                    listprofesorsDto.Add(profesorsDto);
                }
            }
            return listprofesorsDto;

        }

        public bool SaveProfesorS(ProfesorSDto profesorsDto)
        {
            bool response = false;
            //string fechaInicioSQL = profesorsDto.FechaInicio != null ? "'" + Convert.ToDateTime(idio.FechaEmision).ToString("yyyy-MM-dd") + "'" : "null";
            int activo = profesorsDto.Activo == true ? 1 : 0;

            //if (idio.IdIdioma == 0)
            //{
            response = Conexion.InsertarZeusCore("PROFESOR_S", "DNI_PROFESORC,ID_PLANIFICACION,FECHA_INICIO,FECHA_FIN,HORAS,TIPO,ACTIVO,UC,FC",
                                           "'" + profesorsDto.DniProfesorc + "'," + profesorsDto.IdPlanificacion + ",'" + profesorsDto.FechaInicio + "','" + profesorsDto.FechaFin + "','" +
                                           profesorsDto.Horas + "','" +
                                           profesorsDto.Tipo + "'," + activo + ",'" + profesorsDto.UC + "',GETDATE()");
            //}
            //else
            //{
            //    response = Conexion.ActualizarZeus("IDIOMA", "ID_EMP = " + idio.IdEmp + ", IDIOMA = '" + idio.Idioma1 + "', INSTITUCION = '" + idio.Institucion +
            //        "', NIVEL = '" + idio.Nivel + "', FECHA_EMISION = " + fechaInicioSQL +
            //        ", CERTIFICACION = " + Convert.ToInt32(idio.Certificacion) + ", CERTIFICADO = '" + idio.Certificado +
            //        "', FA=GETDATE(), UA='" + idio.UA + "'", " Where ID_IDIOMA = " + idio.IdIdioma);
            //}


            return response;
        }

        public bool SaveProfesorSList(List<ProfesorSDto> lstProfesorsDto, int idPlanificacion)
        {
            bool response = false;

            bool responseUpdate = false;
            string ds_profesors = "";

            try
            {
                //Eliminar
                ds_profesors = Conexion.deleteZeus("PROFESOR_S", "ID_PLANIFICACION=" + idPlanificacion);
            }
            catch
            {

            }

            foreach (ProfesorSDto profesorsDto in lstProfesorsDto)
            {
                int activo = profesorsDto.Activo == true ? 1 : 0;

                string fechaInicio = profesorsDto.FechaInicio != null ? "'" + profesorsDto.FechaInicio.ToDateTime(TimeOnly.MinValue).ToString("yyyy-MM-dd") + "'" : "null";
                string fechaFin = profesorsDto.FechaFin != null ? "'" + profesorsDto.FechaFin.ToDateTime(TimeOnly.MinValue).ToString("yyyy-MM-dd") + "'" : "null";
                response = Conexion.InsertarZeusCore("PROFESOR_S", "DNI_PROFESORC,ID_PLANIFICACION,FECHA_INICIO,FECHA_FIN,HORAS,TIPO,ACTIVO,UC,FC",
                                       "'" + profesorsDto.DniProfesorc + "'," + profesorsDto.IdPlanificacion + "," + fechaInicio + "," + fechaFin + ",'" +
                                       profesorsDto.Horas + "','" +
                                       profesorsDto.Tipo + "'," + activo + ",'" + profesorsDto.UC + "',GETDATE()");

            }

            if (response == true)
            {
                responseUpdate = Conexion.ActualizarZeus("PLANIFICACION", "PROFESOR_S = 1", " Where ID_PLANIFICACION = " + idPlanificacion);

            }

            return response;
        }

        public ResponseDto DeleteProfesorS(int idplanidicacion, string usuario)
        {
            ResponseDto response = new ResponseDto();

            //string ds_data = Conexion.deleteZeus("HORARIO", "ID_PLANIFICACION=" + idplanidicacion + " and ID_DIA=" + dia + " and HORA_INI='" + horaI + "' and HORA_FIN='" + horaF + "'");
            DataSet ds_profesorS = Conexion.ExecZeusCore("[EliminarProfesorS]", "'EP'," + idplanidicacion);

            if (ds_profesorS.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_profesorS.Tables[0].Rows)
                {
                    response.resultado = Convert.ToBoolean(row["RESULTADO"].ToString());
                    response.mensaje = row["MENSAJE"].ToString();
                }
            }
            else
            {
                response.resultado = false;
                response.mensaje = "ERROR";
            }

            return response;

        }
    }
}
