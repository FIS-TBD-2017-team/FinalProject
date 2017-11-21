using System;
using System.Data;

using MySql.Data.MySqlClient;

namespace FinalProject.Backend
{
    /// <summary>
    /// Maneja las credenciales de conexión a la base de datos
    /// </summary>
    public class Connection
    {
        private static String Server = "localhost";
        private static String Port = "4000";
        private static String DataBase = "asesorias";
        private static String User = "root";
        private static String Pass = "root";

        /// <summary>
        /// Genera la cadena de conexión para el sistema.
        /// </summary>
        /// <returns></returns>
        public static String ConnectionString()
        {
            return String.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}",
                                 Server,
                                 Port,
                                 DataBase,
                                 User,
                                 Pass);
        }

        /// <summary>
        /// Genera una nueva conexión con las credenciales definidas arriba.
        /// </summary>
        /// <returns></returns>
        public static MySqlConnection CreateNew()
        {
            return new MySqlConnection(ConnectionString());
        }
    }
}
