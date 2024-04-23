using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Core
{
    public class SilaboMateriasUsuarioRepository : GenericCoreRepository<SilaboMateriasUsuarioDto>, ISilaboMateriasUsuarioRepository
    {
        public SilaboMateriasUsuarioRepository(ZeusCoreContext context) : base(context)
        {
        }

        public async Task<IEnumerable<SilaboMateriasUsuarioDto>> GetAll(string periodo, string identificacion)
        {
            var query = await (from a in _context.Planificacions
                         join b in _context.Periodos on a.IdPeriodo equals b.IdPeriodo
                         join c in _context.Mallas on a.IdMalla equals c.IdMalla
                         join d in _context.Materia on c.IdMateria equals d.IdMateria
                         join e in _context.PlanEstudios on c.IdPlanEstudio equals e.IdPlanEstudio
                         join f in _context.Carreras on e.IdCarrera equals f.IdCarrera
                         join g in _context.Facultads on f.IdFacultad equals g.IdFacultad
                         where (a.DniProfesorc == identificacion || a.DniProfesorc =="0"+identificacion || "0"+a.DniProfesorc == "0" + identificacion) && b.CodigoPeriodo == periodo
                         select new SilaboMateriasUsuarioDto
                         {
                                IdPlanEstudio =e.IdPlanEstudio,
                                IdCarrera =f.IdCarrera,
                                NombreFacultad =g.NombreFacultad,
                                NombreCarrera =f.NombreCarrera,
                                IdFacultad =g.IdFacultad,
                                IdMateria =d.IdMateria,
                                NombreMateria =d.NombreMateria,
                                CodigoMateria =d.CodigoMateria,
                             CodPlanEstudio = e.CodigoPlanEstudioMalla,
                                IdMalla=c.IdMalla,
                                Identificacion=a.DniProfesorc
                                
                         }).ToListAsync();

            return query;
        }
    }
}
