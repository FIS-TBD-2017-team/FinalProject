using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FinalProject.Backend
{
    public class DetalleSolicitud
    {
        public int IdSolicitud { get; set; }
        public String NoControl { get; set; }

        public DetalleSolicitud(int IdSolicitud, String NoControl)
        {
            this.IdSolicitud = IdSolicitud;
            this.NoControl = NoControl;
        }

        /// <summary>
        /// Agrega una lista de alumnos a la solicitud.
        /// </summary>
        /// <param name="IdSolicitud">Id de la solicitud</param>
        /// <param name="lista">Lista de alumnos para la asesoria</param>
        /// <returns></returns>
        public static bool Insert(int IdSolicitud, List<Alumno> lista)
        {
            MySqlConnection conn = Connection.Asesorias();
            conn.Open();
            MySqlTransaction trans = conn.BeginTransaction();

            try
            {
                foreach (Alumno alm in lista)
                {
                    String query = "INSERT INTO detallesolicitud VALUES (@idsolicitud, @nocontrol)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idsolicitud", IdSolicitud);
                    cmd.Parameters.AddWithValue("@nocontrol", alm.NoControl);

                    cmd.ExecuteNonQuery();
                }

                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
                trans.Rollback();
                return false;
            }
            finally
            {
                trans.Dispose();
                conn.Dispose();
            }
        }
        /// <summary>
        /// Combiarte una fila en un DetalledeSolicitud
        /// </summary>
        /// <param name="dr">Fila, resultado de una consulta</param>
        /// <returns></returns>
        public DetalleSolicitud FromDataRow(DataRow dr)
        {
            return new DetalleSolicitud(
                int.Parse(dr["idsolicitud"].ToString()),
                dr["noControl"].ToString()
            );
        }
        /// <summary>
        /// Agrega un detalle de solicitud a la base de datos
        /// </summary>
        /// <param name="detalleSolicitud"></param>
        public void Insert(DetalleSolicitud detalleSolicitud)
        {
            String query = "INSERT INTO detallesolicitud VALUES(@idSolicitud,@noControl);";
            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idSolicitud", detalleSolicitud.IdSolicitud);
            cmd.Parameters.AddWithValue("@noControl", detalleSolicitud.NoControl);
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
