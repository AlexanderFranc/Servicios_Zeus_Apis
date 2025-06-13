using Core.Dtos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Core
{
    public  interface ITitulosAcademicosRepository
    {
        Task<List<TitulosAcademicosDto>> getByDni(string identificacion);
    }
}
