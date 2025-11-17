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
    public partial class Calificacion : Form
{
    CalificacionController controller = new CalificacionController();

    public Calificacion()
    {
        InitializeComponent();
        CargarCombos();
        CargarTabla();
    }

    void CargarCombos()
    {
        // Estudiantes
        cmbEstudiante.DataSource = controller.ObtenerEstudiantes();
        cmbEstudiante.DisplayMember = "nombre";
        cmbEstudiante.ValueMember = "id_estudiante";

        // Materias
        cmbMateria.DataSource = controller.ObtenerMaterias();
        cmbMateria.DisplayMember = "nombre";
        cmbMateria.ValueMember = "id_materia";

        // Bimestres
        cmbBimestre.Items.Add("1");
        cmbBimestre.Items.Add("2");
        cmbBimestre.Items.Add("3");
        cmbBimestre.Items.Add("4");
        cmbBimestre.SelectedIndex = 0;
    }

    void CargarTabla()
    {
        dgvCalificaciones.DataSource = controller.ObtenerCalificaciones();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        try
        {
            //Calificacion c = new Calificacion
            SisEdu.Modelo.Calificacion c = new SisEdu.Modelo.Calificacion
            {
                IdEstudiante = Convert.ToInt32(cmbEstudiante.SelectedValue),
                IdMateria = Convert.ToInt32(cmbMateria.SelectedValue),
                Bimestre = Convert.ToInt32(cmbBimestre.SelectedItem),
                Nota = Convert.ToDecimal(txtNota.Text)
            };

            if (controller.RegistrarCalificacion(c))
            {
                MessageBox.Show("Calificación registrada con éxito");
                CargarTabla(); // refresca la tabla
            }
            else
            {
                MessageBox.Show("No se pudo registrar");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }
}
}
