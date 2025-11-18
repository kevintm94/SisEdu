using System;
using System.Collections.Generic;
using System.Text;

namespace SisEdu.Modelo
{
    class Estudiante
    {
        public int id_estudiante { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string ci { get; set; }
        public int id_curso { get; set; }

        public Estudiante(int id_estudiante_, string nombre_, string apellido_, DateTime fecha_nacimiento_, string ci_, int id_curso_)
        {
            this.id_estudiante = id_estudiante_;
            this.nombre = nombre_;
            this.apellido = apellido_;
            this.fecha_nacimiento = fecha_nacimiento_;
            this.ci = ci_;
            this.id_curso = id_curso_;
        }
    }
}
