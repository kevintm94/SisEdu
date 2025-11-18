using System;
using System.Collections.Generic;
using System.Text;

namespace SisEdu.Modelo
{
    class Curso
    {
        public int id_curso { get; set; }
        public string nombre { get; set; }
        public string nivel { get; set; }
        public string paralelo { get; set; }
        public int id_unidad { get; set; }

        public Curso(int id_curso_, string nombre_, string nivel_, string paralelo_, int id_unidad_)
        {
            this.id_curso = id_curso_;
            this.nombre = nombre_;
            this.nivel = nivel_;
            this.paralelo = paralelo_;
            this.id_unidad = id_unidad_;
        }
    }
}
