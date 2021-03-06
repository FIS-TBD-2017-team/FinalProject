﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Backend
{
    public class Alumno
    {
        public String NoControl { get; set; }
        public String Nombre { get; set; }
        public String Apellido1 { get; set; }
        public String Apellido2 { get; set; }
        public String Correo { get; set; }        
        public int Semestre { get; set; }
        public int IdCarrera { get; set; }
        public String NombreCarrera { get; set; }

        /// <summary>
        /// Nombre completo con el formato Nombre Apellidos.
        /// </summary>
        public String NombreCompleto
        {
            get
            {
                return String.Format("{0} {1} {2}", Nombre, Apellido1 ,Apellido2);
            }
        }
        

        public Alumno()
        {
        }
        public Alumno(String NoControl)
        {
            this.NoControl = NoControl;
        }
        public Alumno(String NoControl, String Nombre, String Apellido1, String Apellido2, 
                      String Correo, int Semestre, int IdCarrera)
        {
            this.NoControl = NoControl;
            this.Nombre = Nombre;
            this.Apellido1 = Apellido1;
            this.Apellido2 = Apellido2;            
            this.Correo = Correo;
            this.Semestre = Semestre;
            this.IdCarrera = IdCarrera;
            this.NombreCarrera = Carrera.Select(IdCarrera).Nombre;
        }

        /// <summary>
        /// Toma como parámetro un objeto DataRow generado por MySQL
        /// y regresa un objeto de tipo Alumno.
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static Alumno FromDataRow(DataRow dr)
        {
            return new Alumno(
                dr["noControl"].ToString(),
                dr["nombre"].ToString(),
                dr["apellido1"].ToString(),
                dr["apellido2"].ToString(),
                dr["correo"].ToString(),
                int.Parse(dr["semestre"].ToString()),
                int.Parse(dr["idCarrera"].ToString())
            );
        }

        /// <summary>
        /// Regresa una lista de objetos de tipo Alumno que contiene
        /// únicamente los alumnos que participan como asesores y que son
        /// tutoreados por el tutor pasado como parámetro.
        /// </summary>
        /// <param name="tutor"></param>
        /// <returns></returns>
        public static List<Alumno> SelectAsesor(Tutor tutor)
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
        /// Regresa una lista de obejtos de tipo Alumno que contiene a los 
        /// asesores que son tutoreados por el tutor dado como parámetro, y
        /// además tienen ofertada la materia pasada como parámetro.
        /// </summary>
        /// <param name="tutor"></param>
        /// <param name="IdMateria"></param>
        /// <returns></returns>
        public static List<Alumno> SelectAsesor(Tutor tutor, int IdMateria)
        {
            String query = "SELECT * FROM asesor A, oferta O WHERE A.noControl = O.nocontrol " +
                           "AND idtutor = @idtutor AND idmateria=@idmateria";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idtutor", tutor.IdTutor);
            cmd.Parameters.AddWithValue("@idmateria", IdMateria);
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
        /// Regresa un registro de tipo alumno dado una cadena, que contiene
        /// el número de control de dicho alumno, como parámetro.
        /// </summary>
        /// <param name="NoControl"></param>
        /// <returns></returns>
        public static Alumno Select(String NoControl)
        {
            String query = "SELECT * FROM alumnos WHERE nocontrol = @nocontrol LIMIT 1";

            MySqlConnection conn = Connection.SICE();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nocontrol", NoControl);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();

            try
            {
                adp.Fill(tbl);
                return Alumno.FromDataRow(tbl.Rows[0]);
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
        /// Actualiza el correo del alumno pasado como parámetro.
        /// Cuenta con una validación en el servidor de MySQL a través
        /// de un trigger.
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns>
        public static bool Update(Alumno alumno)
        {
            String query = "UPDATE alumnos SET correo=@correo WHERE nocontrol = @nocontrol";

            MySqlConnection conn = Connection.SICE();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nocontrol", alumno.NoControl);
            cmd.Parameters.AddWithValue("@correo", alumno.Correo);
            
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery() == 1;
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
                return false;
            }
            finally
            {
                conn.Dispose();
            }
        }
    }
}
