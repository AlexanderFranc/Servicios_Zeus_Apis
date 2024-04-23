using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Core.Interfaces.Ftp;
using Infraestructure.Configuration.Conexion.LoginDB;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;


namespace Infraestructure.Repository.Core
{
    public class CapacitacionRepository : GenericCoreRepository<Capacitacion>, ICapacitacionRepository
    {
        private readonly IFtpRepository _iftp;
        public CapacitacionRepository(ZeusCoreContext context, IFtpRepository ftp) : base(context)
        {
            _iftp = ftp;
        }

        public async Task<List<Capacitacion>> GetByIdEmpleado(int idEmpl) => await
            _context.Capacitacions.Where(x => x.IdEmp == idEmpl).ToListAsync();

        public override async Task<IEnumerable<Capacitacion>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.Capacitacions.AsNoTracking()
                    : _context.Capacitacions;

            return await query

                                .ToListAsync();

        }
        public override async Task<Capacitacion> GetByIdAsync(int idCapacitacion, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.Capacitacions.AsNoTracking()
                                   : _context.Capacitacions;

            return await query

                                .FirstOrDefaultAsync(x => x.IdCapacitacion == idCapacitacion);
        }

        public bool SaveCapacitaciones(CapacitacionDto capa)
        {
            bool response = false;
            string fechaInicioSQL = capa.FechaInicio != null ? "'" + Convert.ToDateTime(capa.FechaInicio).ToString("yyyy-MM-dd") + "'" : "null";
            string fechaFinSQL = capa.FechaFin != null ? "'" + Convert.ToDateTime(capa.FechaFin).ToString("yyyy-MM-dd") + "'" : "null";

            if (capa.IdCapacitacion == 0)
                {
                    response = Conexion.InsertarZeusCore("CAPACITACION", "ID_EMP, ID_TIPO_APROBACION, ID_TIPO_ACTIVIDAD, INSTITUCION, TITULO, FECHA_INICIO, FECHA_FIN, DURACION, CERTIFICADO",
                                               capa.IdEmp + "," + (capa.IdTipoAprobacion.HasValue ? capa.IdTipoAprobacion.ToString() : "null") + "," + (capa.IdTipoActividad.HasValue ? capa.IdTipoActividad.ToString() : "null") + ",'" + capa.Institucion + "','" + capa.Titulo + "'," +
                                               fechaInicioSQL+"," + fechaFinSQL+ "," +
                                               (capa.Duracion.HasValue ? capa.Duracion.ToString() : "null") + ",'" + capa.Certificado + "'");
                }
                else
                {
                    response = Conexion.ActualizarZeus("CAPACITACION", "ID_EMP = " + capa.IdEmp + ", ID_TIPO_APROBACION = " + (capa.IdTipoAprobacion.HasValue ? capa.IdTipoAprobacion.ToString() : "null") + ", ID_TIPO_ACTIVIDAD = " + (capa.IdTipoActividad.HasValue ? capa.IdTipoActividad.ToString() : "null") +
                                            ", INSTITUCION = '" + capa.Institucion + "', TITULO = '" + capa.Titulo + "', FECHA_INICIO = " + fechaInicioSQL +
                                            ", FECHA_FIN = "+ fechaFinSQL + ", DURACION = " + (capa.Duracion.HasValue ? capa.Duracion.ToString() : "null") + ", CERTIFICADO = '" + capa.Certificado +
                                            "'", " Where ID_CAPACITACION = " + capa.IdCapacitacion);
                }

            
            return response;
        }
        public bool EditCapacitaciones(CapacitacionDto capa, int idCapacitacion)
        {
            bool response = false;

                response = Conexion.ActualizarZeus("CAPACITACION", "ID_EMP = " + capa.IdEmp + ", ID_TIPO_APROBACION = " + capa.IdTipoAprobacion + ", ID_TIPO_ACTIVIDAD = " + capa.IdTipoActividad +
                                            ", INSTITUCION = '" + capa.Institucion + "', TITULO = '" + capa.Titulo + "', FECHA_INICIO = '" + Convert.ToDateTime(capa.FechaInicio).Date.ToString("yyyy-MM-dd") +
                                            "', FECHA_FIN = '" + Convert.ToDateTime(capa.FechaFin).Date.ToString("yyyy-MM-dd") + "', DURACION = " + capa.Duracion + ", CERTIFICADO = '" + capa.Certificado +
                                            "'", " Where ID_CAPACITACION = " + idCapacitacion);
            
            return response;
        }
        //public override async Task<(int totalRegistros, IEnumerable<ExperienciaLaboral> registros)> GetAllAsync(
        //    int pageIndex, int pageSize, string search, bool noseguimiento = true)
        //{

        //    var query = noseguimiento ? _context.ExperienciaLaborals.AsNoTracking()
        //                          : _context.ExperienciaLaborals;

        //    if (!String.IsNullOrEmpty(search))
        //    {
        //        query = query.Where(p => p.IdExperienciaLaboral.ToLower().Contains(search));
        //    }


        //    var totalRegistros = await query
        //                                .CountAsync();

        //    var registros = await query


        //                            .Skip((pageIndex - 1) * pageSize)
        //                            .Take(pageSize)
        //                            .ToListAsync();

        //    return (totalRegistros, registros);
        //}

    }
}