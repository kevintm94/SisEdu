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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DocenteControlador doc = new DocenteControlador();
            string email = txtUser.Text;
            string ci = txtPass.Text;

            bool inicio = doc.iniciarSesion(email, ci);
            if (inicio) 
            {
                Home home = new Home(email);
                home.Show();
                this.Hide();
            }
        }
    }
}
