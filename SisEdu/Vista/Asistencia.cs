using SisEdu.Controlador;
using SisEdu.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisEdu.Vista
{
    public partial class Asistencia : Form
    {
        private int id_docente;
        public Asistencia(int id)
        {
            this.id_docente = id;
            InitializeComponent();
        }

        private void Asistencia_Load(object sender, EventArgs e)
        {
            MateriaControlador materiaControlador = new MateriaControlador();
            List<Materia> materias = materiaControlador.obtenerMateriasDocente(id_docente);
            this.cbMateria.DataSource = materias;
            this.cbMateria.DisplayMember = "nombre";
            this.cbMateria.ValueMember = "id_materia";
        }

        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            Materia materiaSeleccionada = (Materia)cbMateria.SelectedItem;
            EstudianteControlador estudianteControlador = new EstudianteControlador();
            dgvEstudiantes.DataSource = estudianteControlador.obtenerEstudiantesMateria(materiaSeleccionada.id_curso).Tables["tbl"];
        }

        private void dgvEstudiantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_estudiante = (int)dgvEstudiantes.CurrentRow.Cells["id_estudiante"].Value;
            int id_materia = int.Parse(cbMateria.SelectedValue.ToString());
            DialogResult result = MessageBox.Show(
            "Marcar asistencia",
            "Asistencia",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question);
        }
    }
}
