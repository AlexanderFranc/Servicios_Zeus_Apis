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
    public class FacultadRepository : GenericCoreRepository<Facultad>, IFacultadRepository
    {
        public FacultadRepository(ZeusCoreContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Facultad>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.Facultads.AsNoTracking()
                    : _context.Facultads;

            return await query
                                .Include(x => x.IdCampusNavigation)
                                .Include(y => y.IdEstadoFacultadNavigation)
                                .ToListAsync();
        }

        public override async Task<Facultad> GetByIdAsync(int idfacultad, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.Facultads.AsNoTracking()
                                   : _context.Facultads;

            return await query
                                .Include(a => a.IdCampusNavigation)
                                .Include(b => b.IdEstadoFacultadNavigation)
                                .FirstOrDefaultAsync(x => x.IdFacultad == idfacultad);
        }

        public async Task<List<Facultad>> GetByCodeFacultadAsync(string cod) => await 
            _context.Facultads.Where(x => x.CodigoFacultad == cod).ToListAsync();

        public override async Task<(int totalRegistros, IEnumerable<Facultad> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.Facultads.AsNoTracking()
                                  : _context.Facultads;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.CodigoFacultad.ToLower().Contains(search));
            }


            var totalRegistros = await query
                                        .CountAsync();

            var registros = await query

                                .Include(x => x.IdCampusNavigation)
                                .Include(x => x.IdEstadoFacultadNavigation)
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            return (totalRegistros, registros);
        }

        public List<FacultadDto> getFacultadByCoordinador(string identificacion)
        {
            FacultadDto facultadDto = new FacultadDto();
            List<FacultadDto> listaFacultad = new List<FacultadDto>();
            //DataSet ds_facultad = Conexion.BuscarZEUS_ds("matriculaumasec.matricula.mt_Carrer a\r\ninner join zeus_new.dbo.carrera b\r\non a.codcarr = b.codigo_carrera\r\ninner join zeus_new.dbo.facultad c\r\non b.id_facultad=c.id_facultad\r\ninner join zeus_new.dbo.empleado d\r\non a.certificado = d.identificacion_emp or a.certificado = '0'+d.identificacion_emp or '0'+a.certificado = d.identificacion_emp", "DISTINCT c.ID_FACULTAD,c.CODIGO_FACULTAD,c.NOMBRE_FACULTAD", "where a.certificado='" + identificacion + "' order by c.nombre_facultad");
            DataSet ds_facultad = Conexion.ExecZeusCore("sp_ConsultaCoordinador", "'F','" + identificacion + "'");
            if (ds_facultad.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_facultad.Tables[0].Rows)
                {
                    //planificacion.idNivelEstudio = Convert.ToInt32(row["ID_NIVEL_ESTUDIO"].ToString());
                    facultadDto.IdFacultad = Convert.ToInt32(row["ID_FACULTAD"].ToString());
                    facultadDto.CodigoFacultad = row["CODIGO_FACULTAD"].ToString();
                    facultadDto.NombreFacultad = row["NOMBRE_FACULTAD"].ToString();


                    listaFacultad.Add(facultadDto);
                    facultadDto = new FacultadDto();
                }
            }
            return listaFacultad;
        }

    }
}
