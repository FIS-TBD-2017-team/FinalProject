using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Backend
{
    public class Solicitud
    {
        public int IdSolicitud { get; set; }
        public int IdMateria { get; set; }
        public int IdTutor { get; set; }
        public String Estatus { get; set; }
        public String Horario { get; set; }
        public String Notas { get; set; }
        public int IdAsesoria { get; set; }

        /// <summary>
        /// Nombre del tutor en el formato: Nombre Apellidos.
        /// </summary>
        public String NombreTutor { get; set; }
        /// <summary>
        /// Nombre de la materia de la solicitud.
        /// </summary>
        public String NombreMateria { get; set; }

        public Solicitud()
        {

        }
        public Solicitud(int IdSolicitud)
        {
            this.IdSolicitud = IdSolicitud;
        }
        public Solicitud(int IdSolicitud, int IdMateria, int IdTutor, String Estatus,
                         String Horario, String Notas)
        {
            this.IdSolicitud = IdSolicitud;
            this.IdMateria = IdMateria;
            this.IdTutor = IdTutor;
            this.Estatus = Estatus;
            this.Horario = Horario;
            this.Notas = Notas;
            this.IdAsesoria = IdAsesoria;

            this.NombreTutor = Tutor.Select(IdTutor).NombreCompleto;
            this.NombreMateria = Materia.Select(IdMateria).Nombre;
        }

        /// <summary>
        /// Toma como parámetro un objeto DataRow generado por MySQL
        /// y regresa un objeto de tipo Solicitud.
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static Solicitud FromDataRow(DataRow dr)
        {
            return new Solicitud(
                int.Parse(dr["idsolicitud"].ToString()),
                int.Parse(dr["idmateria"].ToString()),
                int.Parse(dr["idtutor"].ToString()),
                dr["estatus"].ToString(),
                dr["horario"].ToString(),
                dr["notas"].ToString()
            );
        }

        /// <summary>
        /// Crea el registro una nueva solicitud en la base de datos.
        /// Agrega los integrantes a la solicitud.
        /// </summary>
        /// <param name="solicitud"></param>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static void RegistrarSP(Solicitud solicitud, List<Alumno> lista)
        {
            String query = "RegistrarSolicitud";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("_idmateria", solicitud.IdMateria);
            cmd.Parameters.AddWithValue("_idtutor", solicitud.IdTutor);
            cmd.Parameters.AddWithValue("_horario", solicitud.Horario);
            cmd.Parameters.AddWithValue("_notas", solicitud.Notas);

            try
            {
                conn.Open();
                int IdSolicitud = int.Parse(cmd.ExecuteScalar().ToString());
                DetalleSolicitud.Insert(IdSolicitud, lista);
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
            }
            finally
            {
                conn.Dispose();
            }
        }
        /// <summary>
        /// Actualiza la información de la solicitud en la base datos.
        /// Utiliza procedimientos almacenados.
        /// </summary>
        /// <param name="solicitud"></param>
        public static void ActualizarSP(Solicitud solicitud)
        {
            String query = "ActualizarSolicitud";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("_idsolicitud", solicitud.IdSolicitud);
            cmd.Parameters.AddWithValue("_estatus", solicitud.Estatus);
            cmd.Parameters.AddWithValue("_idasesoria", solicitud.IdAsesoria);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
            }
            finally
            {
                conn.Dispose();
            }
        }
        /// <summary>
        /// Regresa la lista de las solicitudes que ha realizado un tutor.
        /// Utiliza procedimientos almacenados.
        /// </summary>
        /// <param name="tutor"></param>
        /// <returns></returns>
        public static List<Solicitud> ConsultasSP(Tutor tutor)
        {
            String query = "ConsultarSolicitudes";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@_idtutor", tutor.IdTutor);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();

            try
            {
                adp.Fill(tbl);
                List<Solicitud> list = new List<Solicitud>();

                foreach (DataRow dr in tbl.Rows)
                    list.Add(Solicitud.FromDataRow(dr));

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
        /// Regresa la lista de las solicitudes que han hecho los demás 
        /// tutores, y que se encuentran en estatus "PENDIENTE".
        /// Utiliza procedimientos almacenados.
        /// </summary>
        /// <param name="tutor"></param>
        /// <returns></returns>
        public static List<Solicitud> PendientesSP(Tutor tutor)
        {
            String query = "SolicitudesPendientes";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@_idtutor", tutor.IdTutor);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();

            try
            {
                adp.Fill(tbl);
                List<Solicitud> list = new List<Solicitud>();

                foreach (DataRow dr in tbl.Rows)
                    list.Add(Solicitud.FromDataRow(dr));

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
        /// Regresa la información de una solicitud.
        /// Utiliza procedimientos almacenados.
        /// </summary>
        /// <param name="IdSolicitud"></param>
        /// <returns></returns>
        public static Solicitud SelectSP(int IdSolicitud)
        {
            String query = "ConsultarSolicitud";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@_idsolicitud", IdSolicitud);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();

            try
            {
                adp.Fill(tbl);
                return Solicitud.FromDataRow(tbl.Rows[0]);
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
        /// Regresa la lista de los integrantes de la solicitud.
        /// Utiliza procedimientos almacenados.
        /// </summary>
        /// <param name="IdSolicitud"></param>
        /// <returns></returns>
        public static List<Alumno> IntegrantesSP(int IdSolicitud)
        {
            String query = "IntegrantesSolicitud";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@_idsolicitud", IdSolicitud);
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
        /// <summary>
        /// Regresa la lista de asesores propuestos para una solicitud.
        /// Utiliza procedimientos almacenados.
        /// </summary>
        /// <param name="IdSolicitud"></param>
        /// <returns></returns>
        public static List<Alumno> AsesoresPropuestosSP(int IdSolicitud)
        {
            String query = "AsesoresPropuestos";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@_idsolicitud", IdSolicitud);
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
