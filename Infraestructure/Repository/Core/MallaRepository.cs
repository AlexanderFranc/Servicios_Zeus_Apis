using AutoMapper;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository.Core
{
    public class MallaRepository : GenericCoreRepository<Malla>, IMallaRepository
    {
        public MallaRepository(Configuration.Zeus.Core.ZeusCoreContext context) : base(context)
        {

        }

        public  async Task<ICollection<MallaMateriaDto>> getMalla()
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Prerrequisito, PrerrequisitosDto>();

            });


            var mapper = new Mapper(config);
            var dtomalla = from c in _context.Mallas select c;
            var dtomateria = from c in _context.Materia select new { IdMateria= c.IdMateria, NombreMateria=c.NombreMateria };


            var lstMaterias =from a in dtomalla
                             join c in _context.Prerrequisitos on a.IdMalla equals c.IdMalla
                             into a_c
                             from submalla in a_c.DefaultIfEmpty()
                             join b in dtomateria on a.IdMateria equals b.IdMateria
                             orderby b.NombreMateria ascending
                             select new MallaMateriaDto
                             {
                                 IdMalla = a.IdMalla,
                                 IdMateria = a.IdMateria,
                                 NombreMateria = b.NombreMateria,
                                 IdNivelEstudio = a.IdNivelEstudio,
                                 IdPlanEstudio = a.IdPlanEstudio,
                                 OrdenMalla = a.OrdenMalla,
                                 FecharegMalla = a.FecharegMalla,
                                 UsuarioregMalla = a.UsuarioregMalla,
                                 UsuarioactMalla = a.UsuarioactMalla,
                                 UsuarioelimMalla = a.UsuarioelimMalla,
                                 ActivoMalla = a.ActivoMalla,
                                 ObservacionMalla = a.ObservacionMalla,
                                 Prerrequisitos = a.Prerrequisitos
                             };

                      
            return await lstMaterias.ToListAsync();
        }

        public async Task<ICollection<MallaMateriaDto>> GetByIdPlanEstudio(string id,int idmodalidad)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Prerrequisito, PrerrequisitosDto>();

            });

            var idplanestudio = (from c in _context.PlanEstudios where c.CodigoPlanEstudioMalla == id && c.IdModalidadPe==idmodalidad select c).FirstOrDefault() ;
            var mapper = new Mapper(config);
            var dtomalla = from c in _context.Mallas select c;
            var dtomateria = from c in _context.Materia select new { IdMateria = c.IdMateria, NombreMateria = c.NombreMateria, CodigoMateria=c.CodigoMateria,
                CreditosMateria=c.CreditosMateria,
                HorasSemestralesMateria=c.HorasSemestralesMateria
            };


            var lstMaterias = from a in dtomalla
                              join c in _context.Prerrequisitos on a.IdMalla equals c.IdMalla
                              into a_c
                              from submalla in a_c.DefaultIfEmpty()
                              join b in dtomateria on a.IdMateria equals b.IdMateria
                              where a.IdPlanEstudio==idplanestudio.IdPlanEstudio
                              orderby b.NombreMateria ascending
                              select new MallaMateriaDto
                              {
                                  IdMalla = a.IdMalla,
                                  IdMateria = a.IdMateria,
                                  NombreMateria = b.NombreMateria,
                                  CodigoMateria=b.CodigoMateria,
                                  CreditosMateria=b.CreditosMateria,
                                  HorasSemestralesMateria=b.HorasSemestralesMateria,
                                  IdNivelEstudio = a.IdNivelEstudio,
                                  IdPlanEstudio = a.IdPlanEstudio,
                                  OrdenMalla = a.OrdenMalla,
                                  FecharegMalla = a.FecharegMalla,
                                  UsuarioregMalla = a.UsuarioregMalla,
                                  UsuarioactMalla = a.UsuarioactMalla,
                                  UsuarioelimMalla = a.UsuarioelimMalla,
                                  ActivoMalla = a.ActivoMalla,
                                  ObservacionMalla = a.ObservacionMalla,
                                  Prerrequisitos = a.Prerrequisitos

                              };


            return await lstMaterias.ToListAsync();
        }



        public async Task<List<Malla>> GetByCodMallaAsync(int cod) => await
                        _context.Mallas.Where(x => x.IdMalla == cod).ToListAsync();      

    }
}
