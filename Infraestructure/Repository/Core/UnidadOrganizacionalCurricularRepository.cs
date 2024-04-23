using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Core
{
    public class UnidadOrganizacionalCurricularRepository : GenericCoreRepository<UnidadOrganizacionCurricular>, IUnidadOrganizacionalCurricularRepository
    {
        public UnidadOrganizacionalCurricularRepository(ZeusCoreContext context) : base(context)
        {

        }

        public override async Task<IEnumerable<UnidadOrganizacionCurricular>> GetAllAsync(bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.UnidadOrganizacionCurriculars.AsNoTracking()
                       : _context.UnidadOrganizacionCurriculars;

            return await query.OrderBy(x => x.NombreUoc).ToListAsync();

        }

        public async Task<List<UnidadOrganizacionCurricular>> GetAllUOCActivasAsync()
        {
            return await _context.UnidadOrganizacionCurriculars
                                //.Include(x => x.Regions)
                                //.Include(x => x.Provincia)
                                //.ThenInclude(x => x.Cantons)
                                .Where(x => x.ActivoUoc == true)
                                .ToListAsync();
        }

        public async Task<List<UnidadOrganizacionCurricular>> GetByCoduocAsync(string cod) => await
                _context.UnidadOrganizacionCurriculars.Where(x => x.CodigoUoc == cod).ToListAsync();

    }
}
