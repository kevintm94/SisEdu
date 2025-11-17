namespace SisEdu.Vista
{
    partial class Calificacion
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblBimestre;
        private System.Windows.Forms.Label lblNota;

        private System.Windows.Forms.ComboBox cmbEstudiante;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.ComboBox cmbBimestre;
        private System.Windows.Forms.TextBox txtNota;

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvCalificaciones;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblBimestre = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();

            this.cmbEstudiante = new System.Windows.Forms.ComboBox();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.cmbBimestre = new System.Windows.Forms.ComboBox();
            this.txtNota = new System.Windows.Forms.TextBox();

            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvCalificaciones = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).BeginInit();

            this.SuspendLayout();

            // ======================================================
            // LABELS
            // ======================================================

            // Estudiante
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Location = new System.Drawing.Point(30, 20);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(68, 15);
            this.lblEstudiante.Text = "Estudiante:";

            // Materia
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(30, 60);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(54, 15);
            this.lblMateria.Text = "Materia:";

            // Bimestre
            this.lblBimestre.AutoSize = true;
            this.lblBimestre.Location = new System.Drawing.Point(400, 20);
            this.lblBimestre.Name = "lblBimestre";
            this.lblBimestre.Size = new System.Drawing.Size(58, 15);
            this.lblBimestre.Text = "Bimestre:";

            // Nota
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(400, 60);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(37, 15);
            this.lblNota.Text = "Nota:";

            // ======================================================
            // CONTROLES (ComboBox / TextBox)
            // ======================================================

            // combo estudiantes
            this.cmbEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstudiante.Location = new System.Drawing.Point(120, 17);
            this.cmbEstudiante.Name = "cmbEstudiante";
            this.cmbEstudiante.Size = new System.Drawing.Size(230, 23);

            // combo materias
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.Location = new System.Drawing.Point(120, 57);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(230, 23);

            // bimestre
            this.cmbBimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBimestre.Location = new System.Drawing.Point(480, 17);
            this.cmbBimestre.Name = "cmbBimestre";
            this.cmbBimestre.Size = new System.Drawing.Size(150, 23);

            // nota
            this.txtNota.Location = new System.Drawing.Point(480, 57);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(150, 23);

            // ======================================================
            // BOTÓN GUARDAR
            // ======================================================

            this.btnGuardar.Location = new System.Drawing.Point(670, 37);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 30);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // ======================================================
            // DATAGRIDVIEW
            // ======================================================

            this.dgvCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalificaciones.Location = new System.Drawing.Point(20, 110);
            this.dgvCalificaciones.Name = "dgvCalificaciones";
            this.dgvCalificaciones.RowTemplate.Height = 25;
            this.dgvCalificaciones.Size = new System.Drawing.Size(770, 320);

            // ======================================================
            // FORM
            // ======================================================

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.lblEstudiante);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblBimestre);
            this.Controls.Add(this.lblNota);

            this.Controls.Add(this.cmbEstudiante);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.cmbBimestre);
            this.Controls.Add(this.txtNota);

            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvCalificaciones);

            this.Name = "Calificacion";
            this.Text = "Registro de Calificaciones";

            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}