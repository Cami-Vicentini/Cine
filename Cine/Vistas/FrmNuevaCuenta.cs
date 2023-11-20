using CineBack.Entidades;
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
    public partial class FrmNuevaCuenta : Form
    {
        //Usuario usuarioLogeando = null;
        public FrmNuevaCuenta()
        {
            InitializeComponent();
            //usuarioLogeando = new Usuario();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario1" && txtContraseña.Text == "12345")
                IniciarSesion();
            else
                MessageBox.Show("No se puede iniciar sesion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            if (txtUsuario.Text == " ")
            {
                MessageBox.Show("Debe ingresar el nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                return;
            }
            else if (txtContraseña.Text == " ")
            {
                MessageBox.Show("Debe ingresar una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Focus();
                return;
            }
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

        private void piCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir del programa?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
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

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }

        private void FrmIniciarSesion_Load(object sender, EventArgs e)
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
