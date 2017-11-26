using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Backend
{
    public class DetalleAsesoria
    {
        public int IdAsesoria { get; set; }
        public String NoControl { get; set; }

        public DetalleAsesoria(int IdAsesoria, String NoControl)
        {
            this.IdAsesoria = IdAsesoria;
            this.NoControl = NoControl;
        }

        public static DetalleAsesoria FromDataRow(DataRow dr)
        {
            return new DetalleAsesoria(
                int.Parse(dr["idasesoria"].ToString()),
                dr["nocontrol"].ToString()
            );
        }

        public static bool Insert(List<DetalleAsesoria> lista)
        {
            MySqlConnection conn = Connection.Asesorias();
            conn.Open();
            MySqlTransaction trans = conn.BeginTransaction();

            try
            {
                foreach (DetalleAsesoria da in lista)
                {
                    String query = "INSERT INTO detalleasesoria VALUES (@idasesoria, @nocontrol)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idasesoria", da.IdAsesoria);
                    cmd.Parameters.AddWithValue("@nocontrol", da.NoControl);

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
    }
}
