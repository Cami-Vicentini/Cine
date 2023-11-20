using CineBack.Entidades;

namespace CineFront2
{
    public partial class FrmInsertarPelicula : Form
    {
        private string[] genero = { "Terror", "Accion", "Comedia", "Suspenso", "Ciencia Ficcion", "Drama" };
        private string[] idioma = { "Ingles", "Español", "Subtitulada", "Chino" };
        private string[] clasificacion = { "+13", "+15", "APT" };
        private string[] sala = { "1", "2", "3", "4" };
        Funcion nueva = null;
        public FrmInsertarPelicula()
        {
            InitializeComponent();
            nueva = new Funcion();
        }

        private void FrmInsertarPelicula_Load(object sender, EventArgs e)
        {
            cboGenero.Items.AddRange(genero);
            cboIdioma.Items.AddRange(idioma);
            cboClasificacion.Items.AddRange(clasificacion);
            cboSala.Items.AddRange(sala);
            Limpiar();
            txtTitulo.Focus();
        }

        private void Limpiar()
        {
            txtTitulo.Text = string.Empty;
            txtDirector.Text = string.Empty;
            nudDuracion.Value = 0;
            cboGenero.SelectedIndex = -1;
            cboIdioma.SelectedIndex = -1;
            cboClasificacion.SelectedIndex = -1;
            cboSala.SelectedIndex = -1;
            dtpDia.Value = DateTime.Today;
            dtpHora.Value = DateTime.Now;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GrabarPelicula();
            }
        }

        private void GrabarPelicula()
        {
            throw new NotImplementedException();
        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                MessageBox.Show("Debe ingresar el titulo de la pelicula", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un genero", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboIdioma.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un idioma", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboClasificacion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una clasificacion", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (nudDuracion.Value <= 0)
            {
                MessageBox.Show("Debe ingresar una duracion valida", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboSala.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una sala ", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (dtpDia.Value < DateTime.Today)
            {
                MessageBox.Show("Debe ingresar una fecha valida", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void cboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void nudDuracion_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dtpHora_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dtpDia_ValueChanged(object sender, EventArgs e)
        {
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Salir..", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}