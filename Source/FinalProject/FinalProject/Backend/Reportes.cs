using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Backend
{
    public class Reportes
    {
        /// <summary>
        /// Utiliza una vista para generar un reporte de los asesores
        /// </summary>
        /// <returns>Una tabla con la lista de asesores</returns>
        public static DataTable RepAsesores()
        {
            String query = "SELECT * FROM reporteasesores";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();

            try
            {
                adp.Fill(tbl);
                return tbl;
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
                return null;
            }
            finally
            {
                conn.Dispose();
            }
        }
    }
}
