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
    public interface IProfesorSRepository : IGenericRepository<Profesor1>
    {
        Task<List<Profesor1>> GetByIdPlanificacion(int idPlanificacion);
        List<ProfesorSDto> GetAllByIdPlanificacion(int idPlanificacion);

        List<ProfesorSDto> GetAllByIdPlanificacionTemp(int idPlanificacion);
        List<ProfesorSDto> GetAllByIdEmpNPlanificacionTemp(int idEmpN);
        bool SaveProfesorS(ProfesorSDto profesorsDto);
        bool SaveProfesorSList(List<ProfesorSDto> lstProfesorsDto, int idPlanificacion);
        ResponseDto DeleteProfesorS(int idplanidicacion, string usuario);
    }
}
