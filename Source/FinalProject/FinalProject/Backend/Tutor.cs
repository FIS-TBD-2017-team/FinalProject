using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Backend
{
    public class Tutor
    {
        public int IdTutor { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public String Usuario { get; set; }

        public String NombreCompleto
        {
            get
            {
                return String.Format("{0} {1}", Nombre, Apellidos);
            }
        }

        public Tutor()
        {

        }
        public Tutor(int IdTutor)
        {
            this.IdTutor = IdTutor;
        }
        public Tutor(int IdTutor, String Nombre, String Apellidos, String Usuario)
        {
            this.IdTutor = IdTutor;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Usuario = Usuario;
        }

        public static Tutor FromDataRow(DataRow dr)
        {
            return new Tutor(
                int.Parse(dr["idtutor"].ToString()),
                dr["nombre"].ToString(),
                dr["apellidos"].ToString(),
                dr["usuario"].ToString()
            );
        }

        public static Tutor Login(String Usuario, String Pass)
        {
            String query = "SELECT * FROM tutor WHERE usuario = @usuario AND pass = sha2(@pass,512) LIMIT 1";

            MySqlConnection conn = Connection.CreateNew();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@usuario", Usuario);
            cmd.Parameters.AddWithValue("@pass", Pass);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();

            try
            {
                adp.Fill(tbl);                
                return Tutor.FromDataRow(tbl.Rows[0]);
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
        public static Tutor Select(int IdTutor)
        {
            String query = "SELECT * FROM tutor WHERE idtutor = @idtutor LIMIT 1";

            MySqlConnection conn = Connection.CreateNew();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idtutor", IdTutor);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();

            try
            {
                adp.Fill(tbl);
                return Tutor.FromDataRow(tbl.Rows[0]);
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
        public static List<Asesoria> AsesoriasActivas(int IdTutor)
        {
            return null;
        }
    }
}
