using SisEdu.Modelo;
using SisEdu.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Data;

public class CalificacionController
{
    private readonly MySqlConnection conexion;

    public CalificacionController()
    {
        // Usamos tu clase Conexion
        conexion = new Conexion().Connection;
    }

    // INSERTAR CALIFICACIÓN
    public bool RegistrarCalificacion(Calificacion c)
    {
        try
        {
            conexion.Open();

            string sql = @"INSERT INTO calificaciones (id_estudiante, id_materia, bimestre, nota)
                           VALUES (@id_estudiante, @id_materia, @bimestre, @nota)";

            using (var cmd = new MySqlCommand(sql, conexion))
            {
                cmd.Parameters.AddWithValue("@id_estudiante", c.IdEstudiante);
                cmd.Parameters.AddWithValue("@id_materia", c.IdMateria);
                cmd.Parameters.AddWithValue("@bimestre", c.Bimestre);
                cmd.Parameters.AddWithValue("@nota", c.Nota);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        finally
        {
            conexion.Close();
        }
    }

    // LISTAR CALIFICACIONES EN TABLA
    public DataTable ObtenerCalificaciones()
    {
        try
        {
            conexion.Open();

            string sql = @"SELECT c.id_calificacion,
                                  e.nombre AS estudiante,
                                  m.nombre AS materia,
                                  c.bimestre,
                                  c.nota
                           FROM calificaciones c
                           INNER JOIN estudiantes e ON c.id_estudiante = e.id_estudiante
                           INNER JOIN materias m ON c.id_materia = m.id_materia";

            var da = new MySqlDataAdapter(sql, conexion);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        finally
        {
            conexion.Close();
        }
    }

    // CARGAR COMBOBOX: ESTUDIANTES
    public DataTable ObtenerEstudiantes()
    {
        try
        {
            conexion.Open();
            var da = new MySqlDataAdapter("SELECT id_estudiante, nombre FROM estudiantes", conexion);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        finally
        {
            conexion.Close();
        }
    }

    // CARGAR COMBOBOX: MATERIAS
    public DataTable ObtenerMaterias()
    {
        try
        {
            conexion.Open();
            var da = new MySqlDataAdapter("SELECT id_materia, nombre FROM materias", conexion);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        finally
        {
            conexion.Close();
        }
    }
}
