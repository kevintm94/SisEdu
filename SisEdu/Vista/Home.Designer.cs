namespace SisEdu.Vista
{
    partial class Home
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
            menuStrip1 = new MenuStrip();
            asistenciaToolStripMenuItem = new ToolStripMenuItem();
            registrarAsistenciaToolStripMenuItem = new ToolStripMenuItem();
            notasToolStripMenuItem = new ToolStripMenuItem();
            registToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { asistenciaToolStripMenuItem, notasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(908, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // asistenciaToolStripMenuItem
            // 
            asistenciaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarAsistenciaToolStripMenuItem });
            asistenciaToolStripMenuItem.Name = "asistenciaToolStripMenuItem";
            asistenciaToolStripMenuItem.Size = new Size(72, 20);
            asistenciaToolStripMenuItem.Text = "Asistencia";
            // 
            // registrarAsistenciaToolStripMenuItem
            // 
            registrarAsistenciaToolStripMenuItem.Name = "registrarAsistenciaToolStripMenuItem";
            registrarAsistenciaToolStripMenuItem.Size = new Size(180, 22);
            registrarAsistenciaToolStripMenuItem.Text = "Registrar asistencia";
            registrarAsistenciaToolStripMenuItem.Click += registrarAsistenciaToolStripMenuItem_Click;
            // 
            // notasToolStripMenuItem
            // 
            notasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registToolStripMenuItem });
            notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            notasToolStripMenuItem.Size = new Size(50, 20);
            notasToolStripMenuItem.Text = "Notas";
            // 
            // registToolStripMenuItem
            // 
            registToolStripMenuItem.Name = "registToolStripMenuItem";
            registToolStripMenuItem.Size = new Size(180, 22);
            registToolStripMenuItem.Text = "Registrar Notas";
            registToolStripMenuItem.Click += registToolStripMenuItem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 497);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Home";
            Text = "Home";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem asistenciaToolStripMenuItem;
        private ToolStripMenuItem registrarAsistenciaToolStripMenuItem;
        private ToolStripMenuItem notasToolStripMenuItem;
        private ToolStripMenuItem registToolStripMenuItem;
    }
}