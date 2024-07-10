using System.Data;
using System.Linq.Expressions;
using AutoMapper;
using Core.Dtos.Core;
using Core.Dtos.Public;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Infraestructure.Repository.Core
{
    public class MateriaComponenteRepository : GenericCoreRepository<MateriaComponenteDto>, IMateriaComponenteRepository
    {
        public MateriaComponenteRepository(ZeusCoreContext context) : base(context)
        {


        }

        public async Task<ICollection<PlanMateriaMallaDto>> getPlanMateria()
        {
            var _planestudio = await (from a in _context.Componentes
                                      join b in _context.PlanEstudios on a.IdPlanEstudio equals b.IdPlanEstudio
                                      join c in _context.Materia on a.IdMateria equals c.IdMateria
                                      select new PlanMateriaMallaDto
                                      {
                                          Id = a.IdPlanEstudio + "-" + a.IdMateria,
                                          IdPlanEstudio = a.IdPlanEstudio,
                                          CodigoPlanEstudioMalla = b.CodigoPlanEstudioMalla,
                                          IdMateria = a.IdMateria,
                                          CodigoMateria = c.CodigoMateria,
                                          NombreMateria = c.NombreMateria
                                      }).Distinct().ToListAsync();
            return _planestudio;
        }
        public async Task<List<ComponenteMateriaMallaDto>> getComponentesByMateria(int idplanestudio, int idmateria)
        {
            var _componentemateria = await (from a in _context.Componentes
                                            join b in _context.SubtipoComponentes on a.IdSubtipoComponente equals b.IdSubtipoComponente
                                            join c in _context.TipoComponentes on b.IdTipoComponente equals c.IdTipoComponente
                                            where a.IdPlanEstudio == idplanestudio && a.IdMateria == idmateria
                                            select new ComponenteMateriaMallaDto
                                            {
                                                IdComponente = a.IdComponente,
                                                IdPlanEstudio = a.IdPlanEstudio,
                                                IdMateria = a.IdMateria,
                                                CodigoComponente = c.CodigoTipoComponente,
                                                IdSubtipoComponente = b.IdSubtipoComponente,
                                                CodigoSubtipoComponente = b.CodigoSubtipoComponente,
                                                NombreSubtipoComponente = b.NombreSubtipoComponente,
                                                HorasComponente = a.HorasComponente,
                                                PesoComponente = a.PesoComponente,

                                            }).ToListAsync();
            return _componentemateria;
        }
        public async Task<ICollection<MateriaComponenteDto>> getAllMateriaComponentes()
        {
            ICollection<PlanMateriaMallaDto> lsmateriamallaDto = await getPlanMateria();
            ICollection<MateriaComponenteDto> lsmateriacomponenteDto = new List<MateriaComponenteDto>();
            foreach (PlanMateriaMallaDto a in lsmateriamallaDto)
            {
                MateriaComponenteDto materiacomponente = new MateriaComponenteDto();
                PlanMateriaMallaDto planmateriaDto = new PlanMateriaMallaDto();
                planmateriaDto.Id = a.Id;
                planmateriaDto.IdPlanEstudio = a.IdPlanEstudio;
                planmateriaDto.CodigoPlanEstudioMalla = a.CodigoPlanEstudioMalla;
                planmateriaDto.IdMateria = a.IdMateria;
                planmateriaDto.CodigoMateria = a.CodigoMateria;
                planmateriaDto.NombreMateria = a.NombreMateria;
                List<ComponenteMateriaMallaDto> listcomponenteByMateria = await getComponentesByMateria(a.IdPlanEstudio, a.IdMateria);
                List<ComponenteMateriaMallaDto> listcomponente = new List<ComponenteMateriaMallaDto>();
                foreach (ComponenteMateriaMallaDto objcomponente in listcomponenteByMateria)
                {
                    ComponenteMateriaMallaDto itemcomponente = new ComponenteMateriaMallaDto();
                    itemcomponente.IdComponente = objcomponente.IdComponente;
                    itemcomponente.IdPlanEstudio = objcomponente.IdPlanEstudio;
                    itemcomponente.IdMateria = objcomponente.IdMateria;
                    itemcomponente.IdSubtipoComponente = objcomponente.IdSubtipoComponente;
                    itemcomponente.CodigoComponente = objcomponente.CodigoComponente;
                    itemcomponente.CodigoSubtipoComponente = objcomponente.CodigoSubtipoComponente;
                    itemcomponente.NombreSubtipoComponente = objcomponente.NombreSubtipoComponente;
                    itemcomponente.HorasComponente = objcomponente.HorasComponente;
                    itemcomponente.PesoComponente = objcomponente.PesoComponente;
                    listcomponente.Add(itemcomponente);
                }
                materiacomponente.planMateriaMallaDto = planmateriaDto;
                materiacomponente.componentesMateriaDto = listcomponente;
                lsmateriacomponenteDto.Add(materiacomponente);
            }
            return lsmateriacomponenteDto;
        }


        public async Task<(int totalRegistros, IEnumerable<MateriaComponenteDto> registros)> GetAllPagingAsync(
            int pageIndex, int pageSize, string search
            )
        {
            ICollection<PlanMateriaMallaDto> lsmateriamallaDto = await getPlanMateria();
            ICollection<MateriaComponenteDto> lsmateriacomponenteDto = new List<MateriaComponenteDto>();
            foreach (PlanMateriaMallaDto a in lsmateriamallaDto)
            {
                MateriaComponenteDto materiacomponente = new MateriaComponenteDto();
                PlanMateriaMallaDto planmateriaDto = new PlanMateriaMallaDto();
                planmateriaDto.Id = a.Id;
                planmateriaDto.IdPlanEstudio = a.IdPlanEstudio;
                planmateriaDto.CodigoPlanEstudioMalla = a.CodigoPlanEstudioMalla;
                planmateriaDto.IdMateria = a.IdMateria;
                planmateriaDto.CodigoMateria = a.CodigoMateria;
                planmateriaDto.NombreMateria = a.NombreMateria;
                List<ComponenteMateriaMallaDto> listcomponenteByMateria = await getComponentesByMateria(a.IdPlanEstudio, a.IdMateria);
                List<ComponenteMateriaMallaDto> listcomponente = new List<ComponenteMateriaMallaDto>();
                foreach (ComponenteMateriaMallaDto objcomponente in listcomponenteByMateria)
                {
                    ComponenteMateriaMallaDto itemcomponente = new ComponenteMateriaMallaDto();
                    itemcomponente.IdComponente = objcomponente.IdComponente;
                    itemcomponente.IdPlanEstudio = objcomponente.IdPlanEstudio;
                    itemcomponente.IdMateria = objcomponente.IdMateria;
                    itemcomponente.IdSubtipoComponente = objcomponente.IdSubtipoComponente;
                    itemcomponente.CodigoComponente = objcomponente.CodigoComponente;
                    itemcomponente.CodigoSubtipoComponente = objcomponente.CodigoSubtipoComponente;
                    itemcomponente.NombreSubtipoComponente = objcomponente.NombreSubtipoComponente;
                    itemcomponente.HorasComponente = objcomponente.HorasComponente;
                    itemcomponente.PesoComponente = objcomponente.PesoComponente;
                    listcomponente.Add(itemcomponente);
                }
                materiacomponente.planMateriaMallaDto = planmateriaDto;
                materiacomponente.componentesMateriaDto = listcomponente;
                lsmateriacomponenteDto.Add(materiacomponente);
            }

            var totalRegistros = (lsmateriacomponenteDto).Count();
            //.CountAsync();
            var registros = (lsmateriacomponenteDto
                                .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)).AsEnumerable()
                                    .ToList();

            return (totalRegistros, registros);
        }










        public async Task<ICollection<PlanMateriaMallaDto>> getPlanByMateria(string codplan, int id)
        {
            var _planestudio = await (from a in _context.Componentes
                                      join b in _context.PlanEstudios on a.IdPlanEstudio equals b.IdPlanEstudio
                                      join c in _context.Materia on a.IdMateria equals c.IdMateria
                                      where b.CodigoPlanEstudioMalla == codplan && c.IdMateria == id
                                      select new PlanMateriaMallaDto
                                      {
                                          Id = a.IdPlanEstudio + "-" + a.IdMateria,
                                          IdPlanEstudio = a.IdPlanEstudio,
                                          CodigoPlanEstudioMalla = b.CodigoPlanEstudioMalla,
                                          IdMateria = a.IdMateria,
                                          CodigoMateria = c.CodigoMateria,
                                          NombreMateria = c.NombreMateria
                                      }).Distinct().ToListAsync();
            return _planestudio;
        }



        public async Task<ICollection<MateriaComponenteDto>> getAllMateriaComponentesByPlan(string codplan, int id)
        {

            ICollection<PlanMateriaMallaDto> lsmateriamallaDto = await getPlanByMateria(codplan, id);
            ICollection<MateriaComponenteDto> lsmateriacomponenteDto = new List<MateriaComponenteDto>();
            foreach (PlanMateriaMallaDto a in lsmateriamallaDto)
            {
                MateriaComponenteDto materiacomponente = new MateriaComponenteDto();
                PlanMateriaMallaDto planmateriaDto = new PlanMateriaMallaDto();
                planmateriaDto.Id = a.Id;
                planmateriaDto.IdPlanEstudio = a.IdPlanEstudio;
                planmateriaDto.CodigoPlanEstudioMalla = a.CodigoPlanEstudioMalla;
                planmateriaDto.IdMateria = a.IdMateria;
                planmateriaDto.CodigoMateria = a.CodigoMateria;
                planmateriaDto.NombreMateria = a.NombreMateria;
                List<ComponenteMateriaMallaDto> listcomponenteByMateria = await getComponentesByMateria(a.IdPlanEstudio, a.IdMateria);
                List<ComponenteMateriaMallaDto> listcomponente = new List<ComponenteMateriaMallaDto>();
                foreach (ComponenteMateriaMallaDto objcomponente in listcomponenteByMateria)
                {
                    ComponenteMateriaMallaDto itemcomponente = new ComponenteMateriaMallaDto();
                    itemcomponente.IdComponente = objcomponente.IdComponente;
                    itemcomponente.IdPlanEstudio = objcomponente.IdPlanEstudio;
                    itemcomponente.IdMateria = objcomponente.IdMateria;
                    itemcomponente.IdSubtipoComponente = objcomponente.IdSubtipoComponente;
                    itemcomponente.CodigoComponente = objcomponente.CodigoComponente;
                    itemcomponente.CodigoSubtipoComponente = objcomponente.CodigoSubtipoComponente;
                    itemcomponente.NombreSubtipoComponente = objcomponente.NombreSubtipoComponente;
                    itemcomponente.HorasComponente = objcomponente.HorasComponente;
                    itemcomponente.PesoComponente = objcomponente.PesoComponente;
                    listcomponente.Add(itemcomponente);
                }
                materiacomponente.planMateriaMallaDto = planmateriaDto;
                materiacomponente.componentesMateriaDto = listcomponente;
                lsmateriacomponenteDto.Add(materiacomponente);
            }
            return lsmateriacomponenteDto;
        }

        public void updatehorasComponente(ComponenteMateriaMallaDto[] componente)
        {
            foreach (ComponenteMateriaMallaDto componenteDto in componente)
            {
                DataSet ds_comp = Conexion.BuscarZEUS_ds("COMPONENTE", "*", " WHERE ID_PLAN_ESTUDIO=" + componenteDto.IdPlanEstudio + " and ID_MATERIA=" + componenteDto.IdMateria + " and ID_SUBTIPO_COMPONENTE=" + componenteDto.IdSubtipoComponente);
                if (ds_comp.Tables[0].Rows.Count > 0)
                {
                    bool ds_componente = Conexion.ActualizarZeus("COMPONENTE", "HORAS_COMPONENTE=" + componenteDto.HorasComponente, " WHERE ID_PLAN_ESTUDIO=" + componenteDto.IdPlanEstudio + " and ID_MATERIA=" + componenteDto.IdMateria + " and ID_SUBTIPO_COMPONENTE=" + componenteDto.IdSubtipoComponente);

                }
                else
                {
                    bool insert_comp = Conexion.InsertarZeusCore("COMPONENTE", "ID_PLAN_ESTUDIO,ID_MATERIA,ID_SUBTIPO_COMPONENTE,CODIGO_COMPONENTE,ACTIVO_COMPONENTE,HORAS_COMPONENTE", componenteDto.IdPlanEstudio + "," + componenteDto.IdMateria + "," + componenteDto.IdSubtipoComponente + ",'',1," + componenteDto.HorasComponente);
                }
            }
        }
        public async Task<List<ComponenteMateriaMallaDto>> getComponenteSinPlanificar(int idPlanEstudio, int idMateria, int idPeriodo)
        {
            List<ComponenteMateriaMallaDto> lista = new List<ComponenteMateriaMallaDto>();
            ComponenteMateriaMallaDto componenteMateria = new ComponenteMateriaMallaDto();
            DataSet ds_componenteMateriaMalla = Conexion.BuscarZEUS_ds("COMPONENTE c\r\ninner join SUBTIPO_COMPONENTE s\r\non s.ID_SUBTIPO_COMPONENTE = c.ID_SUBTIPO_COMPONENTE", "distinct c.ID_PLAN_ESTUDIO,\r\nc.ID_MATERIA,\r\nc.ID_SUBTIPO_COMPONENTE,\r\nc.CODIGO_COMPONENTE,\r\nisnull(c.HORAS_COMPONENTE,0) HORAS_COMPONENTE,\r\nisnull(c.PESO_COMPONENTE,0) PESO_COMPONENTE,\r\ns.CODIGO_SUBTIPO_COMPONENTE,\r\ns.nombre_subtipo_componente", "where c.ID_PLAN_ESTUDIO=" + idPlanEstudio + " and c.id_materia=" + idMateria);
            if (ds_componenteMateriaMalla.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_componenteMateriaMalla.Tables[0].Rows)
                {

                    componenteMateria.IdPlanEstudio = Convert.ToInt32(row["id_plan_Estudio"].ToString());
                    componenteMateria.IdMateria = Convert.ToInt32(row["id_materia"].ToString());
                    componenteMateria.IdSubtipoComponente = Convert.ToInt32(row["id_subtipo_componente"].ToString());
                    componenteMateria.CodigoComponente = row["codigo_componente"].ToString();
                    componenteMateria.CodigoSubtipoComponente = row["codigo_subtipo_componente"].ToString();
                    componenteMateria.NombreSubtipoComponente = row["nombre_subtipo_componente"].ToString();
                    componenteMateria.HorasComponente = Convert.ToInt32(row["horas_componente"].ToString());
                    componenteMateria.PesoComponente = Convert.ToDouble(row["peso_componente"].ToString());
                    //componenteMateria.IdPeriodo = Convert.ToInt32(row["id_periodo"].ToString());
                    lista.Add(componenteMateria);

                    componenteMateria = new ComponenteMateriaMallaDto();
                }
            }
            return lista;
        }
        public async Task<List<ComponenteMateriaMallaDto>> getAllComponenteSinPlanificar(int idPlanEstudio, int idPeriodo)
        {
            List<ComponenteMateriaMallaDto> lista = new List<ComponenteMateriaMallaDto>();
            ComponenteMateriaMallaDto componenteMateria = new ComponenteMateriaMallaDto();
            DataSet ds_componenteMateriaMalla = Conexion.BuscarZEUS_ds("COMPONENTE c\r\ninner join SUBTIPO_COMPONENTE s\r\non s.ID_SUBTIPO_COMPONENTE = c.ID_SUBTIPO_COMPONENTE", "distinct c.ID_PLAN_ESTUDIO,\r\nc.ID_MATERIA,\r\nc.ID_SUBTIPO_COMPONENTE,\r\nc.CODIGO_COMPONENTE,\r\nisnull(c.HORAS_COMPONENTE,0) HORAS_COMPONENTE,\r\nisnull(c.PESO_COMPONENTE,0) PESO_COMPONENTE,\r\ns.CODIGO_SUBTIPO_COMPONENTE,\r\ns.nombre_subtipo_componente", "where c.ID_PLAN_ESTUDIO=" + idPlanEstudio);
            if (ds_componenteMateriaMalla.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_componenteMateriaMalla.Tables[0].Rows)
                {

                    componenteMateria.IdPlanEstudio = Convert.ToInt32(row["id_plan_Estudio"].ToString());
                    componenteMateria.IdMateria = Convert.ToInt32(row["id_materia"].ToString());
                    componenteMateria.IdSubtipoComponente = Convert.ToInt32(row["id_subtipo_componente"].ToString());
                    componenteMateria.CodigoComponente = row["codigo_componente"].ToString();
                    componenteMateria.CodigoSubtipoComponente = row["codigo_subtipo_componente"].ToString();
                    componenteMateria.NombreSubtipoComponente = row["nombre_subtipo_componente"].ToString();
                    componenteMateria.HorasComponente = Convert.ToInt32(row["horas_componente"].ToString());
                    componenteMateria.PesoComponente = Convert.ToDouble(row["peso_componente"].ToString());
                    componenteMateria.IdPeriodo = idPeriodo;
                    lista.Add(componenteMateria);

                    componenteMateria = new ComponenteMateriaMallaDto();
                }
            }
            return lista;
        }
    }
}
