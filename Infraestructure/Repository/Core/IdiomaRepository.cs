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
    public class IdiomaRepository : GenericCoreRepository<Idioma>, IIdiomaRepository
    {
        private readonly IFtpRepository _iftp;
        public IdiomaRepository(ZeusCoreContext context, IFtpRepository ftp) : base(context)
        {
            _iftp = ftp;
        }
        //public async Task<List<ExperienciaLaboral>> GetByDniAsync(string ced) => await
        //    _context.ExperienciaLaborals.Where(x => x.IdentificacionEmp == ced).ToListAsync();
        public override async Task<IEnumerable<Idioma>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.Idiomas.AsNoTracking()
                    : _context.Idiomas;

            return await query

                                .ToListAsync();

        }
        public override async Task<Idioma> GetByIdAsync(int idIdioma, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.Idiomas.AsNoTracking()
                                   : _context.Idiomas;

            return await query

                                .FirstOrDefaultAsync(x => x.IdIdioma == idIdioma);
        }

        public async Task<List<Idioma>> GetByIdEmpleado(int idEmpl) => await
            _context.Idiomas.Where(x => x.IdEmp == idEmpl).ToListAsync();

        public bool SaveIdiomas(IdiomaDto idio)
        {
            bool response = false;
            string fechaInicioSQL = idio.FechaEmision != null ? "'" + Convert.ToDateTime(idio.FechaEmision).ToString("yyyy-MM-dd") + "'" : "null";

            if (idio.IdIdioma == 0)
                {
                    response = Conexion.InsertarZeusCore("IDIOMA", "ID_EMP, IDIOMA, INSTITUCION, NIVEL, FECHA_EMISION, CERTIFICACION, CERTIFICADO,UC,FC",
                                               idio.IdEmp + ",'" + idio.Idioma1 + "','" + idio.Institucion + "','" + idio.Nivel + "'," +
                                               fechaInicioSQL + "," +
                                               Convert.ToInt32(idio.Certificacion) + ",'" + idio.Certificado + "','" + idio.UC + "',GETDATE()");
                }
                else
                {
                    response = Conexion.ActualizarZeus("IDIOMA", "ID_EMP = " + idio.IdEmp + ", IDIOMA = '" + idio.Idioma1 + "', INSTITUCION = '" + idio.Institucion +
                        "', NIVEL = '" + idio.Nivel + "', FECHA_EMISION = " + fechaInicioSQL+
                        ", CERTIFICACION = " + Convert.ToInt32(idio.Certificacion) + ", CERTIFICADO = '" + idio.Certificado +
                        "', FA=GETDATE(), UA='" + idio.UA +"'", " Where ID_IDIOMA = " + idio.IdIdioma);
                }
  
            
            return response;
        }
        public bool EditIdiomas(IdiomaDto idio, int idIdioma)
        {
            bool response = false;
 
                response = Conexion.ActualizarZeus("IDIOMA", "ID_EMP = " + idio.IdEmp + ", IDIOMA = " + idio.Idioma1 + ", INSTITUCION = '" + idio.Institucion +
                                            "', NIVEL = '" + idio.Nivel + "', FECHA_EMISION = '" + Convert.ToDateTime(idio.FechaEmision).Date.ToString("yyyy-MM-dd") +
                                            "', CERTIFICACION = '" + idio.Certificacion + "', CERTIFICADO = '" + idio.Certificado +
                                            "', FA=GETDATE(), UA='" + idio.UA + "'", " Where ID_IDIOMA = " + idIdioma);
            
            return response;
        }
    }
}