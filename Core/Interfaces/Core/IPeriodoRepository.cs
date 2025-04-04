using System;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Generico;

namespace Core.Interfaces.Core
{
    public interface IPeriodoRepository : IGenericRepository<Periodo>
    {
        Task<IEnumerable<Periodo>> getCambioParalelo();
    }
}
