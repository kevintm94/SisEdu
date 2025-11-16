using System;
using System.Collections.Generic;
using System.Text;

namespace SisEdu.Modelo
{
    internal class Docente
    {
        public int id_docente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string ci { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public int id_unidad { get; set; }

        public Docente(int id_docente_, string nombre_, string apellido_, string ci_, string correo_, string telefono_, int id_unidad_)
        {
            this.id_docente = id_docente_;
            this.nombre = nombre_;
            this.apellido = apellido_;
            this.ci = ci_;
            this.correo = correo_;
            this.telefono = telefono_;
            this.id_unidad = id_unidad_;
        }
    }
}
