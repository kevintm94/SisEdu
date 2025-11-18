using MySql.Data.MySqlClient;
using SisEdu.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SisEdu.Datos
{
    class MateriaBD
    {
        private MySqlConnection conexion = new Conexion().Connection;

        public List<Materia> obtenerMateriasDocente(int id_docente) { 
            List<Materia> materias = new List<Materia>();
            string query = $"select * from materias where id_docente={id_docente}";
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
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    materias.Add( new Materia(
                        int.Parse(dr["id_materia"].ToString()),
                        dr["nombre"].ToString(),
                        int.Parse(dr["carga_horaria"].ToString()),
                        int.Parse(dr["id_curso"].ToString()),
                        int.Parse(dr["id_docente"].ToString())
                    ));
                }
            }
            return materias;

        }
    }
}
