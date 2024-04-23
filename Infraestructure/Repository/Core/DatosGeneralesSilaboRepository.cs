using AutoMapper;
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
    public class DatosGeneralesSilaboRepository : GenericCoreRepository<DatosGeneralesSilaboDto>, IDatosGeneralesSilaboRepository
    {
        public DatosGeneralesSilaboRepository(ZeusCoreContext context) : base(context)
        {

        }
        public async Task<DatosGeneralesSilaboDto> getDatosGeneralesSilabo(int idplan, int idmateria)
        {

            DatosGeneralesSilaboDto datosGeneralesSilaboDto=new DatosGeneralesSilaboDto();
            int? hAA = 0;
            int? hAPE= 0;
            int? hAC = 0;
            var _planestudio = await (from a in _context.Facultads
                                      join b in _context.Carreras on a.IdFacultad equals b.IdFacultad
                                      join c in _context.PlanEstudios on b.IdCarrera equals c.IdCarrera
                                      join h in _context.ModalidadPes on c.IdModalidadPe equals h.IdModalidadPe
                                      join d in _context.Componentes on c.IdPlanEstudio equals d.IdPlanEstudio
                                      join e in _context.Materia on d.IdMateria equals e.IdMateria
                                      join i in _context.UnidadOrganizacionCurriculars on e.IdUoc equals i.IdUoc
                                      join f in _context.SubtipoComponentes on d.IdSubtipoComponente equals f.IdSubtipoComponente
                                      join g in _context.TipoComponentes on f.IdTipoComponente equals g.IdTipoComponente
                                      where d.IdPlanEstudio == idplan && d.IdMateria==idmateria
                                      select new DatosGeneralesSilaboDto
                                      {
                                          IdCarrera = b.IdCarrera,
                                          IdFacultad = a.IdFacultad,
                                          CodigoCarrera = b.CodigoCarrera,
                                          NombreCarrera = b.NombreCarrera,
                                          CodigoFacultad = a.CodigoFacultad,
                                          NombreFacultad = a.NombreFacultad,
                                          IdMateria = e.IdMateria,
                                          CodigoMateria = e.CodigoMateria,
                                          NombreMateria = e.NombreMateria,
                                          CreditosMateria = e.CreditosMateria,
                                          HorasSemestralesMateria = e.HorasSemestralesMateria,
                                          IdPlanEstudio = c.IdPlanEstudio,
                                          HorasComponente = d.HorasComponente,
                                          TipoComponente = g.CodigoTipoComponente,
                                          Modalidad=h.NombreModalidadPe,
                                          UnidadCurricular=i.NombreUoc

                                      }).Distinct().ToListAsync();
            if (_planestudio.Count() >0)
            {
                foreach (var item in _planestudio)
                {
                    switch(item.TipoComponente)
                    {
                        case "AA":
                            hAA += item.HorasComponente;
                            break;
                        case "ACD":
                            hAC += item.HorasComponente;
                            break;
                        case "APE":
                            hAPE += item.HorasComponente;
                            break;
                    }
                }
                datosGeneralesSilaboDto = _planestudio.FirstOrDefault();
                datosGeneralesSilaboDto.AC = hAC;
                datosGeneralesSilaboDto.APE = hAPE;
                datosGeneralesSilaboDto.AA = hAA;
            }
  
            return datosGeneralesSilaboDto;

        }
    }
    
}
