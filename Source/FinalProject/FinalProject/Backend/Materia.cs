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

        public static Materia FromDataRow(DataRow dr)
        {
            return new Materia(
                int.Parse(dr["idmateria"].ToString()),
                dr["nombre"].ToString(),
                int.Parse(dr["idcarrera"].ToString())
            );
        }

        public static List<Materia> Select()
        {
            String query = "SELECT * FROM materias";

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
                return null;
            }
            finally
            {
                conn.Dispose();
            }
        }
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
                return null;
            }
            finally
            {
                conn.Dispose();
            }
        }
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
                return null;
            }
            finally
            {
                conn.Dispose();
            }
        }
    }
}
