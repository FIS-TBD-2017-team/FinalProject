using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Backend
{
    public class Carrera
    {
        public int IdCarrera { get; set; }
        public String Nombre { get; set; }
        public String NombreCorto { get; set; }

        public Carrera()
        {

        }
        public Carrera(int IdCarrera)
        {
            this.IdCarrera = IdCarrera;
        }
        public Carrera(int IdCarrera, String Nombre, String NombreCorto)
        {
            this.IdCarrera = IdCarrera;
            this.Nombre = Nombre;
            this.NombreCorto = NombreCorto;
        }

        /// <summary>
        /// Toma como parámetro un objeto DataRow generado por MySQL
        /// y regresa un objeto de tipo Carrera.
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static Carrera FromDataRow(DataRow dr)
        {
            return new Carrera(
                int.Parse(dr["idCarrera"].ToString()),
                dr["Carrera"].ToString(),
                dr["CarreraCorto"].ToString()
            );
        }

        /// <summary>
        /// Regresa la información de una carrera dado su id.
        /// </summary>
        /// <param name="IdCarrera"></param>
        /// <returns></returns>
        public static Carrera Select(int IdCarrera)
        {
            String query = "SELECT * FROM Carreras WHERE idCarrera = @idcarrera LIMIT 1";

            MySqlConnection conn = Connection.SICE();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idcarrera", IdCarrera);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();

            try
            {
                adp.Fill(tbl);
                return Carrera.FromDataRow(tbl.Rows[0]);
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
