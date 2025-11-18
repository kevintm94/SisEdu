using SisEdu.Datos;
using SisEdu.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace SisEdu.Controlador
{
    class MateriaControlador
    {
        private MateriaBD materiaBD = new MateriaBD();

        public List<Materia> obtenerMateriasDocente(int id)
        {
            return materiaBD.obtenerMateriasDocente(id);
        }

    }
}
