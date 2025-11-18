using System;
using System.Collections.Generic;
using System.Text;

namespace SisEdu.Modelo
{
    class Materia
    {
        public int id_materia { get; set; }
        public string nombre { get; set; }
        public int carga_horaria { get; set; }
        public int id_curso { get; set; }
        public int id_docente { get; set; }

        public Materia(int id_materia_, string nombre_, int carga_horaria_, int id_curso_, int id_docente_)
        {
            this.id_materia = id_materia_;
            this.nombre = nombre_;
            this.carga_horaria = carga_horaria_;
            this.id_curso = id_curso_;
            this.id_docente = id_docente_;
        }
    }
}
