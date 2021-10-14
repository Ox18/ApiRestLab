using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MySql.Data.MySqlClient;

namespace TodoApp.Models
{
    public class Conexion
    {
        
        public static Conexion BuildConnection()
        {
            return new Conexion();
        }

        public MySqlConnection connection()
        {
            MySqlConnection connection = new MySqlConnection(this.connectionString);
            connection.Open();

            return connection;
        }
        
        protected String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kanbandb;";

    }
}