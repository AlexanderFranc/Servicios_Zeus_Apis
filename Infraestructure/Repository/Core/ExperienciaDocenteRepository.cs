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
    public class ExperienciaDocenteRepository : GenericCoreRepository<ExperienciaDocente>, IExperienciaDocenteRepository
    {
        private readonly IFtpRepository _iftp;
        public ExperienciaDocenteRepository(ZeusCoreContext context, IFtpRepository ftp) : base(context)
        {
            _iftp = ftp;
        }
        public override async Task<IEnumerable<ExperienciaDocente>> GetAllAsync(bool noseguimineto = true)

        {
            var query = noseguimineto ? _context.ExperienciaDocentes.AsNoTracking()
                    : _context.ExperienciaDocentes;

            return await query


                                .ToListAsync();
        }

        public override async Task<ExperienciaDocente> GetByIdAsync(int idExperienciaDocente, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.ExperienciaDocentes.AsNoTracking()
                                   : _context.ExperienciaDocentes;

            return await query

                                .FirstOrDefaultAsync(x => x.IdExperienciaDocente == idExperienciaDocente);
        }

        public async Task<List<ExperienciaDocente>> GetByIdEmpleado(int idEmpl) => await
            _context.ExperienciaDocentes.Where(x => x.IdEmp == idEmpl).ToListAsync();

        public bool SaveInfoExperienciaDocente(ExperienciaDocenteDto infoDoc)
        {
            bool response = false;

                if (infoDoc.IdExperienciaDocente == 0)
                {
                string fechaInicioSQL = infoDoc.FechaInicio != null ? "'" + Convert.ToDateTime(infoDoc.FechaInicio).ToString("yyyy-MM-dd") + "'" : "null";
                string fechaFinSQL = infoDoc.FechaFin != null ? "'" + Convert.ToDateTime(infoDoc.FechaFin).ToString("yyyy-MM-dd") + "'" : "null";
                string idUnidadEducativaSQL = infoDoc.IdUnidadEducativa != null ? infoDoc.IdUnidadEducativa.ToString() : "null";

                response = Conexion.InsertarZeusCore("EXPERIENCIA_DOCENTE",
                                                    "ID_EMP, ID_UNIDAD_EDUCATIVA, INSTITUCION_SUPERIOR, INSTITUCION, FECHA_INICIO, FECHA_FIN, TITULAR, CERTIFICADO_LABORAL, CERTIFICADO_TITULARIDAD",
                                                    infoDoc.IdEmp + "," +
                                                    idUnidadEducativaSQL + "," +
                                                    Convert.ToInt32(infoDoc.InstitucionSuperior) + ",'" +
                                                    infoDoc.Institucion + "'," +
                                                    fechaInicioSQL + "," +
                                                    fechaFinSQL + "," +
                                                    Convert.ToInt32(infoDoc.Titular) + ",'" +
                                                    infoDoc.CertificadoLaboral + "','" +
                                                    infoDoc.CertificadoTitularidad + "'");

            }
            else
                {
                string idUnidadEducativaSQL = infoDoc.IdUnidadEducativa != null ? infoDoc.IdUnidadEducativa.ToString() : "null";
                string fechaInicioSQL = infoDoc.FechaInicio != null ? "'" + Convert.ToDateTime(infoDoc.FechaInicio).ToString("yyyy-MM-dd") + "'" : "null";
                string fechaFinSQL = infoDoc.FechaFin != null ? "'" + Convert.ToDateTime(infoDoc.FechaFin).ToString("yyyy-MM-dd") + "'" : "null";

                response = Conexion.ActualizarZeus("EXPERIENCIA_DOCENTE",
                                                   "ID_EMP = " + infoDoc.IdEmp +
                                                   ", ID_UNIDAD_EDUCATIVA = " + idUnidadEducativaSQL +
                                                   ", INSTITUCION_SUPERIOR = " + Convert.ToInt32(infoDoc.InstitucionSuperior) +
                                                   ", INSTITUCION = '" + infoDoc.Institucion +
                                                   "', FECHA_INICIO = " + fechaInicioSQL +
                                                   ", FECHA_FIN = " + fechaFinSQL +
                                                   ", TITULAR = " + Convert.ToInt32(infoDoc.Titular) +
                                                   ", CERTIFICADO_LABORAL = '" + infoDoc.CertificadoLaboral +
                                                   "', CERTIFICADO_TITULARIDAD = '" + infoDoc.CertificadoTitularidad + "'",
                                                   " Where ID_EXPERIENCIA_DOCENTE = " + infoDoc.IdExperienciaDocente);

            }

            return response;
        }

        public bool EditInfoExperienciaDocente(List<ExperienciaDocenteDto> lstExperienciaDocenteDto, int idInfoDoc)
        {
            bool response = false;
            foreach (var infoDoc in lstExperienciaDocenteDto)
            {
                response = Conexion.ActualizarZeus("EXPERIENCIA_DOCENTE", "ID_EMP = " + infoDoc.IdEmp +
                        ", ID_UNIDAD_EDUCATIVA = " + infoDoc.IdUnidadEducativa + ", INSTITUCION_SUPERIOR = " + infoDoc.InstitucionSuperior + ", INSTITUCION = " + infoDoc.Institucion +
                        "', FECHA_INICIO = '" + Convert.ToDateTime(infoDoc.FechaInicio).Date.ToString("yyyy-MM-dd") + "', FECHA_FIN = '" + Convert.ToDateTime(infoDoc.FechaFin).Date.ToString("yyyy-MM-dd") + "', TITULAR = '" + infoDoc.Titular +
                        " CERTIFICADO_LABORAL = " + infoDoc.CertificadoLaboral + " CERTIFICADO_TITULARIDAD = " + infoDoc.CertificadoTitularidad + "'", " Where ID_EXPERIENCIA_DOCENTE = " + infoDoc.IdExperienciaDocente);
            }
            return response;
        }
    }
}