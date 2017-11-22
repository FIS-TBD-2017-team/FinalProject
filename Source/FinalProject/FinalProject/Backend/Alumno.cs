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
                return null;
            }
            finally
            {
                conn.Dispose();
            }
        }
        public static Alumno SelectAsesor(String NoControl)
        {
            String query = "SELECT * FROM asesor WHERE nocontrol = @nocontrol LIMIT 1";

            MySqlConnection conn = Connection.Asesorias();
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
                return null;
            }
            finally
            {
                conn.Dispose();
            }
        }
    }
}