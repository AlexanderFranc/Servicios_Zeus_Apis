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
    public class CarreraRepository : GenericCoreRepository<Carrera>, ICarreraRepository
    {
        public CarreraRepository(ZeusCoreContext context) : base(context)
        {
        }
        public override async Task<IEnumerable<Carrera>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.Carreras.AsNoTracking()
                    : _context.Carreras;

            return await query
                                .Include(x => x.IdEstadoCarreraNavigation)
                                .Include(y => y.IdFacultadNavigation)
                                .ToListAsync();
        }

        public override async Task<Carrera> GetByIdAsync(int idcarrera, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.Carreras.AsNoTracking()
                                   : _context.Carreras;

            return await query
                                .Include(a => a.IdEstadoCarreraNavigation)
                                .Include(b => b.IdFacultadNavigation)
                                .FirstOrDefaultAsync(x => x.IdCarrera == idcarrera);
        }

        public  async Task<List<Carrera>> GetByIdFacultadAsync(int id)
        {
            //var query = noseguimiento ? _context.Carreras.AsNoTracking()
            //                       : _context.Carreras;

            return await _context.Carreras
                                .Where(a=>a.IdFacultad==id)
                                .ToListAsync();

        }



        public async Task<List<Carrera>> GetByCodCarreraAsync(string cod) => await 
            _context.Carreras.Where(x => x.CodigoCarrera == cod).ToListAsync();

        public override async Task<(int totalRegistros, IEnumerable<Carrera> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.Carreras.AsNoTracking()
                                  : _context.Carreras;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.CodigoCarrera.ToLower().Contains(search));
            }


            var totalRegistros = await query
                                        .CountAsync();

            var registros = await query

                                .Include(x => x.IdEstadoCarreraNavigation)
                                .Include(x => x.IdFacultadNavigation)
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            return (totalRegistros, registros);
        }

        public List<CarreraDto> getCarreraByFacultadCoordinador(string identificacion, int idFacultad)
        {
            CarreraDto carreraDto = new CarreraDto();
            List<CarreraDto> listaCarrera = new List<CarreraDto>();
            //DataSet ds_carrera = Conexion.BuscarZEUS_ds("matriculaumasec.matricula.mt_Carrer a\r\ninner join zeus_new.dbo.carrera b\r\non a.codcarr = b.codigo_carrera\r\ninner join zeus_new.dbo.facultad c\r\non b.id_facultad=c.id_facultad\r\ninner join zeus_new.dbo.empleado d\r\non a.certificado = d.identificacion_emp or a.certificado = '0'+d.identificacion_emp or '0'+a.certificado = d.identificacion_emp", "b.ID_CARRERA,b.CODIGO_cARRERA,b.NOMBRE_CARRERA,b.SIGLAS_CARRERA", "where a.certificado='" + identificacion + "' and b.id_facultad=" + idFacultad + " order by b.siglas_carrera");
            DataSet ds_carrera = Conexion.ExecZeusCore("sp_ConsultaCoordinador", "'C','" + identificacion + "'," + idFacultad );
            if (ds_carrera.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_carrera.Tables[0].Rows)
                {
                    //planificacion.idNivelEstudio = Convert.ToInt32(row["ID_NIVEL_ESTUDIO"].ToString());
                    carreraDto.IdCarrera = Convert.ToInt32(row["ID_CARRERA"].ToString());
                    carreraDto.CodigoCarrera = row["CODIGO_cARRERA"].ToString();
                    carreraDto.NombreCarrera  = row["NOMBRE_CARRERA"].ToString();
                    carreraDto.SiglasCarrera = row["SIGLAS_CARRERA"].ToString();


                    listaCarrera.Add(carreraDto);
                    carreraDto = new CarreraDto();
                }
            }
            return listaCarrera;
        }


    }
}
