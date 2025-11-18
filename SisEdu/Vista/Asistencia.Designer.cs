namespace SisEdu.Vista
{
    partial class Asistencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFecha = new Label();
            dtFecha = new DateTimePicker();
            btnCargarLista = new Button();
            dgvEstudiantes = new DataGridView();
            lblMateria = new Label();
            cbMateria = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(21, 22);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(78, 18);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(231, 23);
            dtFecha.TabIndex = 1;
            // 
            // btnCargarLista
            // 
            btnCargarLista.Location = new Point(617, 18);
            btnCargarLista.Name = "btnCargarLista";
            btnCargarLista.Size = new Size(85, 23);
            btnCargarLista.TabIndex = 4;
            btnCargarLista.Text = "Cargar";
            btnCargarLista.UseVisualStyleBackColor = true;
            btnCargarLista.Click += btnCargarLista_Click;
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Location = new Point(25, 62);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.Size = new Size(677, 368);
            dgvEstudiantes.TabIndex = 5;
            dgvEstudiantes.CellDoubleClick += dgvEstudiantes_CellDoubleClick;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(374, 22);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(47, 15);
            lblMateria.TabIndex = 6;
            lblMateria.Text = "Materia";
            // 
            // cbMateria
            // 
            cbMateria.FormattingEnabled = true;
            cbMateria.Location = new Point(443, 18);
            cbMateria.Name = "cbMateria";
            cbMateria.Size = new Size(121, 23);
            cbMateria.TabIndex = 7;
            // 
            // Asistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 450);
            Controls.Add(cbMateria);
            Controls.Add(lblMateria);
            Controls.Add(dgvEstudiantes);
            Controls.Add(btnCargarLista);
            Controls.Add(dtFecha);
            Controls.Add(lblFecha);
            Name = "Asistencia";
            Text = "Asistencia";
            Load += Asistencia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private DateTimePicker dtFecha;
        private Button btnCargarLista;
        private DataGridView dgvEstudiantes;
        private Label lblMateria;
        private ComboBox cbMateria;
    }
}