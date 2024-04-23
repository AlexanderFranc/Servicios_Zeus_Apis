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
    public interface IProyectoInvestigacionRepository : IGenericRepository<ProyectoInvestigacion>
    {
        Task<List<ProyectoInvestigacion>> GetByIdEmpleado(int idEmpl);
        bool SaveProyectoInvestigaciones(List<ProyectoInvestigacionDto> lstProyectoInvestigacionDto);
        bool EditProyectoInvestigaciones(List<ProyectoInvestigacionDto> lstProyectoInvestigacionDto, int idProyectoInvestigacion);
    }
}
