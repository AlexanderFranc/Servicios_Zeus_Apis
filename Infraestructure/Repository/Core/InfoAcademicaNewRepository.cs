using System.Linq.Expressions;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces.Ftp;
using System.Data;

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
        //public async Task<List<InfoAcademicaNew>> GetByIdEmpleado(int idEmpl) => await
        //    _context.InfoAcademicaNews.Where(x => x.IdEmp == idEmpl).ToListAsync();
        public List<InfoAcademicaNewDto> GetByIdEmpleado(int idEmpl) 
        {
            InfoAcademicaNewDto infoAcademicaNewDto;
            List<InfoAcademicaNewDto> listInfoAcademicaNewDto = new();
            var ds_solicitud = Conexion.BuscarZEUS_ds("zeus_new.dbo.info_academica_NEW a\r\ninner join zeus_new.dbo.unidad_educativa b\r\non a.id_unidad_Educativa=b.id_unidad_educativa",
                "ID_INFO_ACADEMICA,ID_EMP,ID_NIVEL_ACADEMICO,ID_PAIS,ID_CAMPO_ESPECIFICO,A.ID_UNIDAD_EDUCATIVA,\r\nCASE WHEN ISNULL(A.ID_UNIDAD_EDUCATIVA,0) NOT IN (991,992) THEN B.NOMBRE_UNIDAD_EDUCATIVA ELSE A.INSTITUCION END INSTITUCION,TITULO,FECHA_EMSISION,FECHA_REG_SENECYT,CERTIFICADO_TITULO,CERTIFICADO_SENECYT,CIUDAD,\r\nUC,FC,UA,FA,U_APRUEBA,F_APRUEBA,APROBADO_TH",
                "where ID_EMP = "+ idEmpl);
            if (ds_solicitud.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_solicitud.Tables[0].Rows)
                {
                    infoAcademicaNewDto = new();
                    infoAcademicaNewDto.IdInfoAcademica = row["ID_INFO_ACADEMICA"] != DBNull.Value ? Convert.ToInt32(row["ID_INFO_ACADEMICA"].ToString()) : 0;
                    infoAcademicaNewDto.IdEmp = row["ID_EMP"] != DBNull.Value ? Convert.ToInt32(row["ID_EMP"].ToString()) : 0;
                    infoAcademicaNewDto.IdNivelAcademico = row["ID_NIVEL_ACADEMICO"] != DBNull.Value ? Convert.ToInt32(row["ID_NIVEL_ACADEMICO"].ToString()) : 0;
                    infoAcademicaNewDto.IdPais = row["ID_PAIS"] != DBNull.Value ? Convert.ToInt32(row["ID_PAIS"].ToString()) : 0;
                    infoAcademicaNewDto.IdCampoEspecifico = row["ID_CAMPO_ESPECIFICO"] != DBNull.Value ? Convert.ToInt32(row["ID_CAMPO_ESPECIFICO"].ToString()) : 0;
                    infoAcademicaNewDto.IdUnidadEducativa = row["ID_UNIDAD_EDUCATIVA"] != DBNull.Value ? Convert.ToInt32(row["ID_UNIDAD_EDUCATIVA"].ToString()) : 0;
                    infoAcademicaNewDto.Institucion = row["INSTITUCION"] != DBNull.Value ? row["INSTITUCION"].ToString() : string.Empty;
                    infoAcademicaNewDto.Titulo = row["TITULO"] != DBNull.Value ? row["TITULO"].ToString() : string.Empty;
                    infoAcademicaNewDto.FechaEmsision = row["FECHA_EMSISION"] != DBNull.Value ? Convert.ToDateTime(row["FECHA_EMSISION"].ToString()) : DateTime.MinValue;
                    infoAcademicaNewDto.FechaRegSenecyt = row["FECHA_REG_SENECYT"] != DBNull.Value ? Convert.ToDateTime(row["FECHA_REG_SENECYT"].ToString()) : DateTime.MinValue;
                    infoAcademicaNewDto.CertificadoTitulo = row["CERTIFICADO_TITULO"] != DBNull.Value ? row["CERTIFICADO_TITULO"].ToString() : string.Empty;
                    infoAcademicaNewDto.CertificadoSenecyt = row["CERTIFICADO_SENECYT"] != DBNull.Value ? row["CERTIFICADO_SENECYT"].ToString() : string.Empty;
                    infoAcademicaNewDto.Ciudad = row["CIUDAD"] != DBNull.Value ? row["CIUDAD"].ToString() : string.Empty;
                    infoAcademicaNewDto.UC = row["UC"] != DBNull.Value ? row["UC"].ToString() : string.Empty;
                    infoAcademicaNewDto.FC = row["FC"] != DBNull.Value ? Convert.ToDateTime(row["FC"].ToString()) : DateTime.MinValue;
                    infoAcademicaNewDto.UA = row["UA"] != DBNull.Value ? row["UA"].ToString() : string.Empty;
                    infoAcademicaNewDto.FA = row["FA"] != DBNull.Value ? Convert.ToDateTime(row["FA"].ToString()) : DateTime.MinValue;
                    infoAcademicaNewDto.UAprueba = row["U_APRUEBA"] != DBNull.Value ? row["U_APRUEBA"].ToString() : string.Empty;
                    infoAcademicaNewDto.FAprueba = row["F_APRUEBA"] != DBNull.Value ? Convert.ToDateTime(row["F_APRUEBA"].ToString()) : DateTime.MinValue;
                    infoAcademicaNewDto.AprobadoTH = row["APROBADO_TH"] != DBNull.Value ? Convert.ToBoolean(row["APROBADO_TH"].ToString()) : false;

                    listInfoAcademicaNewDto.Add(infoAcademicaNewDto);
                }
            }
            return listInfoAcademicaNewDto;
            
        }

        public bool SaveInfoAcademico(InfoAcademicaNewDto infoAcad)
        {
            bool response = false;
            
                if (infoAcad.IdInfoAcademica == 0)
                {
                    response = Conexion.InsertarZeusCore("INFO_ACADEMICA_NEW", "ID_EMP, ID_NIVEL_ACADEMICO, ID_PAIS, ID_CAMPO_ESPECIFICO, ID_UNIDAD_EDUCATIVA, INSTITUCION, TITULO, FECHA_EMSISION, FECHA_REG_SENECYT, CERTIFICADO_TITULO, CERTIFICADO_SENECYT,CIUDAD,UC,FC",
                                               infoAcad.IdEmp + "," + infoAcad.IdNivelAcademico + "," + infoAcad.IdPais + "," + infoAcad.IdCampoEspecifico + "," + infoAcad.IdUnidadEducativa + ",'" + infoAcad.Institucion + "','" + infoAcad.Titulo + "','" +
                                               Convert.ToDateTime(infoAcad.FechaEmsision).Date.ToString("yyyy-MM-dd") + "','" + Convert.ToDateTime(infoAcad.FechaRegSenecyt).Date.ToString("yyyy-MM-dd") + "','" + infoAcad.CertificadoTitulo +
                                               "','" + infoAcad.CertificadoSenecyt + "','"+infoAcad.Ciudad+"','" + infoAcad.UC + "',GETDATE()");
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
                    "', FA=GETDATE(), UA='" + infoAcad.UA +"'",
                    "Where ID_INFO_ACADEMICA = " + infoAcad.IdInfoAcademica
                );

            }


            return response;
        }
        public bool EditInfoAcademico(List<InfoAcademicaNewDto> lstInfoAcademicoDto, int idInfoAcad)
        {
            throw new NotImplementedException();
        }

        public Task<List<InfoAcademicaNewDto>> GetTitulosEmpleado(string identificacion)
        {
            throw new NotImplementedException();
        }
    }
}
