using Core.Dtos.Core;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Core
{
    public interface IMateriasMatriculadasEstudianteRepository
    {
        //'MM','2025-3','1727876656','QMED'
        //'HS','2025-3','QMED2223','MEDBASM2ES'
        //'VHC','2025-3','QMED/45/1105162','16210','17422','MEDBASM2BI'

        Task<IEnumerable<MateriasMatriculadasEstudianteDto>> GetMateriasMatriculadasEstudiante(string semestre,string identificacion,string codcarr);
        Task<IEnumerable<MateriasHorarioEstudianteDto>> GetMateriasHorarioEstudianteAC(string semestre,string malla,string codmateria,string identificacion);
        Task<IEnumerable<MateriasHorarioEstudianteDto>> GetMateriasHorarioEstudianteAPE(string semestre ,string malla, string codmateria,string identificacion);
        Task<IEnumerable<CruceHorarioEstudianteDto>> GetCruceHorarioEstudiante(ParametroEstudianteMatriculadoDto data);
        Task<bool> CambiarParalelo(ParametrosActualizarParaleloDto data);


    }
}
