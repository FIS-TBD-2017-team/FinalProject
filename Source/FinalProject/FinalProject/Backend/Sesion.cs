﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Backend
{
    public class Sesion
    {
        public int IdSesion { get; set; }
        public int IdAsesoria { get; set; }
        public String Estatus { get; set; }
        public String Lugar { get; set; }
        public DateTime Fecha { get; set; }
        public String Hora { get; set; }
        public String Notas { get; set; }

        public Sesion()
        {

        }
        public Sesion(int IdSesion)
        {
            this.IdSesion = IdSesion;
        }
        public Sesion(int IdSesion, int IdAsesoria, String Estatus,
                      String Lugar, DateTime Fecha, String Hora, String Notas)
        {
            this.IdSesion = IdSesion;
            this.IdAsesoria = IdAsesoria;
            this.Estatus = Estatus;
            this.Lugar = Lugar;
            this.Fecha = Fecha;
            this.Hora = Hora;
            this.Notas = Notas;
        }

        /// <summary>
        /// Toma como parámetro un objeto DataRow generado por MySQL
        /// y regresa un objeto de tipo Sesion.
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static Sesion FromDataRow(DataRow dr)
        {
            return new Sesion(
                int.Parse(dr["idsesion"].ToString()),
                int.Parse(dr["idasesoria"].ToString()),
                dr["estatus"].ToString(),
                dr["lugar"].ToString(),
                DateTime.Parse(dr["fecha"].ToString()),
                dr["hora"].ToString(),
                dr["notas"].ToString()
            );
        }

        /// <summary>
        /// Regresa la lista de sesiones para una asesoría dada.
        /// </summary>
        /// <param name="asesoria"></param>
        /// <returns></returns>
        public static List<Sesion>Select(Asesoria asesoria)
        {
            String query = "SELECT * FROM sesion WHERE idasesoria=@idasesoria ORDER BY Fecha, Hora";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idasesoria", asesoria.IdAsesoria);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();

            try
            {
                adp.Fill(tbl);

                List<Sesion> list = new List<Sesion>();

                foreach (DataRow dr in tbl.Rows)
                    list.Add(Sesion.FromDataRow(dr));

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
        /// Regresa la información de una sesión dada.
        /// </summary>
        /// <param name="IdSesion"></param>
        /// <returns></returns>
        public static Sesion Select(int IdSesion)
        {
            String query = "SELECT * FROM sesion WHERE idsesion=@idsesion";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idsesion", IdSesion);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();

            try
            {
                adp.Fill(tbl);
                return Sesion.FromDataRow(tbl.Rows[0]);
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
        /// Crea el registro en la base de datos, de una sesión dada.
        /// </summary>
        /// <param name="sesion"></param>
        public static void Insert(Sesion sesion)
        {
            String query = "INSERT INTO sesion VALUES(null,@idasesoria,@estatus,@lugar,@fecha,@hora,@notas)";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idasesoria", sesion.IdAsesoria);
            cmd.Parameters.AddWithValue("@estatus", sesion.Estatus);
            cmd.Parameters.AddWithValue("@lugar", sesion.Lugar);
            cmd.Parameters.AddWithValue("@fecha", sesion.Fecha);
            cmd.Parameters.AddWithValue("@hora", sesion.Hora);
            cmd.Parameters.AddWithValue("@notas", sesion.Notas);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
                return;
            }
            finally
            {
                conn.Dispose();
            }
        }
        /// <summary>
        /// Borra un registro de sesión.
        /// </summary>
        /// <param name="IdSesion"></param>
        public static void Delete(int IdSesion)
        {
            Asistencia.Delete(IdSesion);

            String query = "DELETE FROM sesion WHERE idsesion=@idsesion";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idsesion", IdSesion);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
                return;
            }
            finally
            {
                conn.Dispose();
            }
        }
    }
}
