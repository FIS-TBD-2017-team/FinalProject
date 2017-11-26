﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Backend
{
    public class DetalleSolicitud
    {
        public int IdSolicitud { get; set; }
        public String NoControl { get; set; }

        public DetalleSolicitud(int IdSolicitud, String NoControl)
        {
            this.IdSolicitud = IdSolicitud;
            this.NoControl = NoControl;
        }

        /// <summary>
        /// Agrega una lista de alumnos a la solicitud.
        /// </summary>
        /// <param name="IdSolicitud"></param>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static bool Insert(int IdSolicitud, List<Alumno> lista)
        {
            MySqlConnection conn = Connection.Asesorias();
            conn.Open();
            MySqlTransaction trans = conn.BeginTransaction();

            try
            {
                foreach (Alumno alm in lista)
                {
                    String query = "INSERT INTO detallesolicitud VALUES (@idsolicitud, @nocontrol)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idsolicitud", IdSolicitud);
                    cmd.Parameters.AddWithValue("@nocontrol", alm.NoControl);

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
