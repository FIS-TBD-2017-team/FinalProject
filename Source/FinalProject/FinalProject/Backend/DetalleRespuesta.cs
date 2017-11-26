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

        public static DetalleRespuesta FromDataRow(DataRow dr)
        {
            return new DetalleRespuesta(
                int.Parse(dr["idrespuesta"].ToString()),
                dr["nocontrol"].ToString()
            );
        }

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
                return;
            }
            finally
            {
                conn.Dispose();
            }
        }
    }
}
