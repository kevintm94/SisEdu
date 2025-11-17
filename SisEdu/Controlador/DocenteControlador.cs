using SisEdu.Modelo;
using SisEdu.Datos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SisEdu.Controlador
{
    class DocenteControlador
    {
        private DocenteBD docenteBD = new DocenteBD();
        public Docente obtener(string email) 
        {
            return docenteBD.obtenerDocente(email);
        }

        public bool iniciarSesion(string correo, string contrasena)
        {
            bool respuesta = false;
            if (correo == string.Empty || contrasena == string.Empty)
            {
                MessageBox.Show("Debe ingresar datos obligatorios");
                return respuesta;
            }
            Docente docente = docenteBD.obtenerDocente(correo);
            if (docente.id_docente == 0)
            {
                MessageBox.Show("Usuario no se encuentra en el registro");
            }
            else
            {
                if (docente.ci == contrasena)
                {
                    respuesta = true;
                    MessageBox.Show($"Bienvenid@ {docente.nombre} {docente.apellido}");
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            return respuesta;
        }
    }
}
