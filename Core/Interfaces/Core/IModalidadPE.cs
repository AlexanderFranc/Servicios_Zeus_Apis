using Core.Entidades.Core;
using Core.Interfaces.Generico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Core
{
    public interface IModalidadPE : IGenericRepository<ModalidadPe>
    {
        Task<List<ModalidadPe>> GetAllMPEActivasAsync();
        Task<List<ModalidadPe>> GetByCodmpeAsync(string codModalidadpe);
    }
}
