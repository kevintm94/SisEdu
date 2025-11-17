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
        public Docente()
        {
            this.id_docente = 0;
            this.nombre = "";
            this.apellido = "";
            this.ci = "";
            this.correo = "";
            this.telefono = "";
            this.id_unidad = 0;
        }
    }
}
