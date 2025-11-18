using SisEdu.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace SisEdu.Datos
{
    internal class DocenteBD
    {
        private MySqlConnection conexion = new Conexion().Connection;
        
        public Docente obtenerDocente(string email) 
        {
            string query = $"select * from docentes where correo='{email}'";
            MySqlDataAdapter adapter;
            DataTable dt = new DataTable();
            try
            {
                conexion.Open();
                adapter = new MySqlDataAdapter(query, conexion);
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Docente docente;
            if (dt.Rows.Count > 0) 
            {
                DataRow dr = dt.Rows[0];
                docente = new Docente(
                    int.Parse(dr["id_docente"]?.ToString()),
                    dr["nombre"]?.ToString(),
                    dr["apellido"]?.ToString(),
                    dr["ci"]?.ToString(),
                    dr["correo"]?.ToString(),
                    dr["telefono"]?.ToString(),
                    int.Parse(dr["id_unidad"]?.ToString())
                );
            }
            else
            {
                docente = new Docente();
            }
            return docente;
        }
    }
}
