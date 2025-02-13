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
    public class InfoAcademicaRepository : GenericCoreRepository<InfoAcademica>, IInfoAcademicaRepository
    {
        public InfoAcademicaRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<InfoAcademica>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.InfoAcademicas.AsNoTracking()
                    : _context.InfoAcademicas;

            return await query
                                .Include(x => x.IdCiudadNavigation)
                                .Include(x => x.IdNivelAcademicoNavigation)
                                .ToListAsync();
        }

        public override async Task<InfoAcademica> GetByIdAsync(int idinfoAcad, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.InfoAcademicas.AsNoTracking()
                                   : _context.InfoAcademicas;

            return await query
                                .Include(x => x.IdCiudadNavigation)
                                .Include(x => x.IdNivelAcademicoNavigation)
                                .FirstOrDefaultAsync(x => x.IdInfoAcademica == idinfoAcad);
        }

        public override async Task<(int totalRegistros, IEnumerable<InfoAcademica> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.InfoAcademicas.AsNoTracking()
                                  : _context.InfoAcademicas;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.Institucion.ToLower().Contains(search));
            }


            var totalRegistros = await query
                                        .CountAsync();

            var registros = await query
                                .Include(x => x.IdCiudadNavigation)
                                .Include(x => x.IdNivelAcademicoNavigation)
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            return (totalRegistros, registros);
        }

        public async Task<List<InfoAcademica>> GetByIdEmpleado(int idEmpl) => await
            _context.InfoAcademicas.Where(x => x.IdEmp == idEmpl).ToListAsync();

        public bool SaveInfoAcademico(List<InfoAcademicaDto> lstInfoAcademicoDto)
        {
            bool response = false;
            foreach (var infoAcad in lstInfoAcademicoDto)
            {
                if (infoAcad.IdInfoAcademica == 0)
                {
                    response = Conexion.InsertarZeusCore("INFO_ACADEMICA", "ID_EMP, ID_NIVEL_ACADEMICO, ID_CIUDAD, INSTITUCION, TITULO, FECHA_EGRESA, FECHA_REG_SENECYT, CERTIFICADO",
                                               infoAcad.IdEmp + "," + infoAcad.IdNivelAcademico + "," + infoAcad.IdCiudad + ",'" + infoAcad.Institucion + "','" + infoAcad.Titulo + "','" +
                                               Convert.ToDateTime(infoAcad.FechaEgresa).Date.ToString("yyyy-MM-dd") + "','" + Convert.ToDateTime(infoAcad.FechaRegSenecyt).Date.ToString("yyyy-MM-dd") +
                                               "','" + infoAcad.Certificado + "'");
                }
                else
                {
                    response = Conexion.ActualizarZeus("INFO_ACADEMICA", "ID_EMP = " + infoAcad.IdEmp + ", ID_NIVEL_ACADEMICO = " + infoAcad.IdNivelAcademico + ", ID_CIUDAD = " + infoAcad.IdCiudad +
                                            ", INSTITUCION = '" + infoAcad.Institucion + "', TITULO = '" + infoAcad.Titulo + "', FECHA_EGRESA = '" + Convert.ToDateTime(infoAcad.FechaEgresa).Date.ToString("yyyy-MM-dd") +
                                            "', FECHA_REG_SENECYT = '" + Convert.ToDateTime(infoAcad.FechaRegSenecyt).Date.ToString("yyyy-MM-dd") +
                                            "', CERTIFICADO = '" + infoAcad.Certificado + "'", " Where ID_INFO_ACADEMICA = " + infoAcad.IdInfoAcademica);
                }
            }
            return response;
        }

        public bool EditInfoAcademico(List<InfoAcademicaDto> lstInfoAcademicoDto, int idInfoAcad)
        {
            bool response = false;
            foreach (var infoAcad in lstInfoAcademicoDto)
            {
                response = Conexion.ActualizarZeus("INFO_ACADEMICA", "ID_EMP = " + infoAcad.IdEmp + ", ID_NIVEL_ACADEMICO = " + infoAcad.IdNivelAcademico + ", ID_CIUDAD = " + infoAcad.IdCiudad +
                                            ", INSTITUCION = '" + infoAcad.Institucion + "', TITULO = '" + infoAcad.Titulo + "', FECHA_EGRESA = '" + Convert.ToDateTime(infoAcad.FechaEgresa).Date.ToString("yyyy-MM-dd") +
                                            "', FECHA_REG_SENECYT = '" + Convert.ToDateTime(infoAcad.FechaRegSenecyt).Date.ToString("yyyy-MM-dd") +
                                            "', CERTIFICADO = '" + infoAcad.Certificado + "'", " Where ID_INFO_ACADEMICA = " + infoAcad.IdInfoAcademica);
            }
            return response;
        }
    }
}
