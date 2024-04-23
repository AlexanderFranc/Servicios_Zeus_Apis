using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class PublicacionRepository : GenericCoreRepository<Publicacion>, IPublicacionRepository
    {
        public PublicacionRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Publicacion>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.Publicacions.AsNoTracking()
                    : _context.Publicacions;

            return await query
                                .Include(x => x.IdEmpNavigation)
                                .ToListAsync();
        }

        public override async Task<Publicacion> GetByIdAsync(int idpubl, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.Publicacions.AsNoTracking()
                                   : _context.Publicacions;

            return await query
                                .Include(x => x.IdEmpNavigation)
                                .FirstOrDefaultAsync(x => x.IdPublicacion == idpubl);
        }

        public override async Task<(int totalRegistros, IEnumerable<Publicacion> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.Publicacions.AsNoTracking()
                                  : _context.Publicacions;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.Titulo.ToLower().Contains(search));
            }


            var totalRegistros = await query
                                        .CountAsync();

            var registros = await query

                                .Include(x => x.IdEmpNavigation)
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            return (totalRegistros, registros);
        }

        public async Task<List<Publicacion>> GetByIdEmpleado(int idEmpl) => await 
            _context.Publicacions.Where(x => x.IdEmp == idEmpl).ToListAsync();

        public bool SavePublicacion(List<PublicacionDto> lstPublicacionDto)
        {
            bool response = false;
            foreach (var publicacion in lstPublicacionDto)
            {
                if (publicacion.IdPublicacion == 0)
                {
                    response = Conexion.InsertarZeusCore("PUBLICACION", "ID_EMP, ID_TIPO_PUBLICACION, NOMBRE, ISBN, ISSN, EDITORIAL, REG_PROPIEDAD_INTELECTUAL, REVISTA, REFERENCIA, ANO, BASE_DATOS, URL",
                                               publicacion.IdEmp + "," + publicacion.IdTipoPublicacion + ", '" + publicacion.Nombre + "', '" + publicacion.Isbn + "', '" + publicacion.Issn + "', '" +
                                               publicacion.Editorial + "', '" + publicacion.RegPropiedadIntelectual + "', '" + publicacion.Revista + "', '" + publicacion.Referencia + "', '" + publicacion.Ano + "', '" +
                                               publicacion.BaseDatos + "', '" + publicacion.Url + "'");
                }
                //else
                //{
                //    //response = Conexion.ActualizarZeus("INFO_ACADEMICA", "ID_EMP = " + publicacion.IdEmp + ", ID_NIVEL_ACADEMICO = " + publicacion.IdNivelAcademico + ", ID_CIUDAD = " + publicacion.IdCiudad +
                //    //                        ", INSTITUCION = '" + publicacion.Institucion + "', TITULO = '" + publicacion.Titulo + "', FECHA_EGRESA = '" + Convert.ToDateTime(publicacion.FechaEgresa).Date.ToString("yyyy-MM-dd") +
                //    //                        "', FECHA_REG_SENECYT = '" + Convert.ToDateTime(publicacion.FechaRegSenecyt).Date.ToString("yyyy-MM-dd") +
                //    //                        "', CERTIFICADO = '" + publicacion.Certificado + "'", " Where ID_INFO_ACADEMICA = " + publicacion.IdInfoAcademica);
                //}
            }
            return response;
        }

    }
}
