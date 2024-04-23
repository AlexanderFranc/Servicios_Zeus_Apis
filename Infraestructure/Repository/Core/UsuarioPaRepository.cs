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

namespace Infraestructure.Repository.Core
{
    public class UsuarioPaRepository : GenericCoreRepository<UsuarioPaDto>, IUsuarioPaRepository
    {
        public UsuarioPaRepository(ZeusCoreContext context) : base(context)
        {
        }
        public async Task<List<MateriasPaDto>> GetUsuarioPa(List<UsuarioPaDto> usuarioPalst)
        {
            var data = await (from a in _context.PlanEstudios
                              join b in _context.Mallas on a.IdPlanEstudio equals b.IdPlanEstudio
                              join c in _context.Materia on b.IdMateria equals c.IdMateria
                              join h in _context.Carreras on a.IdCarrera equals h.IdCarrera
                              join d in _context.Facultads on h.IdFacultad equals d.IdFacultad

                              select new MateriasPaDto
                              {
                                  IdPlanEstudio = a.IdPlanEstudio,
                                  CodPlanEstudio=a.CodigoPlanEstudioMalla,
                                  IdCarrera = h.IdCarrera,
                                  NombreCarrera = h.NombreCarrera,
                                  IdFacultad = d.IdFacultad,
                                  NombreFacultad = d.NombreFacultad,
                                  IdMateria = c.IdMateria,
                                  NombreMateria = c.NombreMateria,
                                  CodigoMateria = c.CodigoMateria,
                                  IdMalla = b.IdMalla,
                              }).Distinct().ToListAsync();

            var resul =  (from a in data
                               join b in usuarioPalst on a.IdPlanEstudio equals b.IdPlanEstudio
                               where a.IdMateria == b.IdMateria && a.IdMalla == b.IdMalla
                               select new MateriasPaDto
                               {
                                   IdPlanEstudio = a.IdPlanEstudio,
                                   CodPlanEstudio=a.CodPlanEstudio,
                                   IdCarrera = a.IdCarrera,
                                   NombreCarrera = a.NombreCarrera,
                                   IdFacultad = a.IdFacultad,
                                   NombreFacultad = a.NombreFacultad,
                                   IdMateria = a.IdMateria,
                                   NombreMateria = a.NombreMateria,
                                   CodigoMateria = a.CodigoMateria,
                                   IdMalla = a.IdMalla,
                                   Identificacion=b.DniProfesor
                               }).ToList();

            return resul;
        }
    }
}
