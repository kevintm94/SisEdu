using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisEdu.Vista
{
    public partial class Home : Form
    {
        public Home(string correo)
        {
            InitializeComponent();
        }

        private void registrarAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asistencia asistencia = new Asistencia();
            asistencia.ShowDialog();
        }

        private void registToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calificacion calificacion = new Calificacion();
            calificacion.ShowDialog();
        }
    }
}
