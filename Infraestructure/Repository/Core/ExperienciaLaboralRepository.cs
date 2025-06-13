using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.Dtos.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
using Core.Interfaces.Ftp;

namespace Infraestructure.Repository.Core
{
    public class ExperienciaLaboralRepository : GenericCoreRepository<ExperienciaLaboral>, IExperienciaLaboralRepository
    {
        public ExperienciaLaboralRepository(ZeusCoreContext context) : base(context)
        {

        }

        private readonly IFtpRepository _iftp;
        public ExperienciaLaboralRepository(ZeusCoreContext context, IFtpRepository ftp) : base(context)
        {
            _iftp = ftp;
        }

        //public async Task<List<ExperienciaLaboral>> GetByDniAsync(string ced) => await
        //    _context.ExperienciaLaborals.Where(x => x.IdentificacionEmp == ced).ToListAsync();

        public override async Task<IEnumerable<ExperienciaLaboral>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.ExperienciaLaborals.AsNoTracking()
                    : _context.ExperienciaLaborals;

            return await query

                                .ToListAsync();

        }
        public override async Task<ExperienciaLaboral> GetByIdAsync(int idExperienciaLaboral, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.ExperienciaLaborals.AsNoTracking()
                                   : _context.ExperienciaLaborals;

            return await query

                                .FirstOrDefaultAsync(x => x.IdExperienciaLaboral == idExperienciaLaboral);
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

        //ID_EXPERIENCIA_LABORAL	ID_EMP	INSTITUCION	CARGO	FECHA_INICIO	FECHA_FIN	SUELDO	RAZON_SALIDA	CONTACTO	TELEFONO	CERTIFICADO

        public async Task<List<ExperienciaLaboral>> GetByIdEmpleado(int idEmpl) => await
            _context.ExperienciaLaborals.Where(x => x.IdEmp == idEmpl).ToListAsync();
        public bool SaveInfoExperienciaLaboral(ExperienciaLaboralDto infoLab)
        {
            bool response = false;

                if (infoLab.IdExperienciaLaboral == 0)
                {
                string fechaFinSQL = infoLab.FechaFin != null ? "'" + Convert.ToDateTime(infoLab.FechaFin).ToString("yyyy-MM-dd") + "'" : "null";
                string fechaInicioSQL = infoLab.FechaInicio != null ? "'" + Convert.ToDateTime(infoLab.FechaInicio).ToString("yyyy-MM-dd") + "'" : "null";

                response = Conexion.InsertarZeusCore("EXPERIENCIA_LABORAL", "ID_EMP, INSTITUCION, CARGO, FECHA_INICIO, FECHA_FIN, ACTUALMENTE,SUELDO, RAZON_SALIDA, CONTACTO, CARGO_CONTACTO, TELEFONO_CONTACTO, CERTIFICADO,UC,FC",
                                               infoLab.IdEmp + ",'" + infoLab.Institucion + "','" + infoLab.Cargo + "'," +
                                               fechaInicioSQL + "," +
                                               fechaFinSQL + "," +
                                               Convert.ToInt32(infoLab.Actualmente) + "," + (infoLab.Sueldo != null ? infoLab.Sueldo.ToString() : "null") + ",'" + infoLab.RazonSalida + "','" + infoLab.Contacto + "','" + infoLab.CargoContacto + "','" + infoLab.TelefonoContacto + "','" + infoLab.Certificado + "','" + infoLab.UC + "',GETDATE()" );
                }
                else
                {
                string fechaFinSQL = infoLab.FechaFin != null ? "'" + Convert.ToDateTime(infoLab.FechaFin).ToString("yyyy-MM-dd") + "'" : "null";
                string fechaInicioSQL = infoLab.FechaInicio != null ? "'" + Convert.ToDateTime(infoLab.FechaInicio).ToString("yyyy-MM-dd") + "'" : "null";

                response = Conexion.ActualizarZeus("EXPERIENCIA_LABORAL", "ID_EMP = " + infoLab.IdEmp + ", INSTITUCION = '" + infoLab.Institucion + "', CARGO = '" + infoLab.Cargo + "', FECHA_INICIO = " + fechaInicioSQL +
                                            ", FECHA_FIN = "+ fechaFinSQL + ", ACTUALMENTE = " +Convert.ToInt32(infoLab.Actualmente) + ", SUELDO = " + (infoLab.Sueldo != null ? infoLab.Sueldo.ToString() : "null") + ", RAZON_SALIDA = '" + infoLab.RazonSalida +"', CONTACTO = '" + infoLab.Contacto + "', CARGO_CONTACTO = '" + infoLab.CargoContacto +
                                            "', TELEFONO_CONTACTO =' " + infoLab.TelefonoContacto + "', CERTIFICADO = '" + infoLab.Certificado + "', FA=GETDATE(), UA='"+ infoLab.UA +"'", " Where ID_EXPERIENCIA_LABORAL = " + infoLab.IdExperienciaLaboral);


            }

            
            return response;
        }

        public bool EditInfoExperienciaLaboral(List<ExperienciaLaboralDto> lstExperienciaLaboralDto, int idInfoLab)
        {
            bool response = false;
            foreach (var infoLab in lstExperienciaLaboralDto)
            {
                response = Conexion.ActualizarZeus("EXPERIENCIA_LABORAL", "ID_EMP = " + infoLab.IdEmp + ", INSTITUCION = " + infoLab.Institucion + ", CARGO = " + infoLab.Cargo + "', FECHA_INICIO = '" + Convert.ToDateTime(infoLab.FechaInicio).Date.ToString("yyyy-MM-dd") +
                                            "', FECHA_FIN = '" + Convert.ToDateTime(infoLab.FechaFin).Date.ToString("yyyy-MM-dd") + "', ACTUALMENTE = '" + infoLab.Actualmente + "', SUELDO = '" + infoLab.Sueldo + ", RAZON_SALIDA = " + infoLab.RazonSalida + ", CONTACTO = " + infoLab.Contacto + ", CARGO_CONTACTO = " + infoLab.CargoContacto +
                                            ", TELEFONO_CONTACTO = " + infoLab.TelefonoContacto + ", CERTIFICADO = " + infoLab.Certificado + "', FA=GETDATE(), UA='"+ infoLab.UA + "'", " Where ID_EXPERIENCIA_LABORAL = " + infoLab.IdExperienciaLaboral);
            }
            return response;
        }
    }
}