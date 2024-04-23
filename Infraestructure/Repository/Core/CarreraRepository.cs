using System.Linq.Expressions;
using Core.Entidades.Core;
using Core.Interfaces.Core;
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


    }
}
