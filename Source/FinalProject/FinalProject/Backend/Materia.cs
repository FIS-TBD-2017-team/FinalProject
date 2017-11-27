using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Backend
{
    public class Materia
    {
        public int IdMateria { get; set; }
        public String Nombre { get; set; }
        public int IdCarrera { get; set; }

        public Materia()
        {

        }
        public Materia(int IdMateria, String Nombre, int IdCarrera)
        {
            this.IdMateria = IdMateria;
            this.Nombre = Nombre;
            this.IdCarrera = IdCarrera;
        }

        /// <summary>
        /// Toma como parámetro un objeto DataRow generado por MySQL
        /// y regresa un objeto de tipo Materia.
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static Materia FromDataRow(DataRow dr)
        {
            return new Materia(
                int.Parse(dr["idmateria"].ToString()),
                dr["nombre"].ToString(),
                int.Parse(dr["idcarrera"].ToString())
            );
        }

        /// <summary>
        /// Regresa la lista de materias.
        /// </summary>
        /// <returns></returns>
        public static List<Materia> Select()
        {
            String query = "SELECT * FROM materias where idCarrera is not null";
            MySqlConnection conn = Connection.SICE();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();

            try
            {
                adp.Fill(tbl);

                List<Materia> list = new List<Materia>();

                foreach (DataRow dr in tbl.Rows)
                    list.Add(Materia.FromDataRow(dr));

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
        public static List<Materia> SelectSem(int semestre)
        {
            String query = "SELECT * FROM materias where idCarrera=@idSemestre";
            MySqlConnection conn = Connection.SICE();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idSemestre", semestre);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();

            try
            {
                adp.Fill(tbl);

                List<Materia> list = new List<Materia>();

                foreach (DataRow dr in tbl.Rows)
                    list.Add(Materia.FromDataRow(dr));

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
        /// Regresa la lista de materias que un asesor tiene 
        /// marcadas como ofertadas.
        /// </summary>
        /// <param name="asesor"></param>
        /// <returns></returns>
        public static List<Materia> Select(Alumno asesor)
        {
            String query = "SELECT * FROM MateriasOfertadas WHERE nocontrol = @nocontrol";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nocontrol", asesor.NoControl);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();

            try
            {
                adp.Fill(tbl);

                List<Materia> list = new List<Materia>();

                foreach (DataRow dr in tbl.Rows)
                    list.Add(Materia.FromDataRow(dr));

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
        /// Regresa la información de una materia dado su id
        /// como parámetro.
        /// </summary>
        /// <param name="IdMateria"></param>
        /// <returns></returns>
        public static Materia Select(int IdMateria)
        {
            String query = "SELECT * FROM materias WHERE idmateria = @idmateria";

            MySqlConnection conn = Connection.SICE();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idmateria", IdMateria);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();

            try
            {
                adp.Fill(tbl);
                return Materia.FromDataRow(tbl.Rows[0]);
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
