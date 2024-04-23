using Core.Dtos.Core;
using Core.Interfaces.Generico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Core
{
    public interface IDatosGeneralesSilaboRepository: IGenericRepository<DatosGeneralesSilaboDto>
    {
        Task<DatosGeneralesSilaboDto> getDatosGeneralesSilabo(int idplan,int idmateria);
    

    }
}
