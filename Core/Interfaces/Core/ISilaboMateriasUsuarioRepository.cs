using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Generico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Core
{
    public interface ISilaboMateriasUsuarioRepository : IGenericRepository<SilaboMateriasUsuarioDto>
    {
        Task<IEnumerable<SilaboMateriasUsuarioDto>> GetAll(string periodo,string identificacion);

    }
}
