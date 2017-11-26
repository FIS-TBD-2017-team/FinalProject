using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Backend
{
    public class Asistencia
    {
        public int IdSesion { get; set; }
        public String NoControl { get; set; }
        public bool Asistio { get; set; }

        /// <summary>
        /// Nombre del alumno en el formato: Nombre Apellidos
        /// </summary>
        public String NombreAlumno { get; set; }

        public Asistencia(int IdSesion, String NoControl, bool Asistio)
        {
            this.IdSesion = IdSesion;
            this.NoControl = NoControl;
            this.Asistio = Asistio;

            this.NombreAlumno = Alumno.Select(NoControl).NombreCompleto;
        }

        /// <summary>
        /// Toma como parámetro un objeto DataRow generado por MySQL
        /// y regresa un objeto de tipo Asistencia.
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static Asistencia FromDataRow(DataRow dr)
        {
            return new Asistencia(
                int.Parse(dr["idsesion"].ToString()),
                dr["nocontrol"].ToString(),
                bool.Parse(dr["asistio"].ToString())
            );
        }

        /// <summary>
        /// Regresa la lista de asistencia para una sesión dada.
        /// </summary>
        /// <param name="IdSesion"></param>
        /// <returns></returns>
        public static List<Asistencia> Select(int IdSesion)
        {
            String query = "SELECT * FROM detallesesion WHERE idsesion=@idsesion";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idsesion", IdSesion);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();

            try
            {
                adp.Fill(tbl);

                List<Asistencia> list = new List<Asistencia>();

                foreach (DataRow dr in tbl.Rows)
                    list.Add(Asistencia.FromDataRow(dr));

                return list;
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

        /// <summary>
        /// Crea en la base de datos un registro de asistencia para una sesión
        /// y un alumno dados.
        /// </summary>
        /// <param name="asistencia"></param>
        public static void Insert(Asistencia asistencia)
        {
            String query = "INSERT INTO detallesesion VALUES (@idsesion,@nocontrol,@asistio)";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idsesion", asistencia.IdSesion);
            cmd.Parameters.AddWithValue("@nocontrol", asistencia.NoControl);
            cmd.Parameters.AddWithValue("@asistio", asistencia.Asistio);

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
        /// <summary>
        /// Actualiza los registro de la base de datos con base en la lista de 
        /// asistencia pasada como parámetro.
        /// Utiliza transacciones para asegurar la integridad.
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static bool PasarLista(List<Asistencia> lista)
        {
            MySqlConnection conn = Connection.Asesorias();
            conn.Open();
            MySqlTransaction trans = conn.BeginTransaction();

            try
            {
                foreach (Asistencia asis in lista)
                {
                    String query = "UPDATE detallesesion SET asistio=@asistio WHERE " +
                                   "idsesion=@idsesion AND nocontrol=@nocontrol";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idsesion", asis.IdSesion);
                    cmd.Parameters.AddWithValue("@nocontrol", asis.NoControl);
                    cmd.Parameters.AddWithValue("@asistio", asis.Asistio);

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
        /// Borra la lista de asistencia de la base de datos para una 
        /// sesión dada.
        /// </summary>
        /// <param name="IdSesion"></param>
        public static void Delete(int IdSesion)
        {
            String query = "DELETE FROM detallesesion WHERE idsesion=@idsesion";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idsesion", IdSesion);
            
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
