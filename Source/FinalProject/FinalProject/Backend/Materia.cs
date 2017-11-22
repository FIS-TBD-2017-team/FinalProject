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

        public Materia()
        {

        }
        public Materia(int IdMateria, String Nombre)
        {
            this.IdMateria = IdMateria;
            this.Nombre = Nombre;
        }

        public static Materia FromDataRow(DataRow dr)
        {
            return new Materia(
                int.Parse(dr["idmateria"].ToString()),
                dr["nombre"].ToString()
            );
        }

        public static List<Materia> Select()
        {
            String query = "SELECT * FROM materia";

            MySqlConnection conn = Connection.Asesorias();
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
    }
}
