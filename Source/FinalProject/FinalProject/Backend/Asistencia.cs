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

        public String NombreAlumno { get; set; }

        public Asistencia(int IdSesion, String NoControl, bool Asistio)
        {
            this.IdSesion = IdSesion;
            this.NoControl = NoControl;
            this.Asistio = Asistio;

            this.NombreAlumno = Alumno.Select(NoControl).NombreCompleto;
        }

        public static Asistencia FromDataRow(DataRow dr)
        {
            return new Asistencia(
                int.Parse(dr["idsesion"].ToString()),
                dr["nocontrol"].ToString(),
                bool.Parse(dr["asistio"].ToString())
            );
        }

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
                return null;
            }
            finally
            {
                conn.Dispose();
            }
        }
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
                return;
            }
            finally
            {
                conn.Dispose();
            }
        }
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
                trans.Rollback();
                return false;
            }
            finally
            {
                trans.Dispose();
                conn.Dispose();
            }
        }
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
                return;
            }
            finally
            {
                conn.Dispose();
            }
        }
    }
}
