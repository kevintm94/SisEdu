using System;
using System.Collections.Generic;
using System.Text;

namespace SisEdu.Modelo
{
    /*internal class Calificacion
    {

    }*/
    public class Calificacion
    {
        public int IdCalificacion { get; set; }
        public int IdEstudiante { get; set; }
        public int IdMateria { get; set; }
        public int Bimestre { get; set; }
        public decimal Nota { get; set; }
    }
}
