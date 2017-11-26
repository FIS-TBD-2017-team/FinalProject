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

        public String NombreTutor { get; set; }
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
                return null;
            }
            finally
            {
                conn.Dispose();
            }
        }
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
                return null;
            }
            finally
            {
                conn.Dispose();
            }
        }
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
                return null;
            }
            finally
            {
                conn.Dispose();
            }
        }
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
                return null;
            }
            finally
            {
                conn.Dispose();
            }
        }
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
                return null;
            }
            finally
            {
                conn.Dispose();
            }
        }

    }
}
