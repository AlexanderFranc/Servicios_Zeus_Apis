using System.Linq.Expressions;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces.Ftp;

namespace Infraestructure.Repository.Core
{
    public class InfoAcademicaNewRepository : GenericCoreRepository<InfoAcademicaNew>, IInfoAcademicaNewRepository
    {
        private readonly IFtpRepository _iftp;
        public InfoAcademicaNewRepository(ZeusCoreContext context, IFtpRepository ftp) : base(context)
        {
            _iftp = ftp;
        }
        public override async Task<IEnumerable<InfoAcademicaNew>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.InfoAcademicaNews.AsNoTracking()
                    : _context.InfoAcademicaNews;

            return await query
                                .ToListAsync();
        }

        public override async Task<InfoAcademicaNew> GetByIdAsync(int idinfoAcad, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.InfoAcademicaNews.AsNoTracking()
                                   : _context.InfoAcademicaNews;

            return await query
                                .FirstOrDefaultAsync(x => x.IdInfoAcademica == idinfoAcad);
        }

        public override async Task<(int totalRegistros, IEnumerable<InfoAcademicaNew> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.InfoAcademicaNews.AsNoTracking()
                                  : _context.InfoAcademicaNews;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.Institucion.ToLower().Contains(search));
            }


            var totalRegistros = await query
                                        .CountAsync();

            var registros = await query
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            return (totalRegistros, registros);
        }
        public async Task<List<InfoAcademicaNew>> GetByIdEmpleado(int idEmpl) => await
            _context.InfoAcademicaNews.Where(x => x.IdEmp == idEmpl).ToListAsync();

        public bool SaveInfoAcademico(InfoAcademicaNewDto infoAcad)
        {
            bool response = false;
            
                if (infoAcad.IdInfoAcademica == 0)
                {
                    response = Conexion.InsertarZeusCore("INFO_ACADEMICA_NEW", "ID_EMP, ID_NIVEL_ACADEMICO, ID_PAIS, ID_CAMPO_ESPECIFICO, ID_UNIDAD_EDUCATIVA, INSTITUCION, TITULO, FECHA_EMSISION, FECHA_REG_SENECYT, CERTIFICADO_TITULO, CERTIFICADO_SENECYT,CIUDAD",
                                               infoAcad.IdEmp + "," + infoAcad.IdNivelAcademico + "," + infoAcad.IdPais + "," + infoAcad.IdCampoEspecifico + "," + infoAcad.IdUnidadEducativa + ",'" + infoAcad.Institucion + "','" + infoAcad.Titulo + "','" +
                                               Convert.ToDateTime(infoAcad.FechaEmsision).Date.ToString("yyyy-MM-dd") + "','" + Convert.ToDateTime(infoAcad.FechaRegSenecyt).Date.ToString("yyyy-MM-dd") + "','" + infoAcad.CertificadoTitulo +
                                               "','" + infoAcad.CertificadoSenecyt + "','"+infoAcad.Ciudad+"'");
                }
                else
                {
                int? idCampoEspecifico = infoAcad.IdCampoEspecifico.HasValue ? infoAcad.IdCampoEspecifico : null;
                string fechaEmsision = infoAcad.FechaEmsision.HasValue ? "'" + Convert.ToDateTime(infoAcad.FechaEmsision).Date.ToString("yyyy-MM-dd") + "'" : "null";
                string fechaRegSenecyt = infoAcad.FechaRegSenecyt.HasValue ? "'" + Convert.ToDateTime(infoAcad.FechaRegSenecyt).Date.ToString("yyyy-MM-dd") + "'" : "null";


                response = Conexion.ActualizarZeus(
                    "INFO_ACADEMICA_NEW",
                    "ID_EMP = " + infoAcad.IdEmp +
                    ", ID_NIVEL_ACADEMICO = " + infoAcad.IdNivelAcademico +
                    ", ID_PAIS = " + infoAcad.IdPais +
                    ", ID_CAMPO_ESPECIFICO = " + (idCampoEspecifico.HasValue ? idCampoEspecifico.Value.ToString() : "null") +
                    ", ID_UNIDAD_EDUCATIVA = " + infoAcad.IdUnidadEducativa +
                    ", INSTITUCION = '" + infoAcad.Institucion +
                    "', TITULO = '" + infoAcad.Titulo +
                    "', FECHA_EMSISION = " + fechaEmsision +
                    ", FECHA_REG_SENECYT = " + fechaRegSenecyt +
                    ", CERTIFICADO_TITULO = '" + infoAcad.CertificadoTitulo +
                    "', CERTIFICADO_SENECYT = '" + infoAcad.CertificadoSenecyt +
                    "', CIUDAD = '" + infoAcad.Ciudad +
                    "'",
                    "Where ID_INFO_ACADEMICA = " + infoAcad.IdInfoAcademica
                );

            }


            return response;
        }
        public bool EditInfoAcademico(List<InfoAcademicaNewDto> lstInfoAcademicoDto, int idInfoAcad)
        {
            throw new NotImplementedException();
        }

        
    }
}
