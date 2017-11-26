using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Backend
{
    public class DetalleSolicitud
    {
        public int idSolicitud { get; set; }
        public String noControl { get; set; }

        public DetalleSolicitud() {

        }
        public DetalleSolicitud(int idSolicitud, String noControl) {
            this.idSolicitud = idSolicitud;
            this.noControl = noControl;
        }

        public DetalleSolicitud FromDataRow(DataRow dr)
        {
            return new DetalleSolicitud(
                int.Parse(dr["idsolicitud"].ToString()),
                dr["noControl"].ToString()
            );
        }
        public void Insert(DetalleSolicitud detalleSolicitud) {
            String query = "INSERT INTO detallesolicitud VALUES(@idSolicitud,@noControl);";
            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idSolicitud", detalleSolicitud.idSolicitud);
            cmd.Parameters.AddWithValue("@noControl", detalleSolicitud.noControl);
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
