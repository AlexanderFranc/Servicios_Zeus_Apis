using System.Data;
using System.Linq.Expressions;
using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.EntityFrameworkCore;
using StackExchange.Redis;

namespace Infraestructure.Repository.Core
{
    public class HorarioSemetralRepository : GenericCoreRepository<HorarioSemestralDto>, IHorarioSemestralRepository
    {
        public HorarioSemetralRepository(ZeusCoreContext context) : base(context)
        {
        }

        public string DeleteHorarioSemestralPlanificado(int idplanidicacion, int dia, string horaI, string horaF)
        {
            string ds_data = Conexion.deleteZeus("HORARIO", "ID_PLANIFICACION=" + idplanidicacion + " and ID_DIA=" + dia + " and HORA_INI='" + horaI + "' and HORA_FIN='" + horaF + "'");
            return ds_data;
        }

        public string getDetallecruce(string desc)
        {
            string[] ids = desc.ToString().Split(",");
            string resultado = "";
            for (int i = 0; i < ids.Length; i++)
            {
                DataSet ds_data = Conexion.BuscarZEUS_ds("PLANIFICACION pln \r\ninner join COMPONENTE comp on pln.ID_TIPO_COMPONENTE=comp.ID_SUBTIPO_COMPONENTE \r\ninner join MALLA ma on pln.ID_MALLA=ma.ID_MALLA and comp.ID_MATERIA=ma.ID_MATERIA and comp.ID_PLAN_ESTUDIO=ma.ID_PLAN_ESTUDIO\r\ninner join MATERIA mat on ma.ID_MATERIA=mat.ID_MATERIA\r\ninner join EMPLEADO emp on pln.DNI_PROFESORC=emp.IDENTIFICACION_EMP\r\ninner join ESPACIOS_FISICOS ef on pln.ID_ESPACIOS_FISICOS=ef.ID_ESPACIOS_FISICOS", "pln.id_planificacion,emp.APELLIDO_EMP +' '+ emp.NOMBRES_EMP + ' / '+mat.codigo_materia +' - '+  mat.NOMBRE_MATERIA +' / '+ef.CODIGO_ESPACIOS_FISICOS +' - '+ef.DESCRIPCION_ESPACIOS_FISICOS as Detalle", "where id_planificacion=" + ids[i]);
                resultado += ds_data.Tables[0].Rows[i]["Detalle"].ToString();
            }
            return resultado;
        }


        //tipohorario si es edicion E si es Nuevo N
        public List<HorarioSemestralDto> GetHorariosPlanificacionSemestral(string tipohorario,int idplanestudio, int? idplanificacion,int idperiodo,int idperiodicidad,int idmateria,int idsubtipocomponente,int idespacio,string ceduladocente)
        {
            //if (idplanificacion == 0)
            //    idplanificacion = null;
            //idplanificacion = 2531;
            //lista que va a contener las horas
            List<HorarioSemestralDto> lstcontenedorhoras=new List<HorarioSemestralDto>();
            //lista contenedora de dias
            List<FechasHorarioSemetral> lstcontenedordias = new List<FechasHorarioSemetral>();
            // se extrae la franja horaria
            List<FechasHorarioSemetral> lstfechahorariosemetral=new List<FechasHorarioSemetral> ();
            //0 no tiene nada,1 horarioocupado por algo de planificacion//2 horario ocupado por mi planifiacion
            List<HorasFranjaHorariaDto> listahoras = new List<HorasFranjaHorariaDto>();

            DataSet ds_horas = Conexion.ExecZeusCore("horasfranjahoraria", idplanestudio.ToString());
            //DataSet ds_horarioocupado= Conexion.ExecZeusCore("HorariosPLanificacion", "'S',"+10+","+4+","+420+","+ 1+"," +68 +","+"'1707833354','2023-06-04','2023-07-11'");
            DataSet ds_horarioocupado = Conexion.ExecZeusCore("HorariosPLanificacion", "'S'," + idperiodo + "," + idperiodicidad + "," + idmateria + "," + idsubtipocomponente + "," + idespacio + "," + "'"+ ceduladocente + "','2023-06-04','2023-07-11',"+ idplanificacion);
            foreach (DataRow rowhora in ds_horas.Tables[0].Rows)
            {
                foreach (DataRow rowcruce in ds_horarioocupado.Tables[0].Rows)
                {
                    string []horaInicial = rowcruce["horai"].ToString().Split(":");
                    string[] horaFinal = rowcruce["horaf"].ToString().Split(":");
                    
                    if (Convert.ToInt32(rowhora["H_I"].ToString()) == Convert.ToInt32(horaInicial[0]) && Convert.ToInt32(rowhora["H_F"].ToString()) == Convert.ToInt32(horaFinal[0]) )
                    {
                        if (!string.IsNullOrEmpty(rowcruce["1"].ToString()))//si tiene algo
                        {
                            FechasHorarioSemetral fechahorariosemetralDto = new FechasHorarioSemetral();
                            fechahorariosemetralDto.dia = "1";
                            string resultado = "";                           
                            fechahorariosemetralDto.descripcion = getDetallecruce(rowcruce["1"].ToString()); ;
                            fechahorariosemetralDto.estado = true;
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
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
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
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
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
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
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
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
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
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
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
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
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
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
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
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
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
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
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
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
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
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
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
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
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
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
                            fechahorariosemetralDto.horaIF = rowhora["H_I_F"].ToString();
                            fechahorariosemetralDto.tipoOcupado = 0;
                            fechahorariosemetralDto.habilitado = false;
                            lstfechahorariosemetral.Add(fechahorariosemetralDto);

                        }

                    }
                }
            }
            List<FechasHorarioSemetral> lstcontenedordia = new List<FechasHorarioSemetral>();
            HorarioSemestralDto contenedorhoras = new HorarioSemestralDto();
            foreach (DataRow rowhora in ds_horas.Tables[0].Rows)
            {
                
                foreach (FechasHorarioSemetral rowdia in lstfechahorariosemetral)
                {
                    if (rowhora["H_I_F"].ToString() == rowdia.horaIF)
                    {
                       
                        lstcontenedordia.Add(rowdia);
                        contenedorhoras=new HorarioSemestralDto();
                    }
                }
                contenedorhoras.horaIF = rowhora["H_I_F"].ToString();
                contenedorhoras.dias = lstcontenedordia;
                lstcontenedorhoras.Add(contenedorhoras);
                lstcontenedordia=new List<FechasHorarioSemetral>();
            }
            
            
            if (tipohorario=="E")
            {
                DataSet ds_planificacion = Conexion.BuscarZEUS_ds("HORARIO", "*", "where ID_PLANIFICACION=" + idplanificacion);
                foreach (HorarioSemestralDto rowhoras in lstcontenedorhoras)
                {
                    foreach (DataRow rowdia in ds_planificacion.Tables[0].Rows)
                    {
                        string[] horaI = rowdia["HORA_INI"].ToString().Split(":");
                        string[] horaF = rowdia["HORA_FIN"].ToString().Split(":");
                        string hora = horaI[0] + ":" + horaI[1] + " - " + horaF[0] + ":" + horaF[1];
                        if (hora == rowhoras.horaIF)
                        {

                            foreach (FechasHorarioSemetral rowdiaplan in rowhoras.dias)
                            {
                                string dia = rowdia["ID_DIA"].ToString();
                                if (Convert.ToInt32(rowdia["ID_DIA"]) == Convert.ToInt32(rowdiaplan.dia))
                                {
                                    //var diaObject = rowdiaplan.Where(x => x.dia == rowdiaplan.dia).FirstOrDefault();
                                    if (rowdiaplan != null)
                                    {
                                        if (string.IsNullOrEmpty(rowdiaplan.descripcion))
                                        {
                                            rowdiaplan.estado = false;
                                        }
                                        else
                                        {
                                            rowdiaplan.descripcion = "";
                                            rowdiaplan.tipoOcupado = 2;
                                            rowdiaplan.estado = true;
                                            rowdiaplan.habilitado = false;
                                        }

                                    }
                                }

                            }
                        }
                    }
                }
            }
            return lstcontenedorhoras;
        }

    }
}
