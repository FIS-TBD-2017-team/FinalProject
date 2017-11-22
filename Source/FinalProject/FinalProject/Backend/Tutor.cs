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
        public String Apellido1 { get; set; }
        public String Apellido2 { get; set; }
        public String Usuario { get; set; }
        public String Tipo { get; set; }

        public String NombreCompleto
        {
            get
            {
                return String.Format("{0} {1} {2}", Nombre, Apellido1, Apellido2);
            }
        }

        public Tutor()
        {

        }
        public Tutor(int IdTutor)
        {
            this.IdTutor = IdTutor;
        }
        public Tutor(int IdTutor, String Nombre, String Apellido1, String Apellido2, 
                     String Usuario, String Tipo)
        {
            this.IdTutor = IdTutor;
            this.Nombre = Nombre;
            this.Apellido1 = Apellido1;
            this.Apellido2 = Apellido2;
            this.Usuario = Usuario;
            this.Tipo = Tipo;
        }

        public static Tutor FromDataRow(DataRow dr)
        {
            return new Tutor(
                int.Parse(dr["idtutor"].ToString()),
                dr["nombre"].ToString(),
                dr["apellido1"].ToString(),
                dr["apellido2"].ToString(),
                dr["usuario"].ToString(),
                dr["tipo"].ToString()
            );
        }

        public static Tutor Login(String Usuario, String Pass)
        {
            String query = "SELECT * FROM Tutores WHERE usuario = @usuario AND password = sha2(@pass,512) LIMIT 1";

            MySqlConnection conn = Connection.SICE();
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
            String query = "SELECT * FROM Tutores WHERE idtutor = @idtutor LIMIT 1";

            MySqlConnection conn = Connection.SICE();
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
