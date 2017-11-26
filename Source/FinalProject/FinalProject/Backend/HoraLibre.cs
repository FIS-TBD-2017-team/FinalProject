﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Backend
{
    public class HoraLibre
    {
        public String NoControl { get; set; }
        public String Dia { get; set; }
        public String Hora { get; set; }

        /// <summary>
        /// Nombre del día completo.
        /// </summary>
        public String DiaCompleto
        {
            get
            {
                switch (Dia) {
                    case "LUN":
                        return "Lunes";
                    case "MAR":
                        return "Martes";
                    case "MIE":
                        return "Miércoles";
                    case "JUE":
                        return "Jueves";
                    case "VIE":
                        return "Viernes";
                    default:
                        return "ERROR";
                }
            }
        }

        public HoraLibre()
        {

        }
        public HoraLibre(String NoControl, String Dia, String Hora)
        {
            this.NoControl = NoControl;
            this.Dia = Dia;
            this.Hora = Hora;
        }

        /// <summary>
        /// Toma como parámetro un objeto DataRow generado por MySQL
        /// y regresa un objeto de tipo HoraLibre.
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static HoraLibre FromDataRow(DataRow dr)
        {
            return new HoraLibre(
                dr["nocontrol"].ToString(),
                dr["dia"].ToString(),
                dr["hora"].ToString()
            );
        }

        /// <summary>
        /// Regresa la lista de horas libres de un asesor dado.
        /// </summary>
        /// <param name="asesor"></param>
        /// <returns></returns>
        public static List<HoraLibre> Select(Alumno asesor)
        {
            String query = "SELECT * FROM horaslibres WHERE nocontrol = @nocontrol " +
                           "ORDER BY dia, hora";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nocontrol", asesor.NoControl);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();

            try
            {
                adp.Fill(tbl);

                List<HoraLibre> list = new List<HoraLibre>();

                foreach (DataRow dr in tbl.Rows)
                    list.Add(HoraLibre.FromDataRow(dr));

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
        /// Verifica si un asesor tiene registrada una hora como libre.
        /// </summary>
        /// <param name="hl"></param>
        /// <returns></returns>
        public static bool Exists(HoraLibre hl)
        {
            String query = "SELECT * FROM horaslibres WHERE nocontrol = @nocontrol AND " +
                           "dia = @dia AND hora = @hora LIMIT 1";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nocontrol", hl.NoControl);
            cmd.Parameters.AddWithValue("@dia", hl.Dia);
            cmd.Parameters.AddWithValue("@hora", hl.Hora);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataTable tbl = new DataTable();

            try
            {
                adp.Fill(tbl);
                return tbl.Rows.Count == 1;
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
        /// <summary>
        /// Registra una hora libre para un asesor.
        /// </summary>
        /// <param name="hl"></param>
        /// <returns></returns>
        public static bool Insert(HoraLibre hl)
        {
            String query = "INSERT INTO horaslibres VALUES (@nocontrol, @dia, @hora)";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nocontrol", hl.NoControl);
            cmd.Parameters.AddWithValue("@dia", hl.Dia);
            cmd.Parameters.AddWithValue("@hora", hl.Hora);
            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                return true;
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
        /// <summary>
        /// Elimina de la base de datos una hora libre para un asesor.
        /// </summary>
        /// <param name="hl"></param>
        public static void Delete(HoraLibre hl)
        {
            String query = "DELETE FROM horaslibres WHERE nocontrol = @nocontrol AND dia = @dia AND hora = @hora";

            MySqlConnection conn = Connection.Asesorias();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nocontrol", hl.NoControl);
            cmd.Parameters.AddWithValue("@dia", hl.Dia);
            cmd.Parameters.AddWithValue("@hora", hl.Hora);
            try
            {
                cmd.Connection.Open();
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
