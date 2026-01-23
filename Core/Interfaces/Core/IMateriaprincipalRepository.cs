using Core.Entidades.Core;
using Core.Interfaces.Generico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Core
{
    public interface IMateriaprincipalRepository:IGenericRepository<Materium>
    {
        Task<(int totalRegistros, IEnumerable<Materium> registros)> GetAllPagingAsync(int pageIndex, int pageSize, string search, int? idCarrera, int? idPlanEstudio, bool noseguimiento = true);
    }
}
