using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace SisEdu.Datos
{
    internal class Conexion
    {
        private string cadenaConexion = "Server=localhost;User=root;Password=;Port=3306;database=sistema_educativo";
        public MySqlConnection Connection { get; }

        public Conexion() { 
            Connection = new MySqlConnection(cadenaConexion);
        }
    }
}
