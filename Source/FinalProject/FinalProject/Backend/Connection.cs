using System;
using System.Data;

using MySql.Data.MySqlClient;

namespace MainProject.Backend
{
    public class Connection
    {
        private static MySqlConnection conn = null;

        /// <summary>
        /// Intenta hacer una conexión al servidor de base de datos
        /// usando los valores especificados en el archivo de configuración
        /// del proyecto.
        /// </summary>
        /// <returns>true if it succesfully connects to the server</returns>
        public static bool Connect()
        {
            String connString =
                String.Format("Server={0};Port={1};Database=TEST;Uid={2};Pwd={3}",
                                  FinalProject.Properties.Settings.Default.Server,
                                  FinalProject.Properties.Settings.Default.Port,
                                  FinalProject.Properties.Settings.Default.User,
                                  FinalProject.Properties.Settings.Default.Pass);
            conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        /// <summary>
        /// Se encarga de cerrar la conexión.
        /// </summary>
        public static void Disconnect()
        {
            if (conn != null)
            {
                conn.Close();
                conn.Dispose();
            }
        }

        /// <summary>
        /// Toma como parámetro una consulta SQL empaquetada en un objeto MySQLCommand y
        /// la ejecuta.
        /// Retorna la tabla de resultados.
        /// </summary>
        /// <param name="cmd">Consulta SQL</param>
        /// <returns>Tabla de resultados</returns>
        public static DataTable Query(MySqlCommand cmd)
        {
            try
            {
                if (Connect())
                {
                    cmd.Connection = conn;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataTable tbl = new DataTable();
                    adp.Fill(tbl);

                    return tbl;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        /// <summary>
        /// Toma como parámetro una consulta SQL empaquetada en un objeto MySQLCommand y
        /// la ejecuta.
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public static bool Execute(MySqlCommand cmd)
        {
            try
            {
                if (Connect())
                {
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    Disconnect();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
