using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Core
{
    public class ModalidadPERepository : GenericCoreRepository<ModalidadPe>, IModalidadPE
    {
        public ModalidadPERepository(Configuration.Zeus.Core.ZeusCoreContext context) : base(context)
        {

        }

        public override async Task<IEnumerable<ModalidadPe>> GetAllAsync(bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.ModalidadPes.AsNoTracking()
                       : _context.ModalidadPes;
            return await query
                                .ToListAsync();
        }


        ////public async Task<List<ModalidadPe>> GetAllMPEAsync()
        ////{
        ////    //var query = noseguimiento ? _context.ModalidadPes.AsNoTracking()
        ////    //           : _context.ModalidadPes;
        ////    //return await query
        ////    //                    //.Include(x => x.Provincia)
        ////    //                    //.ThenInclude(x => x.Cantons)
        ////    //                    .ToListAsync();

        ////    return await _context.ModalidadPes
        ////                       //.Include(x => x.Regions)
        ////                       //.Include(x => x.Provincia)
        ////                       //.ThenInclude(x => x.Cantons)
        ////                       .ToListAsync();
        ////}

        public override async Task<ModalidadPe> GetByIdAsync(int idModalidadPE, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.ModalidadPes.AsNoTracking()
                                   : _context.ModalidadPes;

            return await query

                                //.Include(x => x.Provincia)
                                //.ThenInclude(x => x.Cantons)
                                .FirstOrDefaultAsync(x => x.IdModalidadPe == idModalidadPE);
        }

        public async Task<List<ModalidadPe>> GetAllMPEActivasAsync()
        {
            return await _context.ModalidadPes
                                //.Include(x => x.Regions)
                                //.Include(x => x.Provincia)
                                //.ThenInclude(x => x.Cantons)
                                .Where(x => x.ActivoModalidadPe == true)
                                .ToListAsync();
        }

        public async Task<List<ModalidadPe>> GetByCodmpeAsync(string cod) => await
                _context.ModalidadPes.Where(x => x.CodigoModalidadPe == cod).ToListAsync();
    }
}
