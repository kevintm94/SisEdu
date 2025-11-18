using SisEdu.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SisEdu.Controlador
{
    class EstudianteControlador
    {
        private EstudianteBD estudianteBD = new EstudianteBD();

        public DataSet obtenerEstudiantesMateria(int id_curso) 
        {
            return estudianteBD.obtenerEstudiantesMateria(id_curso);
        }
    }
}
