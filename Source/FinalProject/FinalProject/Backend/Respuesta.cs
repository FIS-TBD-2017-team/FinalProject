using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Backend
{
    public class Respuesta
    {
        public int IdRespuesta { get; set; }
        public int IdSolicitud { get; set; }
        public int IdTutor { get; set; }
        public String Resp { get; set; }

        public Respuesta(int IdRespuesta, int IdSolicitud, int IdTutor, String Resp)
        {
            this.IdRespuesta = IdRespuesta;
            this.IdSolicitud = IdSolicitud;
            this.IdTutor = IdTutor;
            this.Resp = Resp;
        }

        public static Respuesta FromDataRow(DataRow dr)
        {
            return new Respuesta(
                int.Parse(dr["idrespuesta"].ToString()),
                int.Parse(dr["idsolicitud"].ToString()),
                int.Parse(dr["idtutor"].ToString()),
                dr["resp"].ToString()
            );
        }

        public static void Insert(Respuesta resp)
        {
            String query = "INSERT INTO respuesta VALUES (null,@idsolicitud,@idtutor,@resp)";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@idsolicitud", resp.IdSolicitud);
            cmd.Parameters.AddWithValue("@idtutor", resp.IdTutor);
            cmd.Parameters.AddWithValue("@resp", resp.Resp);

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
        public static int InsertAndSelect(Respuesta resp)
        {
            Respuesta.Insert(resp);

            String query = "SELECT idrespuesta FROM respuesta ORDER BY idrespuesta DESC LIMIT 1";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                return int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                conn.Dispose();
            }
        }
    }
}
