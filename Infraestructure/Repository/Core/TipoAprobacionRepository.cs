using System.Linq.Expressions;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;


namespace Infraestructure.Repository.Core
{
    public class TipoAprobacionRepository : GenericCoreRepository<TipoAprobacion>, ITipoAprobacionRepository
    {
        public TipoAprobacionRepository(ZeusCoreContext context) : base(context)
        {
        }

        //public async Task<List<ExperienciaLaboral>> GetByDniAsync(string ced) => await
        //    _context.ExperienciaLaborals.Where(x => x.IdentificacionEmp == ced).ToListAsync();
        public override async Task<IEnumerable<TipoAprobacion>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.TipoAprobacions.AsNoTracking()
                    : _context.TipoAprobacions;

            return await query

                                .ToListAsync();

        }
        public override async Task<TipoAprobacion> GetByIdAsync(int idTipoAprobacion, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.TipoAprobacions.AsNoTracking()
                                   : _context.TipoAprobacions;

            return await query

                                .FirstOrDefaultAsync(x => x.IdTipoAprobacion == idTipoAprobacion);
        }
        //public override async Task<(int totalRegistros, IEnumerable<ExperienciaLaboral> registros)> GetAllAsync(
        //    int pageIndex, int pageSize, string search, bool noseguimiento = true)
        //{

        //    var query = noseguimiento ? _context.ExperienciaLaborals.AsNoTracking()
        //                          : _context.ExperienciaLaborals;

        //    if (!String.IsNullOrEmpty(search))
        //    {
        //        query = query.Where(p => p.IdExperienciaLaboral.ToLower().Contains(search));
        //    }


        //    var totalRegistros = await query
        //                                .CountAsync();

        //    var registros = await query


        //                            .Skip((pageIndex - 1) * pageSize)
        //                            .Take(pageSize)
        //                            .ToListAsync();

        //    return (totalRegistros, registros);
        //}

    }
}
