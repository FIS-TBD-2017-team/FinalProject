using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Backend
{
    public class Oferta
    {
        public int IdOferta { get; set; }
        public String NoControl { get; set; }
        public int IdMateria { get; set; }

        public Oferta()
        {

        }
        public Oferta(int IdOferta, String NoControl, int IdMateria)
        {
            this.IdOferta = IdOferta;
            this.NoControl = NoControl;
            this.IdMateria = IdMateria;
        }

        /// <summary>
        /// Toma como parámetro un objeto DataRow generado por MySQL
        /// y regresa un objeto de tipo Oferta.
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static void Insert(Oferta oferta)
        {
            String query = "INSERT INTO oferta VALUES (null,@nocontrol,@idmateria)";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nocontrol", oferta.NoControl);
            cmd.Parameters.AddWithValue("@idmateria", oferta.IdMateria);
            try
            {
                cmd.Connection.Open();
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
        /// Verfica si un alumno dado tiene una materia dada como ofertada.
        /// </summary>
        /// <param name="oferta"></param>
        /// <returns></returns>
        public static bool Exists(Oferta oferta)
        {
            String query = "SELECT * FROM oferta WHERE nocontrol=@nocontrol AND idmateria=@idmateria";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nocontrol", oferta.NoControl);
            cmd.Parameters.AddWithValue("@idmateria", oferta.IdMateria);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();

            try
            {
                adp.Fill(tbl);
                return tbl.Rows.Count == 1;
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
                return false;
            }
            finally
            {
                conn.Dispose();
            }
        }
        /// <summary>
        /// Elimina de la base de datos la oferta pasada como parámetro.
        /// </summary>
        /// <param name="oferta"></param>
        public static void Delete(Oferta oferta)
        {
            String query = "DELETE FROM oferta WHERE nocontrol=@nocontrol AND idmateria=@idmateria";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nocontrol", oferta.NoControl);
            cmd.Parameters.AddWithValue("@idmateria", oferta.IdMateria);
            try
            {
                cmd.Connection.Open();
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
