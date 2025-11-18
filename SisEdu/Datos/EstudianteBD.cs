using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SisEdu.Datos
{
    class EstudianteBD
    {
        private MySqlConnection conexion = new Conexion().Connection;

        public DataSet obtenerEstudiantesMateria(int id_curso) 
        {
            string query = $"select * from estudiantes where id_curso={id_curso}";
            MySqlDataAdapter adapter;
            DataSet dt = new DataSet();
            try
            {
                conexion.Open();
                adapter = new MySqlDataAdapter(query, conexion);
                adapter.Fill(dt, "tbl");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dt;
        }
    }
}
