using Core.Dtos.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Infraestructure.Repository.Core
{
    public class AprobadorPlanAnaliticoRepository : GenericCoreRepository<PlanAnaliticoAprobadorDto>,IAprobadorPlanAnaliticoRepository
    {
        public AprobadorPlanAnaliticoRepository(ZeusCoreContext context) : base(context)
        {
        }

        public async Task<List<PlanAnaliticoAprobadorDto>> GetAprobadorPlanAnalitico(List<PlanAnaliticoDto> planAnaliticoDto)
        {
            var data = await(from a in _context.PlanEstudios
                             join b in _context.Mallas on a.IdPlanEstudio equals b.IdPlanEstudio
                             join c in _context.Materia on b.IdMateria equals c.IdMateria
                             join h in _context.Carreras on a.IdCarrera equals h.IdCarrera
                             join d in _context.Facultads on h.IdFacultad equals d.IdFacultad

                             select new MateriasPaDto
                             {
                                 IdPlanEstudio = a.IdPlanEstudio,
                                 IdCarrera = h.IdCarrera,
                                 NombreCarrera = h.NombreCarrera,
                                 IdFacultad = d.IdFacultad,
                                 NombreFacultad = d.NombreFacultad,
                                 IdMateria = c.IdMateria,
                                 NombreMateria = c.NombreMateria,
                                 CodigoMateria = c.CodigoMateria,
                                 IdMalla = b.IdMalla,
                             }).Distinct().ToListAsync();

            var resul = (from a in data
                         join b in planAnaliticoDto on a.IdPlanEstudio equals b.IdPlanEstudio
                         where a.IdPlanEstudio == b.IdPlanEstudio && a.IdMalla == b.IdMalla && a.IdMateria==b.IdAsignatura
                         select new PlanAnaliticoAprobadorDto
                         {
                             IdPlanAnalitico = b.IdPlanAnalitico,
                             IdPlanEstudio = b.IdPlanEstudio,
                             IdCarrera = a.IdCarrera,
                             NombreCarrera = a.NombreCarrera,
                             IdFacultad = a.IdFacultad,
                             NombreFacultad = a.NombreFacultad,
                             IdMateria = a.IdMateria,
                             NombreMateria = a.NombreMateria,
                             CodigoMateria = a.CodigoMateria,
                             IdMalla = a.IdMalla,
                             IdentificacionUsuElabora = b.UsuarioElabora,
                             FechaElabora=b.FechaElabora,
                             EstadoAprobado = b.EstadoAprobacion,
                             FechaAprueba = b.FechaAprueba,
                             UsuarioAprueba = b.UsuarioAprueba,
                             PathDocumento=b.PathDocumento

                         }).ToList();

            return resul;
        }
    }
}
