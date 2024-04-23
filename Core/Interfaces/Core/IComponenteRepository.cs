using Core.Entidades.Core;
using Core.Interfaces.Generico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Core
{
    public interface IComponenteRepository : IGenericRepository<Componente>
    {
        Task<List<Componente>> GetComponenteByMateriaAsync(int idSub, int idplan, int idmat);
        Task<List<Componente>> GetAllComponentes(int idplan, int idmat);
    }
}
