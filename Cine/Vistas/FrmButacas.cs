using CineBack.Datos.Implementacion;
using CineBack.Datos.Interfaz;
using CineBack.Entidades;
using CineFront.Servicios;
using Newtonsoft.Json;
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
    public partial class FrmButacas : Form
    {
        private Funcion oFuncion;
        private IFuncionDao servicio;
        private Venta nuevaVenta;
        private int cantIngresada;
        private int butacasSelecc = 0;

        public FrmButacas(Funcion funcion, int cantidad)
        {
            InitializeComponent();
            servicio = new FuncionDao();
            nuevaVenta = new Venta();
            oFuncion = funcion;
            cantIngresada = cantidad;
        }

        private async void CargarButacas()
        {
            OrdenarControles();

            string url = $"https://localhost:7095/butacas?sala={oFuncion.oSala.IdSala}&funcion={oFuncion.FuncionId}";
            var resp = await ClienteSingleton.GetInstancia().GetAsync(url);
            oFuncion.oSala.lButacas = JsonConvert.DeserializeObject<List<Butaca>>(resp);

            Butaca[] arrButacas = oFuncion.oSala.lButacas.ToArray();

            for (int i = 0; i < pnButacas.Controls.Count; i++)
            {
                pnButacas.Controls[i].Tag = arrButacas[i]; //Almacena una Butaca en el control
                pnButacas.Controls[i].Text = arrButacas[i].FilaCol;
                if (arrButacas[i].Estado == Estado.Libre)
                {
                    pnButacas.Controls[i].BackColor = Color.Lime;
                }
                else if (arrButacas[i].Estado == Estado.Ocupado)
                {
                    pnButacas.Controls[i].Enabled = false;
                    pnButacas.Controls[i].BackColor = Color.Red;
                }
                else
                {
                    pnButacas.Controls[i].Enabled = false;
                    pnButacas.Controls[i].BackColor = Color.Red;
                }
                pnButacas.Controls[i].Click += Butaca_Color;
                pnButacas.Controls[i].Click += SelecButacas_Click;

            }
        }


        private void SelecButacas_Click(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is Butaca butaca)
            {
                Entrada nuevaEntrada = new Entrada(butaca);
                if (nuevaVenta.AgregarEntrada(nuevaEntrada))
                {
                    dgvButacasSeleccionadas.Rows.Clear();
                    foreach (Entrada entrada in nuevaVenta.lEntradas)
                    {
                        dgvButacasSeleccionadas.Rows.Add(new object[] { entrada.Butaca.FilaCol, entrada.Precio });
                    }
                    butacasSelecc++;
                    lblButacasSelecc.Text = $"Butacas seleccionadas: {butacasSelecc}/{cantIngresada}";
                }
                else
                {
                    dgvButacasSeleccionadas.Rows.Clear();
                    nuevaVenta.QuitarEntrada(nuevaEntrada);
                    foreach (Entrada entrada in nuevaVenta.lEntradas)
                    {
                        dgvButacasSeleccionadas.Rows.Add(new object[] { entrada.Butaca.FilaCol, entrada.Precio });
                    }
                    butacasSelecc--;
                    lblButacasSelecc.Text = $"Butacas seleccionadas: {butacasSelecc.ToString()}/{cantIngresada}";
                }
            }
        }

        private void Butaca_Color(object sender, EventArgs e)
        {
            Button botonSeleccionado = (Button)sender;
            if (botonSeleccionado.BackColor == Color.Yellow)
            {
                botonSeleccionado.BackColor = Color.Lime;
            }
            else
            {
                botonSeleccionado.BackColor = Color.Yellow;
            }
        }

        private void OrdenarControles()
        {
            List<Button> listaBotones = pnButacas.Controls.OfType<Button>().ToList();
            listaBotones = listaBotones.OrderBy(b => int.Parse(b.Text)).ToList();
            pnButacas.Controls.Clear();
            pnButacas.Controls.AddRange(listaBotones.ToArray());
        }

        private void btnBorrarSeleccion_Click(object sender, EventArgs e)
        {
            dgvButacasSeleccionadas.Rows.Clear();
            nuevaVenta.lEntradas.Clear();
            foreach (Entrada entrada in nuevaVenta.lEntradas)
            {
                dgvButacasSeleccionadas.Rows.Add(new object[] { entrada.Butaca.FilaCol, entrada.Precio });
            }
            foreach (Button b in pnButacas.Controls)
            {
                if (b.BackColor == Color.Yellow)
                {
                    b.BackColor = Color.Lime;
                }
            }
            pnButacas.Enabled = true;
            butacasSelecc = 0;
            lblButacasSelecc.Text = $"Butacas seleccionadas: {butacasSelecc.ToString()}/{cantIngresada}";
            btnBorrarSeleccion.Enabled = false;
        }

        private void lblButacasSelecc_TextChanged(object sender, EventArgs e)
        {
            if (butacasSelecc == cantIngresada)
            {
                pnButacas.Enabled = false;
                btnBorrarSeleccion.Enabled = true;
            }
        }

        private void FrmButacas_Load(object sender, EventArgs e)
        {
            CargarButacas();
            lblButacasSelecc.Text += $"0/{cantIngresada}";
            this.Text += oFuncion.oSala.IdSala.ToString();
            lblPelicula.Text = oFuncion.oPelicula.Titulo;
            lblHora.Text = oFuncion.HoraMostrar;
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            //Validar
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
