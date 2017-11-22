using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Backend
{
    public class Asesor
    {
        public String NoControl { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public bool Activo { get; set; }
        public String Carrera { get; set; }
        public int Semestre { get; set; }
        public String Correo { get; set; }
        public String Telefono { get; set; }
        public int IdTutor { get; set; }

        public String NombreCompleto
        {
            get
            {
                return String.Format("{0} {1}", Nombre, Apellidos);
            }
        }

        public Asesor()
        {
        }
        public Asesor(String NoControl)
        {
            this.NoControl = NoControl;
        }
        public Asesor(String NoControl, String Nombre, String Apellidos, bool Activo, String Carrera,
                      int Semestre, String Correo, String Telefono, int IdTutor)
        {
            this.NoControl = NoControl;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Activo = Activo;
            this.Carrera = Carrera;
            this.Semestre = Semestre;
            this.Correo = Correo;
            this.Telefono = Telefono;
            this.IdTutor = IdTutor;
        }

        public static Asesor FromDataRow(DataRow dr)
        {
            return new Asesor(
                dr["nocontrol"].ToString(),
                dr["nombre"].ToString(),
                dr["apellidos"].ToString(),
                bool.Parse(dr["activo"].ToString()),
                dr["carrera"].ToString(),
                int.Parse(dr["semestre"].ToString()),
                dr["correo"].ToString(),
                dr["telefono"].ToString(),
                int.Parse(dr["idtutor"].ToString())
            );
        }

        public static List<Asesor> Select()
        {
            String query = "SELECT * FROM asesor";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();

            try
            {                
                adp.Fill(tbl);

                List<Asesor> list = new List<Asesor>();

                foreach (DataRow dr in tbl.Rows)
                    list.Add(Asesor.FromDataRow(dr));

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
        public static List<Asesor> Select(Tutor tutor)
        {
            String query = "SELECT * FROM asesor WHERE idtutor = @idtutor";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idtutor", tutor.IdTutor);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();

            try
            {
                adp.Fill(tbl);

                List<Asesor> list = new List<Asesor>();

                foreach (DataRow dr in tbl.Rows)
                    list.Add(Asesor.FromDataRow(dr));

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
        public static Asesor Select(String NoControl)
        {
            String query = "SELECT * FROM asesor WHERE nocontrol = @nocontrol LIMIT 1";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nocontrol", NoControl);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();

            try
            {
                adp.Fill(tbl);
                return Asesor.FromDataRow(tbl.Rows[0]);
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

        public static List<Materia> Materias(String NoControl)
        {
            String query = "SELECT * FROM materiasofertadas WHERE nocontrol = @nocontrol";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nocontrol", NoControl);
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
    }
}
