using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Backend
{
    public class DetalleRespuesta
    {
        public int IdRespuesta { get; set; }
        public String NoControl { get; set; }

        public DetalleRespuesta(int IdRespuesta, String NoControl)
        {
            this.IdRespuesta = IdRespuesta;
            this.NoControl = NoControl;
        }

        /// <summary>
        /// Toma como parámetro un objeto DataRow generado por MySQL
        /// y regresa un objeto de tipo DetalleRespuesta.
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static DetalleRespuesta FromDataRow(DataRow dr)
        {
            return new DetalleRespuesta(
                int.Parse(dr["idrespuesta"].ToString()),
                dr["nocontrol"].ToString()
            );
        }

        /// <summary>
        /// Ingresa en la base de datos un registro de tipo DetalleRespuesta.
        /// Asigna un asesor como propuesto para una asesoría a través de su
        /// número de control.
        /// </summary>
        /// <param name="dr"></param>
        public static void Insert(DetalleRespuesta dr)
        {
            String query = "INSERT INTO detallerespuesta VALUES (@idrespuesta,@nocontrol)";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@idrespuesta", dr.IdRespuesta);
            cmd.Parameters.AddWithValue("@nocontrol", dr.NoControl);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
                return;
            }
            finally
            {
                conn.Dispose();
            }
        }
    }
}
