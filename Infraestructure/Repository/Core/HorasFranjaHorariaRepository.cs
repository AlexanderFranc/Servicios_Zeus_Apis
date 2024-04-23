using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
using Infraestructure.Configuration.Zeus.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Core
{
    public class HorasFranjaHorariaRepository : IHorasFranjaHoraria
    {

        public List<HorasFranjaHorariaDto> GetHorasFranjaHoraria(int idplanestudio)
        {
            List<HorasFranjaHorariaDto> listahoras = new List<HorasFranjaHorariaDto>();
            DataSet ds_horas = Conexion.ExecZeusCore("horasfranjahoraria", idplanestudio.ToString());
            HorasFranjaHorariaDto horasDto = new HorasFranjaHorariaDto();
            if (ds_horas.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_horas.Tables[0].Rows)
                {
                    horasDto.HoraInicio= Convert.ToInt32(row["H_I"].ToString());
                    horasDto.HoraFin = Convert.ToInt32(row["H_F"].ToString());
                    horasDto.HoraInicioFin = row["H_I_F"].ToString();
                    listahoras.Add(horasDto);
                    horasDto = new HorasFranjaHorariaDto();

                }
            }
            return  listahoras.ToList();

        }
        public string EliminarHorasFranjaHoraria(int id)
        {
            Conexion.deleteZeus("HORARIO", "ID_PLANIFICACION = " + id);

            return "Correcto";
        }

    }
}