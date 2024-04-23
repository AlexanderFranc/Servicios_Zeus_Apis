using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class ProyectoInvestigacionRepository : GenericCoreRepository<ProyectoInvestigacion>, IProyectoInvestigacionRepository
    {
        public ProyectoInvestigacionRepository(ZeusCoreContext context) : base(context)
        {
        }

        public async Task<List<ProyectoInvestigacion>> GetByIdEmpleado(int idEmpl) => await
            _context.ProyectoInvestigacions.Where(x => x.IdEmp == idEmpl).ToListAsync();

        public override async Task<IEnumerable<ProyectoInvestigacion>> GetAllAsync(bool noseguimineto = true)
        {
            var query = noseguimineto ? _context.ProyectoInvestigacions.AsNoTracking()
                    : _context.ProyectoInvestigacions;

            return await query

                                .ToListAsync();

        }
        public override async Task<ProyectoInvestigacion> GetByIdAsync(int idProyectoInvestigacion, bool noseguimiento = true)
        {
            var query = noseguimiento ? _context.ProyectoInvestigacions.AsNoTracking()
                                   : _context.ProyectoInvestigacions;

            return await query

                                .FirstOrDefaultAsync(x => x.IdProyInves == idProyectoInvestigacion);
        }

        public bool SaveProyectoInvestigaciones(List<ProyectoInvestigacionDto> lstProyectoInvestigacionDto)
        {
            bool response = false;
            foreach (var proyectoinv in lstProyectoInvestigacionDto)
            {
                if (proyectoinv.IdProyInves == 0)
                {
                    response = Conexion.InsertarZeusCore("PROYECTOINVES", "ID_EMP, TITULO_P_INV, DURACION, PARTICIPANTES",
                                               proyectoinv.IdEmp + ",'" + proyectoinv.TituloPInv + "'," + proyectoinv.Duracion + ",'" + proyectoinv.Participantes + "'");
                }
                else
                {
                    response = Conexion.ActualizarZeus("PROYECTOINVES", "ID_EMP = " + proyectoinv.IdEmp + ", TITULO_P_INV = '" + proyectoinv.TituloPInv + "', DURACION = " + proyectoinv.Duracion +
                                            ", PARTICIPANTES = '" + proyectoinv.Participantes + "'", " Where ID_PROY_INVES = " + proyectoinv.IdProyInves);
                }
            }
            return response;
        }
        public bool EditProyectoInvestigaciones(List<ProyectoInvestigacionDto> lstProyectoInvestigacionDto, int idProyectoInvestigacion)
        {
            bool response = false;
            foreach (var proyectoinv in lstProyectoInvestigacionDto)
            {
                response = Conexion.ActualizarZeus("PROYECTOINVES", "ID_EMP = " + proyectoinv.IdEmp + ", TITULO_P_INV = '" + proyectoinv.TituloPInv + "', DURACION = " + proyectoinv.Duracion +
                                            ", PARTICIPANTES = '" + proyectoinv.Participantes + "'", " Where ID_PROY_INVES = " + idProyectoInvestigacion);
            }
            return response;
        }
        //public override async Task<(int totalRegistros, IEnumerable<ExperienciaLaboral> registros)> GetAllAsync(
        //    int pageIndex, int pageSize, string search, bool noseguimiento = true)
        //{

        //    var query = noseguimiento ? _context.ExperienciaLaborals.AsNoTracking()
        //                          : _context.ExperienciaLaborals;

        //    if (!String.IsNullOrEmpty(search))
        //    {
        //        query = query.Where(p => p.IdExperienciaLaboral.ToLower().Contains(search));
        //    }


        //    var totalRegistros = await query
        //                                .CountAsync();

        //    var registros = await query


        //                            .Skip((pageIndex - 1) * pageSize)
        //                            .Take(pageSize)
        //                            .ToListAsync();

        //    return (totalRegistros, registros);
        //}
    }
}
