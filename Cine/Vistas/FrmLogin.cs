using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront.Vistas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario1" && txtContraseña.Text == "12345")
                IniciarSesion();
            else
                MessageBox.Show("No se puede iniciar sesion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void IniciarSesion()
        {
            this.Hide();
            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.FormClosed += Logout;
            menu.Show();
        }

        private void Logout(object sender, FormClosedEventArgs e) //Evento que se va a ocurrir cuando se cierre el form
        {
            txtUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            txtUsuario.Focus();
            this.Show();
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBoxOcultar_Click(object sender, EventArgs e)
        {
            picBoxMostrar.BringToFront();
            txtContraseña.UseSystemPasswordChar = false;
        }

        private void picBoxMostrar_Click(object sender, EventArgs e)
        {
            picBoxOcultar.BringToFront();
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void picMinim_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Limpieza();
            txtUsuario.Focus();
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void Limpieza()
        {
            txtUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;

        }

    }
}
