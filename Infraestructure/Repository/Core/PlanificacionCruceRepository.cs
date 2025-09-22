using Core.Dtos.Core;
using Core.Entidades.Core;
using Core.Interfaces.Core;
using Infraestructure.Configuration.Conexion.LoginDB;
using Infraestructure.Configuration.Zeus.Core;
using Infraestructure.Repository.Generico;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Infraestructure.Repository.Core
{
    public class PlanificacionCruceRepository : GenericCoreRepository<PlanificacionCruceDto>, IPlanificacionCruceRepository
    {
        public PlanificacionCruceRepository(ZeusCoreContext context) : base(context)
        {
        }

        public List<PlanificacionCruceDto> GetPlanificacionCruce(string opcion, int idplanificacion, int idperiodo, int idespaciosfisicos, string codprofe, int idMalla)
        {
            PlanificacionCruceDto cruce = new PlanificacionCruceDto();
            List<PlanificacionCruceDto> listaCruce = new List<PlanificacionCruceDto>();
            DataSet ds_cruce = Conexion.ExecZeusCore("sp_ValidaCruceHorario", "'V'," + idplanificacion + "," + idperiodo + "," + idespaciosfisicos + "," + "'" + codprofe + "'," + idMalla);
            if (ds_cruce.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_cruce.Tables[0].Rows)
                {
                    cruce.Cedula = row["CEDULA"].ToString();
                    cruce.Docente = row["DOCENTE"].ToString();
                    cruce.CodCarrera = row["CODIGO_CARRERA"].ToString();
                    cruce.Carrera = row["NOMBRE_CARRERA"].ToString();
                    cruce.Malla = row["CODIGO_PLAN_ESTUDIO_MALLA"].ToString();
                    cruce.Codigo = row["CODIGO"].ToString();
                    cruce.Materia = row["MATERIA"].ToString();
                    cruce.Aula = row["AULA"].ToString();
                    cruce.Dia = row["DIA"].ToString();
                    cruce.HoraIni = row["HORA_INI"].ToString();
                    cruce.HoraFin = row["HORA_FIN"].ToString();
                    cruce.Periodo = row["CODIGO_PERIODO"].ToString();

                    listaCruce.Add(cruce);
                    cruce = new PlanificacionCruceDto();
                }
            }
            return listaCruce;
        }

        public List<PlanificacionCruceDto> GetPlanificacionCruceModular(string opcion, int idperiodo, string codprofe, List<HorarioModularDto> horarioTabla, int idPlanificacion, int idMalla)
        {
            PlanificacionCruceDto cruce = new PlanificacionCruceDto();
            List<PlanificacionCruceDto> listaCruce = new List<PlanificacionCruceDto>();


            var dtTablaHorario = new DataTable();
            dtTablaHorario.Columns.Add("Id_Espacio_fisico", typeof(int));
            dtTablaHorario.Columns.Add("Fecha", typeof(DateTime));
            dtTablaHorario.Columns.Add("HoraI", typeof(string));
            dtTablaHorario.Columns.Add("HoraF", typeof(string));
            foreach (var item in horarioTabla)
            {
                dtTablaHorario.Rows.Add(item.IdEspacioFisico, item.FechaPlanificada, item.HoraI, item.HoraF);
            }

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration _configuration = builder.Build();
            var myconectionString = _configuration.GetConnectionString("ZEUS");

            SqlConnection myConnection = new SqlConnection(myconectionString);

            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();

            //string sql = "exec " + sp + " " + campos + ";";}
            var cmd = new SqlCommand("sp_ValidaCruceHorarioFechas", myConnection)
            {
                CommandType = CommandType.Text,
                CommandTimeout = 99999999
            };
            string? idPlani = idPlanificacion == 0 ? null : "" + idPlanificacion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@opcion", opcion);
            cmd.Parameters.AddWithValue("@id_periodo", idperiodo);
            cmd.Parameters.AddWithValue("@codprof", codprofe);
            cmd.Parameters.AddWithValue("@horariof", dtTablaHorario);
            cmd.Parameters.AddWithValue("@idPlanificacion", idPlani);
            cmd.Parameters.AddWithValue("@idMalla", idMalla);


            SqlDataAdapter lector = default(SqlDataAdapter);
            try
            {
                lector = new SqlDataAdapter(cmd);
            }
            catch (Exception ex)
            {
                lector = null;
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                    myConnection.Close();
            }

            DataSet ds_cruce = new DataSet();
            lector.Fill(ds_cruce);
            //return (ds);

            //DataSet ds_cruce = ds

            //DataSet ds_cruce = Conexion.ExecZeusCore("sp_ValidaCruceHorarioFechas", "'VM'," + idperiodo + ",'" + codprofe + "'," + dtTablaHorario);
            if (ds_cruce.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_cruce.Tables[0].Rows)
                {
                    cruce.Cedula = row["CEDULA"].ToString();
                    cruce.Docente = row["DOCENTE"].ToString();
                    cruce.CodCarrera = row["CODIGO_CARRERA"].ToString();
                    cruce.Carrera = row["NOMBRE_CARRERA"].ToString();
                    cruce.Malla = row["CODIGO_PLAN_ESTUDIO_MALLA"].ToString();
                    cruce.Codigo = row["CODIGO"].ToString();
                    cruce.Materia = row["MATERIA"].ToString();
                    cruce.Aula = row["AULA"].ToString();
                    cruce.Dia = row["DIA"].ToString();
                    cruce.HoraIni = row["HORA_INI"].ToString();
                    cruce.HoraFin = row["HORA_FIN"].ToString();
                    cruce.Periodo = row["CODIGO_PERIODO"].ToString();


                    listaCruce.Add(cruce);
                    cruce = new PlanificacionCruceDto();
                }
            }
            return listaCruce;
        }


        public List<PlanificacionCruceDto> GetPlanificacionCruceSemMod(string opcion, int idperiodo, string codprofe, List<HorarioSemDto> horarioTabla, int idPlanificacion, int idMalla)
        {
            PlanificacionCruceDto cruce = new PlanificacionCruceDto();
            List<PlanificacionCruceDto> listaCruce = new List<PlanificacionCruceDto>();


            var dtTablaHorario = new DataTable();
            dtTablaHorario.Columns.Add("Id_Espacio_fisico", typeof(int));
            dtTablaHorario.Columns.Add("IdDia", typeof(int));
            dtTablaHorario.Columns.Add("HoraI", typeof(string));
            dtTablaHorario.Columns.Add("HoraF", typeof(string));
            foreach (var item in horarioTabla)
            {
                dtTablaHorario.Rows.Add(item.IdEspacioFisico, item.IdDia, item.HoraI, item.HoraF);
            }

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration _configuration = builder.Build();
            var myconectionString = _configuration.GetConnectionString("ZEUS");

            SqlConnection myConnection = new SqlConnection(myconectionString);

            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();

            //string sql = "exec " + sp + " " + campos + ";";}
            var cmd = new SqlCommand("sp_ValidaCruceHorarioSemestral", myConnection)
            {
                CommandType = CommandType.Text,
                CommandTimeout = 99999999
            };
            string? idPlani = idPlanificacion == 0 ? null : "" + idPlanificacion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@opcion", opcion);
            cmd.Parameters.AddWithValue("@id_periodo", idperiodo);
            cmd.Parameters.AddWithValue("@codprof", codprofe);
            cmd.Parameters.AddWithValue("@horarioS", dtTablaHorario);
            cmd.Parameters.AddWithValue("@idPlanificacion", idPlani);
            cmd.Parameters.AddWithValue("@idMalla", idMalla);


            SqlDataAdapter lector = default(SqlDataAdapter);
            try
            {
                lector = new SqlDataAdapter(cmd);
            }
            catch (Exception ex)
            {
                lector = null;
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                    myConnection.Close();
            }

            DataSet ds_cruce = new DataSet();
            lector.Fill(ds_cruce);
            //return (ds);

            //DataSet ds_cruce = ds

            //DataSet ds_cruce = Conexion.ExecZeusCore("sp_ValidaCruceHorarioFechas", "'VM'," + idperiodo + ",'" + codprofe + "'," + dtTablaHorario);
            if (ds_cruce.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds_cruce.Tables[0].Rows)
                {
                    cruce.Cedula = row["CEDULA"].ToString();
                    cruce.Docente = row["DOCENTE"].ToString();
                    cruce.CodCarrera = row["CODIGO_CARRERA"].ToString();
                    cruce.Carrera = row["NOMBRE_CARRERA"].ToString();
                    cruce.Malla = row["CODIGO_PLAN_ESTUDIO_MALLA"].ToString();
                    cruce.Codigo = row["CODIGO"].ToString();
                    cruce.Materia = row["MATERIA"].ToString();
                    cruce.Aula = row["AULA"].ToString();
                    cruce.Dia = row["DIA"].ToString();
                    cruce.HoraIni = row["HORA_INI"].ToString();
                    cruce.HoraFin = row["HORA_FIN"].ToString();
                    cruce.Periodo = row["CODIGO_PERIODO"].ToString();


                    listaCruce.Add(cruce);
                    cruce = new PlanificacionCruceDto();
                }
            }
            return listaCruce;
        }
    }
}
