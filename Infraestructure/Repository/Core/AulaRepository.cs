using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using System.Data;

namespace Infraestructure.Repository.Core
{

    public class AulaRepository : GenericCoreRepository<HorarioSemestralDto>, IAulaRepository
    {
        public AulaRepository(ZeusCoreContext context) : base(context)
        {
        }
        public string getDetallecruce(string desc)
        {
            string[] ids = desc.ToString().Split(",");
            string resultado = "";
            for (int i = 0; i < ids.Length; i++)
            {
                DataSet ds_data = Conexion.BuscarZEUS_ds("PLANIFICACION pln \ninner join COMPONENTE comp on pln.ID_TIPO_COMPONENTE=comp.ID_SUBTIPO_COMPONENTE \ninner join MALLA ma on pln.ID_MALLA=ma.ID_MALLA and comp.ID_MATERIA=ma.ID_MATERIA and comp.ID_PLAN_ESTUDIO=ma.ID_PLAN_ESTUDIO\ninner join MATERIA mat on ma.ID_MATERIA=mat.ID_MATERIA\ninner join PLAN_ESTUDIO PE ON ma.ID_PLAN_ESTUDIO = pe.ID_PLAN_ESTUDIO\ninner join CARRERA car on pe.ID_CARRERA = car.ID_CARRERA\ninner join EMPLEADO emp on pln.DNI_PROFESORC=emp.IDENTIFICACION_EMP\ninner join ESPACIOS_FISICOS ef on pln.ID_ESPACIOS_FISICOS=ef.ID_ESPACIOS_FISICOS"
                    , "pln.id_planificacion,car.CODIGO_CARRERA +' / '+ pe.CODIGO_PLAN_ESTUDIO_MALLA +' / ' + mat.codigo_materia +' - '+  mat.NOMBRE_MATERIA +' / PARALELO: '+ PLN.PARALELO +' / '+emp.APELLIDO_EMP +' '+ emp.NOMBRES_EMP --+ ' / '\nas Detalle"
                    , "where id_planificacion=" + ids[i]);
                resultado += ds_data.Tables[0].Rows[i]["Detalle"].ToString();
            }
            return resultado;
        }

        public List<HorarioSemestralDto> GetOcupacionPlanificacionSemestral(int idperiodo, int idespacio)
        {
            //lista que va a contener las horas
            List<HorarioSemestralDto> lstcontenedorhoras = new List<HorarioSemestralDto>();
            //lista contenedora de dias
            List<FechasHorarioSemetral> lstcontenedordias = new List<FechasHorarioSemetral>();
            // se extrae la franja horaria
            List<FechasHorarioSemetral> lstfechahorariosemetral = new List<FechasHorarioSemetral>();
            //0 no tiene nada,1 horarioocupado por algo de planificacion//2 horario ocupado por mi planifiacion
            List<HorasFranjaHorariaDto> listahoras = new List<HorasFranjaHorariaDto>();

            DataSet ds_horarioocupado = Conexion.ExecZeusCore("sp_OcupacionAulas", "'OS'," + idperiodo + "," + idespacio);

            foreach (DataRow rowcruce in ds_horarioocupado.Tables[0].Rows)
            {
                string[] horaInicial = rowcruce["horai"].ToString().Split(":");
                string[] horaFinal = rowcruce["horaf"].ToString().Split(":");
                string horaInicialFinal = horaInicial[0] + ":" + horaInicial[1] + " - " + horaFinal[0] + ":" + horaFinal[1];

                if (!string.IsNullOrEmpty(rowcruce["1"].ToString()))//si tiene algo
                {
                    FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                    fechahorariosemetralDto.dia = "1";
                    string resultado = "";
                    fechahorariosemetralDto.descripcion = getDetallecruce(rowcruce["1"].ToString()); ;
                    fechahorariosemetralDto.estado = true;
                    fechahorariosemetralDto.horaIF = horaInicialFinal;
                    fechahorariosemetralDto.tipoOcupado = 1;
                    fechahorariosemetralDto.habilitado = true;
                    lstfechahorariosemetral.Add(fechahorariosemetralDto);
                }
                else
                {
                    FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                    fechahorariosemetralDto.dia = "1";
                    fechahorariosemetralDto.descripcion = rowcruce["1"].ToString();
                    fechahorariosemetralDto.estado = false;
                    fechahorariosemetralDto.horaIF = horaInicialFinal;
                    fechahorariosemetralDto.tipoOcupado = 0;
                    fechahorariosemetralDto.habilitado = false;
                    lstfechahorariosemetral.Add(fechahorariosemetralDto);
                }


                if (!string.IsNullOrEmpty(rowcruce["2"].ToString()))
                {
                    FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                    fechahorariosemetralDto.dia = "2";
                    fechahorariosemetralDto.descripcion = getDetallecruce(rowcruce["2"].ToString());
                    fechahorariosemetralDto.estado = true;
                    fechahorariosemetralDto.horaIF = horaInicialFinal;
                    fechahorariosemetralDto.tipoOcupado = 1;
                    fechahorariosemetralDto.habilitado = true;
                    lstfechahorariosemetral.Add(fechahorariosemetralDto);

                }
                else
                {
                    FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                    fechahorariosemetralDto.dia = "2";
                    fechahorariosemetralDto.descripcion = rowcruce["2"].ToString();
                    fechahorariosemetralDto.estado = false;
                    fechahorariosemetralDto.horaIF = horaInicialFinal;
                    fechahorariosemetralDto.tipoOcupado = 0;
                    fechahorariosemetralDto.habilitado = false;
                    lstfechahorariosemetral.Add(fechahorariosemetralDto);
                }

                if (!string.IsNullOrEmpty(rowcruce["3"].ToString()))
                {
                    FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                    fechahorariosemetralDto.dia = "3";
                    fechahorariosemetralDto.descripcion = getDetallecruce(rowcruce["3"].ToString());
                    fechahorariosemetralDto.estado = true;
                    fechahorariosemetralDto.horaIF = horaInicialFinal;
                    fechahorariosemetralDto.tipoOcupado = 1;
                    fechahorariosemetralDto.habilitado = true;
                    lstfechahorariosemetral.Add(fechahorariosemetralDto);


                }
                else
                {
                    FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                    fechahorariosemetralDto.dia = "3";
                    fechahorariosemetralDto.descripcion = rowcruce["3"].ToString();
                    fechahorariosemetralDto.estado = false;
                    fechahorariosemetralDto.horaIF = horaInicialFinal;
                    fechahorariosemetralDto.tipoOcupado = 0;
                    fechahorariosemetralDto.habilitado = false;
                    lstfechahorariosemetral.Add(fechahorariosemetralDto);

                }

                if (!string.IsNullOrEmpty(rowcruce["4"].ToString()))
                {
                    FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                    fechahorariosemetralDto.dia = "4";
                    fechahorariosemetralDto.descripcion = getDetallecruce(rowcruce["4"].ToString());
                    fechahorariosemetralDto.estado = true;
                    fechahorariosemetralDto.horaIF = horaInicialFinal;
                    fechahorariosemetralDto.tipoOcupado = 1;
                    fechahorariosemetralDto.habilitado = true;
                    lstfechahorariosemetral.Add(fechahorariosemetralDto);

                }
                else
                {
                    FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                    fechahorariosemetralDto.dia = "4";
                    fechahorariosemetralDto.descripcion = rowcruce["4"].ToString();
                    fechahorariosemetralDto.estado = false;
                    fechahorariosemetralDto.horaIF = horaInicialFinal;
                    fechahorariosemetralDto.tipoOcupado = 0;
                    fechahorariosemetralDto.habilitado = false;
                    lstfechahorariosemetral.Add(fechahorariosemetralDto);
                }
                if (!string.IsNullOrEmpty(rowcruce["5"].ToString()))
                {
                    FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                    fechahorariosemetralDto.dia = "5";
                    fechahorariosemetralDto.descripcion = getDetallecruce(rowcruce["5"].ToString());
                    fechahorariosemetralDto.estado = true;
                    fechahorariosemetralDto.horaIF = horaInicialFinal;
                    fechahorariosemetralDto.tipoOcupado = 1;
                    fechahorariosemetralDto.habilitado = true;

                    lstfechahorariosemetral.Add(fechahorariosemetralDto);

                }
                else
                {
                    FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                    fechahorariosemetralDto.dia = "5";
                    fechahorariosemetralDto.descripcion = rowcruce["5"].ToString();
                    fechahorariosemetralDto.estado = false;
                    fechahorariosemetralDto.horaIF = horaInicialFinal;
                    fechahorariosemetralDto.tipoOcupado = 0;
                    fechahorariosemetralDto.habilitado = false;
                    lstfechahorariosemetral.Add(fechahorariosemetralDto);

                }
                if (!string.IsNullOrEmpty(rowcruce["6"].ToString()))
                {
                    FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                    fechahorariosemetralDto.dia = "6";
                    fechahorariosemetralDto.descripcion = getDetallecruce(rowcruce["6"].ToString());
                    fechahorariosemetralDto.estado = true;
                    fechahorariosemetralDto.horaIF = horaInicialFinal;
                    fechahorariosemetralDto.tipoOcupado = 1;
                    fechahorariosemetralDto.habilitado = true;
                    lstfechahorariosemetral.Add(fechahorariosemetralDto);

                }
                else
                {
                    FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                    fechahorariosemetralDto.dia = "6";
                    fechahorariosemetralDto.descripcion = rowcruce["6"].ToString();
                    fechahorariosemetralDto.estado = false;
                    fechahorariosemetralDto.horaIF = horaInicialFinal;
                    fechahorariosemetralDto.tipoOcupado = 0;
                    fechahorariosemetralDto.habilitado = false;
                    lstfechahorariosemetral.Add(fechahorariosemetralDto);

                }

                if (!string.IsNullOrEmpty(rowcruce["7"].ToString()))
                {
                    FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                    fechahorariosemetralDto.dia = "7";
                    fechahorariosemetralDto.descripcion = getDetallecruce(rowcruce["7"].ToString());
                    fechahorariosemetralDto.estado = true;
                    fechahorariosemetralDto.horaIF = horaInicialFinal;
                    fechahorariosemetralDto.tipoOcupado = 1;
                    fechahorariosemetralDto.habilitado = true;
                    lstfechahorariosemetral.Add(fechahorariosemetralDto);

                }
                else
                {
                    FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                    fechahorariosemetralDto.dia = "7";
                    fechahorariosemetralDto.descripcion = rowcruce["7"].ToString();
                    fechahorariosemetralDto.estado = false;
                    fechahorariosemetralDto.horaIF = horaInicialFinal;
                    fechahorariosemetralDto.tipoOcupado = 0;
                    fechahorariosemetralDto.habilitado = false;
                    lstfechahorariosemetral.Add(fechahorariosemetralDto);

                }
            }
            List<FechasHorarioSemetral> lstcontenedordia = new List<FechasHorarioSemetral>();
            HorarioSemestralDto contenedorhoras = new HorarioSemestralDto();
            var res = lstfechahorariosemetral.GroupBy(x => x.horaIF).ToList();
            //foreach (FechasHorarioSemetral rowdia in lstfechahorariosemetral)
            //{
            //    if (rowhora["H_I_F"].ToString() == rowdia.horaIF)
            //    {

            //        lstcontenedordia.Add(rowdia);
            //        contenedorhoras = new HorarioSemestralDto();
            //    }
            //}
            contenedorhoras = new HorarioSemestralDto();
            lstcontenedorhoras = new List<HorarioSemestralDto>();
            foreach (var item in res)
            {
                contenedorhoras.horaIF = item.Key;
                contenedorhoras.dias = item.ToList();
                lstcontenedorhoras.Add(contenedorhoras);
                lstcontenedordia = new List<FechasHorarioSemetral>();
                contenedorhoras = new HorarioSemestralDto();
            }


            return lstcontenedorhoras;
        }


        public List<AulasDto> GetAulas(int activo)
        {
            AulasDto aula = new AulasDto();
            List<AulasDto> listaAulas = new List<AulasDto>();
            DataSet ds_aulas = Conexion.BuscarZEUS_ds(
                "ESPACIOS_FISICOS ef\r\ninner join nivel_infraestructura ni\r\non ef.id_nivel_infraestructura = ni.id_nivel_infraestructura\r\ninner join infraestructura i\r\non ni.id_infraestructura = i.id_infraestructura\r\ninner join campus c\r\non i.id_campus = c.id_campus\r\ninner join tipo_espacio te\r\non ef.id_tipo_Espacio = te.id_tipo_espacio  ",
                "c.ID_CAMPUS,c.NOMBRE_CAMPUS,i.ID_INFRAESTRUCTURA,i.CODIGO_INFRAESTRUCTURA,i.NOMBRE_INFRAESTRUCTURA,ni.ID_NIVEL_INFRAESTRUCTURA,\r\nni.CODIGO_NIVEL_INFRAESTRUCTURA,ni.NOMBRE_NIVEL_INFRAESTRUCTURA,ef.ID_ESPACIOS_FISICOS,ef.CODIGO_ESPACIOS_FISICOS,te.CODIGO_TIPO_ESPACIO,te.NOMBRE_TIPO_ESPACIO,ef.CAPACIDAD_TOTAL_ESPACIOS_FISICOS,ef.ACTIVO_ESPACIOS_FISICOS",
                "where ef.ACTIVO_ESPACIOS_FISICOS = case when   " + activo + " <0 then ef.ACTIVO_ESPACIOS_FISICOS else "+  activo + " end order by 1,2,3,4,5,6");
            //DataSet ds_solicitud = Conexion.ExecZeusCore("Solicitudes", "'" + opcion + "','" + tipo + "','" + periodo + "','" + codfac + "','" + codcar + "','" + estado + "'");
            if (ds_aulas.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_aulas.Tables[0].Rows)
                {                   
                    //planificacion.idNivelEstudio = Convert.ToInt32(row["ID_NIVEL_ESTUDIO"].ToString());
                    aula.IdCampus = Convert.ToInt32(row["ID_CAMPUS"].ToString());
                    aula.NombreCampus = row["NOMBRE_CAMPUS"].ToString();
                    aula.IdInfraestructura = Convert.ToInt32(row["ID_INFRAESTRUCTURA"].ToString());
                    aula.CodigoInfraestructura = row["CODIGO_INFRAESTRUCTURA"].ToString();
                    aula.NombreInfraestructura = row["NOMBRE_INFRAESTRUCTURA"].ToString();
                    aula.IdNivelInfraestructura = Convert.ToInt32(row["ID_NIVEL_INFRAESTRUCTURA"].ToString());
                    aula.CodigoNivelInfraestructura = row["CODIGO_NIVEL_INFRAESTRUCTURA"].ToString();
                    aula.NombreNivelInfraestructura = row["NOMBRE_NIVEL_INFRAESTRUCTURA"].ToString();
                    aula.IdEspaciosFisicos = Convert.ToInt32(row["ID_ESPACIOS_FISICOS"].ToString());
                    aula.CodigoEspaciosFisicos = row["CODIGO_ESPACIOS_FISICOS"].ToString();
                    aula.CodigoTipoEspacio = row["CODIGO_TIPO_ESPACIO"].ToString();
                    aula.NombreTipoEspacio = row["NOMBRE_TIPO_ESPACIO"].ToString();
                    aula.CapacidadTotalEspaciosFisicos = Convert.ToInt32(row["CAPACIDAD_TOTAL_ESPACIOS_FISICOS"].ToString());


                    listaAulas.Add(aula);
                    aula = new AulasDto();
                }
            }
            return listaAulas;
        }
    }
}
