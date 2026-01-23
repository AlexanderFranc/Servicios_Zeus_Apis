using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces;
using Core.Interfaces.Core;
using Microsoft.EntityFrameworkCore;
using Infraestructure.Configuration.Conexion.LoginDB;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Core
{
    public class MateriaEquivalenteRepository : GenericCoreRepository<MateriaEquivalenteDto>, IMateriaEquivalenteRepository
    {
        public MateriaEquivalenteRepository(ZeusCoreContext context) : base(context)
        {
        }

        public List<MateriaEquivalenteDto> getPlanificacionEquivalente(string periodo, int idMallaEquiv)
        {
            MateriaEquivalenteDto plnMatEquiv = new MateriaEquivalenteDto();
            List<MateriaEquivalenteDto> listaPlnMatEquiv = new List<MateriaEquivalenteDto>();

            string campos = @"me.ID_MATERIA_EQUIVALENTE, me.ACTIVO_MATERIA_EQUIVALENTE, me.PORC_EQUIV, me.OBSERVACIONES_MATERIA_EQUIVALENTE, me.PATHAUTORIZACION_MATERIA_EQUIVALENTE, me.AUTORIZACION_MATERIA_EQUIVALENTE,
x.ID_FACULTAD, x.ID_CARRERA, x.ID_MALLA, x.ID_MATERIA, x.ID_PLAN_ESTUDIO,
x.CODIGO_FACULTAD, x.NOMBRE_FACULTAD, x.CODIGO_CARRERA, x.NOMBRE_CARRERA, x.CODIGO_PLAN_ESTUDIO_MALLA, x.CODIGO_MODALIDAD_PE, x.NOMBRE_MODALIDAD_PE, x.CODIGO_MATERIA, x.NOMBRE_MATERIA, x.CREDITOS_MATERIA, x.HORAS_SEMESTRALES_MATERIA,
y.ID_FACULTAD as ID_FACULTAD_EQ, y.ID_CARRERA as ID_CARRERA_EQ, y.ID_MALLA as ID_MALLA_EQ, y.ID_MATERIA as ID_MATERIA_EQ, y.ID_PLAN_ESTUDIO as ID_PLAN_ESTUDIO_EQ,
y.CODIGO_FACULTAD as CODIGO_FACULTAD_EQ, y.NOMBRE_FACULTAD as NOMBRE_FACULTAD_EQ, y.CODIGO_CARRERA as CODIGO_CARRERA_EQ, y.NOMBRE_CARRERA as NOMBRE_CARRERA_EQ, y.CODIGO_PLAN_ESTUDIO_MALLA as CODIGO_PLAN_ESTUDIO_MALLA_EQ, y.CODIGO_MODALIDAD_PE as CODIGO_MODALIDAD_PE_EQ, y.NOMBRE_MODALIDAD_PE as NOMBRE_MODALIDAD_PE_EQ, y.CODIGO_MATERIA as CODIGO_MATERIA_EQ, y.NOMBRE_MATERIA as NOMBRE_MATERIA_EQ, y.CREDITOS_MATERIA as CREDITOS_MATERIA_EQ, y.HORAS_SEMESTRALES_MATERIA as HORAS_SEMESTRALES_MATERIA_EQ";

            // Usamos JOIN en las relaciones secundarias para asegurar datos maestros
            string tabla = @"
MATERIA_EQUIVALENTE me
left join 
( 
    select  
        m.ID_MALLA, 
        pe.ID_PLAN_ESTUDIO,
        fac.ID_FACULTAD,
        car.ID_CARRERA,
        mat.ID_MATERIA,
        fac.CODIGO_FACULTAD, 
        fac.NOMBRE_FACULTAD, 
        car.CODIGO_CARRERA, 
        car.NOMBRE_CARRERA, 
        pe.CODIGO_PLAN_ESTUDIO_MALLA, 
        modpe.CODIGO_MODALIDAD_PE, 
        modpe.NOMBRE_MODALIDAD_PE, 
        mat.CODIGO_MATERIA, 
        mat.NOMBRE_MATERIA, mat.CREDITOS_MATERIA, mat.HORAS_SEMESTRALES_MATERIA 
    from MALLA m 
    left join PLAN_ESTUDIO pe 
        on m.ID_PLAN_ESTUDIO = pe.ID_PLAN_ESTUDIO 
    left join MATERIA mat 
        on m.ID_MATERIA = mat.ID_MATERIA 
    left join MODALIDAD_PE modpe 
        on pe.ID_MODALIDAD_PE = modpe.ID_MODALIDAD_PE 
    left join CARRERA car 
        on pe.ID_CARRERA = car.ID_CARRERA 
    left join FACULTAD fac 
        on car.ID_FACULTAD = fac.ID_FACULTAD 
    left join ESTADO_PE epe
        on pe.ID_ESTADO_PE = epe.ID_ESTADO_PE
 ) as x 
     on me.ID_MALLA = x.ID_MALLA 
 left join 
 ( 
     select  
         m.ID_MALLA, 
         pe.ID_PLAN_ESTUDIO,
        fac.ID_FACULTAD,
        car.ID_CARRERA,
        mat.ID_MATERIA,
        fac.CODIGO_FACULTAD, 
        fac.NOMBRE_FACULTAD, 
        car.CODIGO_CARRERA, 
        car.NOMBRE_CARRERA, 
        pe.CODIGO_PLAN_ESTUDIO_MALLA, 
        modpe.CODIGO_MODALIDAD_PE, 
        modpe.NOMBRE_MODALIDAD_PE, 
        mat.CODIGO_MATERIA, 
        mat.NOMBRE_MATERIA, mat.CREDITOS_MATERIA, mat.HORAS_SEMESTRALES_MATERIA 
    from MALLA m 
    left join PLAN_ESTUDIO pe 
        on m.ID_PLAN_ESTUDIO = pe.ID_PLAN_ESTUDIO 
    left join MATERIA mat 
        on m.ID_MATERIA = mat.ID_MATERIA 
    left join MODALIDAD_PE modpe 
        on pe.ID_MODALIDAD_PE = modpe.ID_MODALIDAD_PE 
    left join CARRERA car 
        on pe.ID_CARRERA = car.ID_CARRERA 
    left join FACULTAD fac 
        on car.ID_FACULTAD = fac.ID_FACULTAD 
    left join ESTADO_PE epe
        on pe.ID_ESTADO_PE = epe.ID_ESTADO_PE
) as y 
    on me.ID_MALLA_EQUIV = y.ID_MALLA";

            string where = " where 1=1"; // Mostrar todo para coincidir con conteo DB
            if (idMallaEquiv != 0)
            {
                // Filtramos estrictamente por el Plan de Estudio Origen
                where += $" AND x.ID_PLAN_ESTUDIO = {idMallaEquiv}";
            }

            // Append Order By at the end
            string orderBy = " order by x.NOMBRE_CARRERA, x.NOMBRE_MATERIA";

            DataSet ds_plnMatEquiv = Conexion.BuscarZEUS_ds(tabla, campos, where + orderBy);

            if (ds_plnMatEquiv.Tables.Count > 0)
            {
                foreach (DataRow row in ds_plnMatEquiv.Tables[0].Rows)
                {
                    plnMatEquiv.IdMateriaEquivalente = row["ID_MATERIA_EQUIVALENTE"] != DBNull.Value ? Convert.ToInt32(row["ID_MATERIA_EQUIVALENTE"]) : 0;
                    plnMatEquiv.PorcEquiv = row["PORC_EQUIV"] != DBNull.Value ? Convert.ToDecimal(row["PORC_EQUIV"]) : 0;
                    plnMatEquiv.ActivoMateriaEquivalente = row["ACTIVO_MATERIA_EQUIVALENTE"] != DBNull.Value ? Convert.ToBoolean(row["ACTIVO_MATERIA_EQUIVALENTE"]) : false;

                    // Datos Materia Origen
                    plnMatEquiv.IdFacultad = row["ID_FACULTAD"] != DBNull.Value ? Convert.ToInt32(row["ID_FACULTAD"]) : 0;
                    plnMatEquiv.IdCarrera = row["ID_CARRERA"] != DBNull.Value ? Convert.ToInt32(row["ID_CARRERA"]) : 0;
                    plnMatEquiv.IdMalla = row["ID_PLAN_ESTUDIO"] != DBNull.Value ? Convert.ToInt32(row["ID_PLAN_ESTUDIO"]) : 0;
                    plnMatEquiv.IdMateria = row["ID_MATERIA"] != DBNull.Value ? Convert.ToInt32(row["ID_MATERIA"]) : 0;

                    plnMatEquiv.CodigoFacultad = row["CODIGO_FACULTAD"]?.ToString() ?? "";
                    plnMatEquiv.NombreFacultad = row["NOMBRE_FACULTAD"]?.ToString() ?? "";
                    plnMatEquiv.CodigoCarrera = row["CODIGO_CARRERA"]?.ToString() ?? "";
                    plnMatEquiv.NombreCarrera = row["NOMBRE_CARRERA"]?.ToString() ?? "";
                    plnMatEquiv.CodigoPlanEstudioMalla = row["CODIGO_PLAN_ESTUDIO_MALLA"]?.ToString() ?? "";
                    plnMatEquiv.CodigoModalidadPe = row["CODIGO_MODALIDAD_PE"]?.ToString() ?? "";
                    plnMatEquiv.NombreModalidadPe = row["NOMBRE_MODALIDAD_PE"]?.ToString() ?? "";
                    plnMatEquiv.CodigoMateria = row["CODIGO_MATERIA"]?.ToString() ?? "";
                    
                    plnMatEquiv.NombreMateria = row["NOMBRE_MATERIA"]?.ToString() ?? "";
                    plnMatEquiv.CreditosMateria = row["CREDITOS_MATERIA"] != DBNull.Value ? Convert.ToDecimal(row["CREDITOS_MATERIA"]) : 0;
                    plnMatEquiv.HorasSemestralesMateria = row["HORAS_SEMESTRALES_MATERIA"] != DBNull.Value ? Convert.ToInt32(row["HORAS_SEMESTRALES_MATERIA"]) : 0;

                    // Datos Materia Equivalente
                    plnMatEquiv.IdFacultadEq = row["ID_FACULTAD_EQ"] != DBNull.Value ? Convert.ToInt32(row["ID_FACULTAD_EQ"]) : 0;
                    plnMatEquiv.IdCarreraEq = row["ID_CARRERA_EQ"] != DBNull.Value ? Convert.ToInt32(row["ID_CARRERA_EQ"]) : 0;
                    plnMatEquiv.IdMallaEq = row["ID_PLAN_ESTUDIO_EQ"] != DBNull.Value ? Convert.ToInt32(row["ID_PLAN_ESTUDIO_EQ"]) : 0;
                    plnMatEquiv.IdMateriaEq = row["ID_MATERIA_EQ"] != DBNull.Value ? Convert.ToInt32(row["ID_MATERIA_EQ"]) : 0;

                    plnMatEquiv.CodigoFacultadEq = row["CODIGO_FACULTAD_EQ"] != DBNull.Value ? row["CODIGO_FACULTAD_EQ"].ToString() : "";
                    plnMatEquiv.NombreFacultadEq = row["NOMBRE_FACULTAD_EQ"] != DBNull.Value ? row["NOMBRE_FACULTAD_EQ"].ToString() : "";
                    plnMatEquiv.CodigoCarreraEq = row["CODIGO_CARRERA_EQ"] != DBNull.Value ? row["CODIGO_CARRERA_EQ"].ToString() : "";
                    plnMatEquiv.NombreCarreraEq = row["NOMBRE_CARRERA_EQ"] != DBNull.Value ? row["NOMBRE_CARRERA_EQ"].ToString() : "";
                    plnMatEquiv.CodigoPlanEstudioMallaEq = row["CODIGO_PLAN_ESTUDIO_MALLA_EQ"] != DBNull.Value ? row["CODIGO_PLAN_ESTUDIO_MALLA_EQ"].ToString() : "";
                    plnMatEquiv.CodigoModalidadPeEq = row["CODIGO_MODALIDAD_PE_EQ"] != DBNull.Value ? row["CODIGO_MODALIDAD_PE_EQ"].ToString() : "";
                    plnMatEquiv.NombreModalidadPeEq = row["NOMBRE_MODALIDAD_PE_EQ"] != DBNull.Value ? row["NOMBRE_MODALIDAD_PE_EQ"].ToString() : "";
                    plnMatEquiv.CodigoMateriaEq = row["CODIGO_MATERIA_EQ"] != DBNull.Value ? row["CODIGO_MATERIA_EQ"].ToString() : "";
                    
                    plnMatEquiv.NombreMateriaEq = row["NOMBRE_MATERIA_EQ"] != DBNull.Value ? row["NOMBRE_MATERIA_EQ"].ToString() : "";
                    plnMatEquiv.CreditosMateriaEq = row["CREDITOS_MATERIA_EQ"] != DBNull.Value ? Convert.ToDecimal(row["CREDITOS_MATERIA_EQ"]) : 0;
                    plnMatEquiv.HorasSemestralesMateriaEq = row["HORAS_SEMESTRALES_MATERIA_EQ"] != DBNull.Value ? Convert.ToInt32(row["HORAS_SEMESTRALES_MATERIA_EQ"]) : 0;

                    plnMatEquiv.ObservacionesMateriaEquivalente = row["OBSERVACIONES_MATERIA_EQUIVALENTE"] != DBNull.Value ? row["OBSERVACIONES_MATERIA_EQUIVALENTE"].ToString() : "";
                    plnMatEquiv.PathAutorizacionMateriaEquivalente = row["PATHAUTORIZACION_MATERIA_EQUIVALENTE"] != DBNull.Value ? row["PATHAUTORIZACION_MATERIA_EQUIVALENTE"].ToString() : "";
                    plnMatEquiv.AutorizacionMateriaEquivalente = row["AUTORIZACION_MATERIA_EQUIVALENTE"] != DBNull.Value ? Convert.ToBoolean(row["AUTORIZACION_MATERIA_EQUIVALENTE"]) : null;

                    listaPlnMatEquiv.Add(plnMatEquiv);
                    plnMatEquiv = new MateriaEquivalenteDto();
                }
            }
            return listaPlnMatEquiv;
        }


        public List<ComponentesPlanificacionDto> getPlanificacionE(string periodo, int idMallaEquiv)
        {
            ComponentesPlanificacionDto planificacion = new ComponentesPlanificacionDto();
            List<ComponentesPlanificacionDto> listaPlanificacion = new List<ComponentesPlanificacionDto>();
            DataSet ds_planificacion = Conexion.ExecZeusCore("MateriasEquivalentes", "'LP','" + periodo + "'," + idMallaEquiv);

            if (ds_planificacion.Tables.Count > 0)
            {
                foreach (DataRow row in ds_planificacion.Tables[0].Rows)
                {
                    string fi = row["FECHA_INICIO_PLANIFICACION"].ToString();
                    string ff = row["FECHA_FIN_PLANIFICACION"].ToString();

                    planificacion.idPlanificacion = Convert.ToInt32(row["ID_PLANIFICACION"].ToString());
                    //planificacion.IdComponentePlanificacion = Convert.ToInt32(row["ID_COMPONENTE_PLANIFICACION"].ToString());
                    planificacion.idPeriodo = Convert.ToInt32(row["ID_PERIODO"].ToString());
                    planificacion.idMalla = Convert.ToInt32(row["ID_MALLA"].ToString());
                    planificacion.idTipoComponente = Convert.ToInt32(row["ID_SUBTIPO_COMPONENTE"].ToString());
                    planificacion.CodigoSubtipoComponente = row["CODIGO_SUBTIPO_COMPONENTE"].ToString();
                    planificacion.activo = Convert.ToBoolean(row["ACTIVO"].ToString());
                    planificacion.FechaInicioPlanificacion = fi == "" ? null : Convert.ToDateTime(row["FECHA_INICIO_PLANIFICACION"].ToString());
                    planificacion.FechaFinPlanificacion = ff == "" ? null : Convert.ToDateTime(row["FECHA_FIN_PLANIFICACION"].ToString());
                    listaPlanificacion.Add(planificacion);
                    planificacion = new ComponentesPlanificacionDto();
                }
            }
            return listaPlanificacion;
        }

        public async Task<bool> CrearMateriaEquivalente(MateriaEquivalenteInputDto input)
        {
            Console.WriteLine($"[REPO] CrearMateriaEquivalente START. IdMalla(Plan):{input.IdMalla}, IdMateria:{input.IdMateria}, IdMallaEquiv(Plan):{input.IdMallaEquiv}, IdMateriaEquiv:{input.IdMateriaEquiv}");
            try
            {
                int finalIdMalla = input.IdMalla;
                if (input.IdMateria.HasValue && input.IdMateria.Value > 0)
                {
                    var malla = await _context.Mallas.FirstOrDefaultAsync(x => x.IdPlanEstudio == input.IdMalla && x.IdMateria == input.IdMateria.Value);
                    if (malla != null) 
                    {
                        finalIdMalla = malla.IdMalla;
                        Console.WriteLine($"[REPO] Found Malla Origin: {finalIdMalla}");
                    }
                    else 
                    {
                         Console.WriteLine($"[REPO] Malla Origin NOT FOUND for Plan:{input.IdMalla} Materia:{input.IdMateria}");
                         // Si no encuentra la malla, no podemos guardar porque input.IdMalla es un PlanEstudioID, no un MallaID
                         // Esto evita guardar datos corruptos
                         return false; 
                    }
                }

                int finalIdMallaEquiv = input.IdMallaEquiv;
                if (input.IdMateriaEquiv.HasValue && input.IdMateriaEquiv.Value > 0)
                {
                    var malla = await _context.Mallas.FirstOrDefaultAsync(x => x.IdPlanEstudio == input.IdMallaEquiv && x.IdMateria == input.IdMateriaEquiv.Value);
                    if (malla != null) 
                    {
                        finalIdMallaEquiv = malla.IdMalla;
                        Console.WriteLine($"[REPO] Found Malla Dest: {finalIdMallaEquiv}");
                    }
                    else
                    {
                         Console.WriteLine($"[REPO] Malla Dest NOT FOUND for Plan:{input.IdMallaEquiv} Materia:{input.IdMateriaEquiv}");
                         return false;
                    }
                }

                var materiaEquivalente = new MateriaEquivalente
                {
                    IdMalla = finalIdMalla,
                    IdMallaEquiv = finalIdMallaEquiv,
                    PorcEquiv = input.PorcEquiv,
                    ObservacionesMateriaEquivalente = input.ObservacionesMateriaEquivalente,
                    PathautorizacionMateriaEquivalente = input.PathautorizacionMateriaEquivalente,
                    AutorizacionMateriaEquivalente = input.AutorizacionMateriaEquivalente,
                    ActivoMateriaEquivalente = input.ActivoMateriaEquivalente ?? true
                };

                Console.WriteLine($"[REPO] Adding to Context: IdMalla={materiaEquivalente.IdMalla}, IdMallaEquiv={materiaEquivalente.IdMallaEquiv}");
                _context.MateriaEquivalentes.Add(materiaEquivalente);
                var changes = await _context.SaveChangesAsync();
                Console.WriteLine($"[REPO] SaveChangesAsync result: {changes}");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[REPO] EXCEPTION in CrearMateriaEquivalente: {ex.Message} - {ex.InnerException?.Message}");
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }

        public async Task<bool> EditarMateriaEquivalente(MateriaEquivalenteInputDto input)
        {
            Console.WriteLine($"[REPO] EditarMateriaEquivalente START. ID:{input.IdMateriaEquivalente} IdMalla:{input.IdMalla}, IdMateria:{input.IdMateria}");
            try
            {
                var materiaEquivalente = await _context.MateriaEquivalentes.FindAsync(input.IdMateriaEquivalente);
                if (materiaEquivalente == null) return false;

                // 1. Resolve Materia Origen ID (IdMalla)
                if (input.IdMateria.HasValue && input.IdMateria.Value > 0)
                {
                    // Case A: User changed Plan/Materia -> input.IdMalla is PlanID
                    var mallaFromPlan = await _context.Mallas.FirstOrDefaultAsync(x => x.IdPlanEstudio == input.IdMalla && x.IdMateria == input.IdMateria.Value);
                    if (mallaFromPlan != null)
                    {
                        materiaEquivalente.IdMalla = mallaFromPlan.IdMalla;
                    }
                    else
                    {
                        // Case B: User didn't change -> input.IdMalla is already MallaID
                        // Verify if input.IdMalla is a valid MallaID
                        var existingMalla = await _context.Mallas.FirstOrDefaultAsync(x => x.IdMalla == input.IdMalla);
                        if (existingMalla != null)
                        {
                             materiaEquivalente.IdMalla = input.IdMalla;
                        }
                    }
                }

                // 2. Resolve Materia Equivalente ID (IdMallaEquiv)
                if (input.IdMateriaEquiv.HasValue && input.IdMateriaEquiv.Value > 0)
                {
                    var mallaFromPlan = await _context.Mallas.FirstOrDefaultAsync(x => x.IdPlanEstudio == input.IdMallaEquiv && x.IdMateria == input.IdMateriaEquiv.Value);
                    if (mallaFromPlan != null)
                    {
                        materiaEquivalente.IdMallaEquiv = mallaFromPlan.IdMalla;
                    }
                    else
                    {
                        var existingMalla = await _context.Mallas.FirstOrDefaultAsync(x => x.IdMalla == input.IdMallaEquiv);
                        if (existingMalla != null)
                        {
                             materiaEquivalente.IdMallaEquiv = input.IdMallaEquiv;
                        }
                    }
                }

                materiaEquivalente.PorcEquiv = input.PorcEquiv;
                materiaEquivalente.ObservacionesMateriaEquivalente = input.ObservacionesMateriaEquivalente;
                materiaEquivalente.PathautorizacionMateriaEquivalente = input.PathautorizacionMateriaEquivalente;
                materiaEquivalente.AutorizacionMateriaEquivalente = input.AutorizacionMateriaEquivalente;
                
                if (input.ActivoMateriaEquivalente.HasValue)
                {
                    Console.WriteLine($"[REPO] Updating ActivoMateriaEquivalente to: {input.ActivoMateriaEquivalente.Value}");
                    materiaEquivalente.ActivoMateriaEquivalente = input.ActivoMateriaEquivalente.Value;
                }
                else
                {
                     Console.WriteLine("[REPO] ActivoMateriaEquivalente input is null (HasValue=false). Not updating.");
                }

                _context.MateriaEquivalentes.Update(materiaEquivalente);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[REPO] Error Editing: {ex.Message}");
                return false;
            }
        }
    }
}
