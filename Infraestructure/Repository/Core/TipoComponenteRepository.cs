using System.Linq.Expressions;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class TipoComponenteRepository : GenericCoreRepository<TipoComponente>, ITipoComponenteRepository
    {
        public TipoComponenteRepository(ZeusCoreContext context) : base(context)
        {


        }

        public override async Task<IEnumerable<TipoComponente>> GetAllAsync(bool noseguimiento = true)
        {

            var query = noseguimiento ? _context.TipoComponentes.AsNoTracking()
           : _context.TipoComponentes;

            return await query.ToListAsync();
        }



        public async Task<IEnumerable<TipoComponenteSubtipoDto>> TipoSubtipoCoponente()
        {
            var query = await (from a in _context.SubtipoComponentes
                        join b in _context.TipoComponentes on a.IdTipoComponente equals b.IdTipoComponente
                        select new TipoComponenteSubtipoDto
                        {
                            IdSubtipoComponente = a.IdSubtipoComponente,
                            CodigoSubtipoComponente = a.CodigoSubtipoComponente,
                            NombreSubtipoComponente = a.NombreSubtipoComponente,
                            DescripcionSubtipoComponente = a.DescripcionSubtipoComponente,
                            IncluyeDedicacionDocenteSubtipoComponente = a.IncluyeDedicacionDocenteSubtipoComponente,
                            ActivoSubtipoComponente = a.ActivoSubtipoComponente,
                            IdTipoComponente = b.IdTipoComponente,
                            CodigoTipoComponente = b.CodigoTipoComponente,
                            NombreTipoComponente = b.NombreTipoComponente
                        }).ToListAsync();
            return query;
        }

        public async Task<TipoComponente> getByidAsync(int idtipocomponente)
        {
            return await _context.TipoComponentes
                                .Include(x => x.SubtipoComponentes)
                                .FirstOrDefaultAsync(x => x.IdTipoComponente == idtipocomponente);
        }

        public async Task<List<TipoComponente>> GetByCodeTipoComponenteAsync(string cod) => await
            _context.TipoComponentes.Where(x => x.CodigoTipoComponente == cod).ToListAsync();

        public override async Task<(int totalRegistros, IEnumerable<TipoComponente> registros)> GetAllAsync(
            int pageIndex, int pageSize, string search, bool noseguimiento = true)
        {


            var query = noseguimiento ? _context.TipoComponentes.AsNoTracking()
                 : _context.TipoComponentes;

            if (!String.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.CodigoTipoComponente.ToLower().Contains(search));
            }

            var totalRegistros = await query.CountAsync();

            var registros = await query
                                    .Include(x => x.SubtipoComponentes)
                                    .Skip((pageIndex - 1) + pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            return (totalRegistros, registros);

        }

    }
}
