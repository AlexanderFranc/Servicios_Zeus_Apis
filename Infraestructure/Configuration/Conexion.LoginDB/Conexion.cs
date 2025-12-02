using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace Infraestructure.Configuration.Conexion.LoginDB
{
    public class Conexion
    {
        public static string GetEnvironmentFileName()
        {
            string? environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            return $"appsettings.{environmentName}.json";
        }

        public static SqlConnection CreateConnectionTutorias()
        {
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile(GetEnvironmentFileName(), optional: true, reloadOnChange: true);
            IConfiguration _configuration = builder.Build();
            var myconectionString = _configuration.GetConnectionString("TutoriasTitulacion");
            return new SqlConnection(myconectionString);
        }
        public static SqlConnection CreateConnectionZeusCore()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(GetEnvironmentFileName(), optional: true, reloadOnChange: true);
            IConfiguration _configuration = builder.Build();
            var myconectionString = _configuration.GetConnectionString("ZEUS");
            return new SqlConnection(myconectionString);
        }


        public static SqlConnection CreateConnectionUmas()
        {
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile(GetEnvironmentFileName(), optional: true, reloadOnChange: true);
            IConfiguration _configuration = builder.Build();
            var myconectionString = _configuration.GetConnectionString("MatriculaUmas");
            return new SqlConnection(myconectionString);
        }

        public static SqlConnection CreateConnectionUISEKAlumni()
        {
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile(GetEnvironmentFileName(), optional: true, reloadOnChange: true);
            IConfiguration _configuration = builder.Build();
            var myconectionString = _configuration.GetConnectionString("UISEKALUMNI");
            return new SqlConnection(myconectionString);
        }
        public static SqlConnection CreateConnectionNav()
        {
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile(GetEnvironmentFileName(), optional: true, reloadOnChange: true);
            IConfiguration _configuration = builder.Build();
            var myconectionString = _configuration.GetConnectionString("NAVISION");
            return new SqlConnection(myconectionString);
        }

        public static DataSet BuscarUISEKALUMNI_ds(string tabla, string campos, string condicion)
        {
            SqlDataAdapter da = BuscarUISEKALUMNI(tabla, campos, condicion);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return (ds);
        }

        public static SqlDataAdapter BuscarUISEKALUMNI(string tabla, string campos, string condicion)
        {
            SqlConnection myConnection = CreateConnectionUISEKAlumni();
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();

            string sql = "SELECT " + campos + " FROM " + tabla + " " + condicion;
            SqlCommand comando = new SqlCommand(sql, myConnection)
            {
                CommandType = CommandType.Text,
                CommandTimeout = 99999999
            };
            SqlDataAdapter lector = default(SqlDataAdapter);
            try
            {
                lector = new SqlDataAdapter(comando);
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
            return lector;

        }

        public static bool InsertarUISEKALUMNI(string tabla, string campos, string valores)
        {
            bool resultado = false;
            string sql = null;
            string messages = string.Empty;
            SqlCommand comando = new SqlCommand();
            SqlConnection myConnection = CreateConnectionUISEKAlumni();
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();
            SqlDataAdapter lector = default(SqlDataAdapter);
            sql = "INSERT INTO  " + tabla + " ( " + campos + ") values ( " + valores + ");";
            // crecion de excepcion de la consulta a la base de datos
            try
            {
                comando.Connection = myConnection;
                comando.CommandType = CommandType.Text;
                comando.CommandTimeout = 99999999;
                comando.CommandText = sql;
                lector = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();
                lector.Fill(ds);
                resultado = true;
            }
            catch (SqlException ex)
            {
                resultado = false;
                lector = null;
            }
            finally
            {

                if (myConnection.State == ConnectionState.Open)
                    myConnection.Close();
            }

            return resultado;

        }



        public static bool InsertarZeusCore(string tabla, string campos, string valores)
        {
            bool resultado = false;
            string sql = null;
            string messages = string.Empty;
            SqlCommand comando = new SqlCommand();
            SqlConnection myConnection = CreateConnectionZeusCore();
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();
            SqlDataAdapter lector = default(SqlDataAdapter);
            sql = "INSERT INTO  " + tabla + " ( " + campos + ") values ( " + valores + ");";
            // crecion de excepcion de la consulta a la base de datos
            try
            {
                comando.Connection = myConnection;
                comando.CommandType = CommandType.Text;
                comando.CommandTimeout = 99999999;
                comando.CommandText = sql;
                lector = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();
                lector.Fill(ds);
                resultado = true;
            }
            catch (SqlException ex)
            {
                resultado = false;
                lector = null;
            }
            finally
            {

                if (myConnection.State == ConnectionState.Open)
                    myConnection.Close();
            }

            return resultado;

        }

        public static string deleteZeus(string tabla, string condicion)
        {
            string message = string.Empty;

            SqlConnection myConnection = CreateConnectionZeusCore();
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();

            string sql = "DELETE " + tabla + " WHERE " + condicion + ";";
            SqlCommand comando = new SqlCommand(sql, myConnection)
            {
                CommandType = CommandType.Text,
                CommandTimeout = 99999999
            };
            // crecion de excepcion de la consulta a la base de datos
            SqlDataAdapter lector = default(SqlDataAdapter);
            try
            {
                lector = new SqlDataAdapter(comando);
                comando.Connection = myConnection;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                message = "1";

            }
            catch (SqlException ex)
            {
                message = "-1";
            }
            finally
            {

                if (myConnection.State == ConnectionState.Open)
                    myConnection.Close();
            }
            return message;
        }
        public static bool ActualizarZeus(string tabla, string campos, string condicion)
        {
            bool correcto = false;
            string messages = string.Empty;
            SqlConnection myConnection = CreateConnectionZeusCore();
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();

            string sql = "UPDATE " + tabla + " SET " + campos + " " + condicion + ";";
            // crecion de excepcion de la consulta a la base de datos
            try
            {
                SqlCommand comando = new SqlCommand
                {
                    Connection = myConnection,
                    CommandText = sql
                };
                comando.ExecuteNonQuery();
                correcto = true;
            }
            catch (SqlException ex)
            {
                correcto = false;
            }
            finally
            {

                if (myConnection.State == ConnectionState.Open)
                    myConnection.Close();
            }

            return correcto;

        }




        public static bool ActualizarUISEKALUMNI(string tabla, string campos, string condicion)
        {
            bool correcto = false;
            string messages = string.Empty;
            SqlConnection myConnection = CreateConnectionUISEKAlumni();
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();

            string sql = "UPDATE " + tabla + " SET " + campos + " " + condicion + ";";
            // crecion de excepcion de la consulta a la base de datos
            try
            {
                SqlCommand comando = new SqlCommand
                {
                    Connection = myConnection,
                    CommandText = sql
                };
                comando.ExecuteNonQuery();
                correcto = true;
            }
            catch (SqlException ex)
            {
                correcto = false;
            }
            finally
            {

                if (myConnection.State == ConnectionState.Open)
                    myConnection.Close();
            }

            return correcto;

        }
        public static bool ActualizarNavision(string tabla, string campos, string condicion)
        {
            bool correcto = false;
            string messages = string.Empty;
            SqlConnection myConnection = CreateConnectionNav();
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();

            string sql = "UPDATE " + tabla + " SET " + campos + " " + condicion + ";";
            // crecion de excepcion de la consulta a la base de datos
            try
            {
                SqlCommand comando = new SqlCommand
                {
                    Connection = myConnection,
                    CommandText = sql
                };
                comando.ExecuteNonQuery();
                correcto = true;
            }
            catch (SqlException ex)
            {
                correcto = false;
            }
            finally
            {

                if (myConnection.State == ConnectionState.Open)
                    myConnection.Close();
            }

            return correcto;

        }






        public static bool InsertarNUEVOUISEKALUMNI(string script)
        {
            bool resultado = false;
            string sql = null;
            string messages = string.Empty;
            SqlCommand comando = new SqlCommand();
            SqlConnection myConnection = CreateConnectionUISEKAlumni();
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();
            SqlDataAdapter lector = default(SqlDataAdapter);
            sql = script;
            // crecion de excepcion de la consulta a la base de datos
            try
            {
                comando.Connection = myConnection;
                comando.CommandType = CommandType.Text;
                comando.CommandTimeout = 99999999;
                comando.CommandText = sql;
                lector = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();
                lector.Fill(ds);
                resultado = true;
            }
            catch (SqlException ex)
            {
                resultado = false;
                lector = null;
            }
            finally
            {

                if (myConnection.State == ConnectionState.Open)
                    myConnection.Close();
            }

            return resultado;

        }

        public static bool ExecUISEKALUMNI(string sp, string campos)//, string condicion)
        {
            bool correcto = false;
            string messages = string.Empty;
            SqlConnection myConnection = CreateConnectionUISEKAlumni();
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();

            //string sql = "UPDATE " + tabla + " SET " + campos + " " + condicion + ";";
            string sql = "exec " + sp + " " + campos + ";";
            // crecion de excepcion de la consulta a la base de datos
            try
            {
                SqlCommand comando = new SqlCommand
                {
                    Connection = myConnection,
                    CommandText = sql
                };
                comando.ExecuteNonQuery();
                correcto = true;
            }
            catch (SqlException ex)
            {
                correcto = false;
            }
            finally
            {

                if (myConnection.State == ConnectionState.Open)
                    myConnection.Close();
            }

            return correcto;

        }

        public static DataSet BuscarTutorias_ds(string tabla, string campos, string condicion)
        {
            SqlDataAdapter da = BuscarTutorias(tabla, campos, condicion);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return (ds);
        }
        private static SqlDataAdapter BuscarTutorias(string tabla, string campos, string condicion)
        {
            SqlConnection myConnection = CreateConnectionTutorias();
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();

            string sql = "SELECT " + campos + " FROM " + tabla + " " + condicion;
            SqlCommand comando = new SqlCommand(sql, myConnection)
            {
                CommandType = CommandType.Text,
                CommandTimeout = 99999999
            };
            SqlDataAdapter lector = default(SqlDataAdapter);
            try
            {
                lector = new SqlDataAdapter(comando);
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
            return lector;

        }

        public static string ActualizarTutorias(string tabla, string campos, string condicion)
        {
            string messages = string.Empty;
            SqlConnection myConnection = CreateConnectionTutorias();
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();

            string sql = "UPDATE " + tabla + " SET " + campos + " " + condicion + ";";
            // crecion de excepcion de la consulta a la base de datos
            try
            {
                SqlCommand comando = new SqlCommand
                {
                    Connection = myConnection,
                    CommandText = sql
                };

                comando.ExecuteNonQuery();

                messages = "1";

            }
            catch (SqlException ex)
            {
                messages = "-1";
            }
            finally
            {

                if (myConnection.State == ConnectionState.Open)
                    myConnection.Close();
            }
            return messages;

        }
        public static DataSet BuscarUmas_ds(string tabla, string campos, string condicion)
        {
            SqlDataAdapter da = BuscarUmas(tabla, campos, condicion);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return (ds);
        }
        private static SqlDataAdapter BuscarUmas(string tabla, string campos, string condicion)
        {
            SqlConnection myConnection = CreateConnectionUmas();
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();

            string sql = "SELECT " + campos + " FROM " + tabla + " " + condicion;
            SqlCommand comando = new SqlCommand(sql, myConnection)
            {
                CommandType = CommandType.Text,
                CommandTimeout = 99999999
            };
            SqlDataAdapter lector = default(SqlDataAdapter);
            try
            {
                lector = new SqlDataAdapter(comando);
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
            return lector;

        }

        public static DataSet BuscarStoreProcedure_UMAS_ds(string storeprocedure, string campos)
        {
            SqlDataAdapter da = BuscarStoreProcedure_UMAS(storeprocedure, campos);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return (ds);
        }

        public static SqlDataAdapter BuscarStoreProcedure_UMAS(string storeprocedure, string campos)
        {
            SqlConnection myConnection = CreateConnectionUmas();
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();

            string sql = "EXECUTE " + storeprocedure + " " + campos;
            SqlDataAdapter lector = default(SqlDataAdapter);
            SqlCommand comando = new SqlCommand(sql, myConnection)
            {
                Connection = myConnection,
                CommandType = CommandType.Text,
                CommandTimeout = 99999999
            };
            try
            {
                lector = new SqlDataAdapter(comando);
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
            return lector;

        }

        public static bool InsertarUmas(string tabla, string campos, string valores)
        {
            bool resultado = false;
            string sql = null;
            string messages = string.Empty;
            SqlCommand comando = new SqlCommand();
            SqlConnection myConnection = CreateConnectionUmas();
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();
            SqlDataAdapter lector = default(SqlDataAdapter);
            sql = "INSERT INTO  " + tabla + " ( " + campos + ") values ( " + valores + ");";
            // crecion de excepcion de la consulta a la base de datos
            try
            {
                comando.Connection = myConnection;
                comando.CommandType = CommandType.Text;
                comando.CommandTimeout = 99999999;
                comando.CommandText = sql;
                lector = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();
                lector.Fill(ds);
                resultado = true;
            }
            catch (SqlException ex)
            {
                resultado = false;
                lector = null;
            }
            finally
            {

                if (myConnection.State == ConnectionState.Open)
                    myConnection.Close();
            }

            return resultado;

        }
        public static bool ActualizarUMAS(string tabla, string campos, string condicion)
        {
            bool correcto = false;
            string messages = string.Empty;
            SqlConnection myConnection = CreateConnectionUmas();
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();

            string sql = "UPDATE " + tabla + " SET " + campos + " " + condicion + ";";
            // crecion de excepcion de la consulta a la base de datos
            try
            {
                SqlCommand comando = new SqlCommand
                {
                    Connection = myConnection,
                    CommandText = sql
                };
                comando.ExecuteNonQuery();
                correcto = true;
            }
            catch (SqlException ex)
            {
                correcto = false;
            }
            finally
            {

                if (myConnection.State == ConnectionState.Open)
                    myConnection.Close();
            }

            return correcto;

        }

        public static DataSet NavUisekEcuador_ds(string tabla, string campos, string condicion)
        {
            SqlDataAdapter da = NavUisekEcuador(tabla, campos, condicion);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return (ds);
        }

        private static SqlDataAdapter NavUisekEcuador(string tabla, string campos, string condicion)
        {
            SqlConnection myConnection = CreateConnectionNav();
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();

            string sql = "SELECT " + campos + " FROM " + tabla + " " + condicion;
            SqlCommand comando = new SqlCommand(sql, myConnection)
            {
                CommandType = CommandType.Text,
                CommandTimeout = 99999999
            };
            SqlDataAdapter lector = default(SqlDataAdapter);
            try
            {
                lector = new SqlDataAdapter(comando);
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
            return lector;
        }

        public static bool InsertarNAVISION(string tabla, string campos, string valores)
        {
            //aaaa
            bool resultado = false;
            string sql = null;
            string messages = string.Empty;
            SqlCommand comando = new SqlCommand();
            SqlConnection myConnection = CreateConnectionNav();
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();
            SqlDataAdapter lector = default(SqlDataAdapter);
            sql = "INSERT INTO  " + tabla + " ( " + campos + ") values ( " + valores + ");";
            // crecion de excepcion de la consulta a la base de datos
            try
            {
                comando.Connection = myConnection;
                comando.CommandType = CommandType.Text;
                comando.CommandTimeout = 99999999;
                comando.CommandText = sql;
                lector = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();
                lector.Fill(ds);
                resultado = true;
            }
            catch (SqlException ex)
            {
                resultado = false;
                lector = null;
            }
            finally
            {

                if (myConnection.State == ConnectionState.Open)
                    myConnection.Close();
            }

            return resultado;

        }


        public static DataSet ExecZeusCore(string sp, string campos)
        {
            SqlConnection myConnection = CreateConnectionZeusCore();
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();

            string sql = "exec " + sp + " " + campos + ";";
            SqlCommand comando = new SqlCommand(sql, myConnection)
            {
                CommandType = CommandType.Text,
                CommandTimeout = 99999999
            };
            SqlDataAdapter lector = default(SqlDataAdapter);
            try
            {
                lector = new SqlDataAdapter(comando);
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

            DataSet ds = new DataSet();
            lector.Fill(ds);
            return (ds);
        }
        public static DataSet ExecNavision(string sp, string campos)
        {
            SqlConnection myConnection = CreateConnectionNav();
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();

            string sql = "exec " + sp + " " + campos + ";";
            SqlCommand comando = new SqlCommand(sql, myConnection)
            {
                CommandType = CommandType.Text,
                CommandTimeout = 99999999
            };
            SqlDataAdapter lector = default(SqlDataAdapter);
            try
            {
                lector = new SqlDataAdapter(comando);
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

            DataSet ds = new DataSet();
            lector.Fill(ds);
            return (ds);
        }
        public static DataSet BuscarZEUS_ds(string tabla, string campos, string condicion)
        {
            SqlDataAdapter da = BuscarZEUS(tabla, campos, condicion);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return (ds);
        }

        public static SqlDataAdapter BuscarZEUS(string tabla, string campos, string condicion)
        {
            SqlConnection myConnection = CreateConnectionZeusCore();
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();

            string sql = "SELECT " + campos + " FROM " + tabla + " " + condicion;
            SqlCommand comando = new SqlCommand(sql, myConnection)
            {
                CommandType = CommandType.Text,
                CommandTimeout = 99999999
            };
            SqlDataAdapter lector = default(SqlDataAdapter);
            try
            {
                lector = new SqlDataAdapter(comando);
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
            return lector;

        }


    }
}
