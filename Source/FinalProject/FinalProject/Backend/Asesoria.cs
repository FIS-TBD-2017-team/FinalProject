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

        /// <summary>
        /// Nombre completo con el formato Nombre Apellidos.
        /// </summary>
        public String NombreAsesor { get; set; }
        /// <summary>
        /// Nombre de la materia de la asesoría.
        /// </summary>
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

            this.NombreAsesor = Alumno.Select(NoControl).NombreCompleto;
            this.NombreMateria = Materia.Select(IdMateria).Nombre;
        }

        /// <summary>
        /// Toma como parámetro un objeto DataRow generado por MySQL
        /// y regresa un objeto de tipo Asesoria.
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static Asesoria FromDataRow(DataRow dr)
        {
            return new Asesoria(
                int.Parse(dr["idasesoria"].ToString()),
                dr["nocontrol"].ToString(),
                int.Parse(dr["idmateria"].ToString()),
                dr["estatus"].ToString()
            );
        }

        /// <summary>
        /// Inserta en la base de datos un registro de tipo asesoria,
        /// con los datos del objeto pasado como parámetro.
        /// </summary>
        /// <param name="asesoria"></param>
        public static void Insert(Asesoria asesoria)
        {
            String query = "INSERT INTO asesoria VALUES(null,@nocontrol,@idmateria,@estatus)";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nocontrol", asesoria.NoControl);
            cmd.Parameters.AddWithValue("@idmateria", asesoria.IdMateria);
            cmd.Parameters.AddWithValue("@estatus", asesoria.Estatus);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                conn.Dispose();
            }
        }
        /// <summary>
        /// Inserta en la base de datos un registro de tipo asesoría, con
        /// los datos del objeto pasado como parámetro.
        /// Además, regresa el Id del registro.
        /// </summary>
        /// <param name="asesoria"></param>
        /// <returns></returns>
        public static int InsertAndSelect(Asesoria asesoria)
        {
            Asesoria.Insert(asesoria);

            String query = "SELECT idasesoria FROM asesoria ORDER BY idasesoria DESC LIMIT 1";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                return int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return -1;
            }
            finally
            {
                conn.Dispose();
            }
        }
        /// <summary>
        /// Regresa la lista de las asesorías activas de todos los
        /// asesores para un tutor dado.
        /// </summary>
        /// <param name="tutor"></param>
        /// <returns></returns>
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
                Console.Write(ex.StackTrace);
                return null;
            }
            finally
            {
                conn.Dispose();
            }
        }
        /// <summary>
        /// Regresa la lista de asesorías que tiene un asesor.
        /// </summary>
        /// <param name="asesor"></param>
        /// <returns></returns>
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
                Console.Write(ex.StackTrace);
                return null;
            }
            finally
            {
                conn.Dispose();
            }
        }
        /// <summary>
        /// Regresa la información de la asesoría.
        /// </summary>
        /// <param name="IdAsesoria"></param>
        /// <returns></returns>
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
                Console.Write(ex.StackTrace);
                return null;
            }
            finally
            {
                conn.Dispose();
            }
        }
        /// <summary>
        /// Regresa la lista de alumnos que integran la asesoría.
        /// </summary>
        /// <param name="IdAsesoria"></param>
        /// <returns></returns>
        public static List<Alumno> Integrantes(int IdAsesoria)
        {
            String query = "SELECT * FROM AlumnosAsesoria WHERE idasesoria=@idasesoria";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idasesoria", IdAsesoria);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();

            try
            {
                adp.Fill(tbl);

                List<Alumno> list = new List<Alumno>();

                foreach (DataRow dr in tbl.Rows)
                    list.Add(Alumno.FromDataRow(dr));

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
    }
}
