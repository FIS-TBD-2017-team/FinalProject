using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Backend
{
    public class Asesoria
    {
        public int IdAsesoria { get; set; }
        public String NoControl { get; set; }
        public int IdMateria { get; set; }
        public String Estatus { get; set; }

        public String NombreAsesor { get; set; }
        public String NombreMateria { get; set; }

        public Asesoria()
        {

        }
        public Asesoria(int IdAsesoria)
        {
            this.IdAsesoria = IdAsesoria;
        }
        public Asesoria(int IdAsesoria, String NoControl, int IdMateria, String Estatus)
        {
            this.IdAsesoria = IdAsesoria;
            this.NoControl = NoControl;
            this.IdMateria = IdMateria;
            this.Estatus = Estatus;

            this.NombreAsesor = Alumno.SelectAsesor(NoControl).NombreCompleto;
            this.NombreMateria = Materia.Select(IdMateria).Nombre;
        }

        public static Asesoria FromDataRow(DataRow dr)
        {
            return new Asesoria(
                int.Parse(dr["idasesoria"].ToString()),
                dr["nocontrol"].ToString(),
                int.Parse(dr["idmateria"].ToString()),
                dr["estatus"].ToString()
            );
        }

        public static List<Asesoria> Activas(Tutor tutor)
        {
            String query = "SELECT * FROM asesoria A, asesor B WHERE A.noControl = B.noControl AND " +
                           "A.estatus = 'ACTIVA' AND B.idTutor = @idtutor";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idtutor", tutor.IdTutor);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();

            try
            {
                adp.Fill(tbl);

                List<Asesoria> list = new List<Asesoria>();

                foreach (DataRow dr in tbl.Rows)
                    list.Add(Asesoria.FromDataRow(dr));

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
        public static List<Asesoria> Select(Alumno asesor)
        {
            String query = "SELECT * FROM asesoria A, asesor B WHERE A.noControl = B.noControl AND B.noControl = @nocontrol";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nocontrol", asesor.NoControl);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();

            try
            {
                adp.Fill(tbl);

                List<Asesoria> list = new List<Asesoria>();

                foreach (DataRow dr in tbl.Rows)
                    list.Add(Asesoria.FromDataRow(dr));

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
        public static Asesoria Select(int IdAsesoria)
        {
            String query = "SELECT * FROM asesoria  WHERE idasesoria = @idasesoria";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idtutor", IdAsesoria);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();

            try
            {
                adp.Fill(tbl);
                return Asesoria.FromDataRow(tbl.Rows[0]);
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
