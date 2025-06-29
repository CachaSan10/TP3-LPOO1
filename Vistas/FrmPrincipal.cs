using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClasesBase;

namespace Vistas
{
    public partial class FrmPrincipal : Form
    {

        private Usuario usuarioLogueado;

        public FrmPrincipal(Usuario user)
        {
            InitializeComponent();
            usuarioLogueado = user;
            aplicarPermisos();
        }

        private void altaDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente oFrmCliente = new FrmCliente();
            oFrmCliente.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que quiere salir del sistema?", "Confirmación", MessageBoxButtons.YesNo);
            
            if (result == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void aBMUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario oFrmUsuario = new FrmUsuario();
            oFrmUsuario.Show();
        }

        private void altaDePeríodoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmPeriodo oFrmPeriodo = new FrmPeriodo();
            oFrmPeriodo.Show();
        }

        private void aBMDestinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDestino oFrmDestino = new FrmDestino();
            oFrmDestino.Show();
        }

        private void aplicarPermisos() {

            string rol = usuarioLogueado.Rol_codigo;

            if (rol == "ADM") {

                clientesToolStripMenuItem1.Visible = false;
                prestamosToolStripMenuItem.Visible = false;
            }
            else if (rol == "OPE") {

                usuariosToolStripMenuItem.Visible = false;
                periodoToolStripMenuItem.Visible = false;
                destinoToolStripMenuItem.Visible = false;
            }
            else if (rol == "AUD") { 
                
            }
        }

        private void altaDePrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrestamo oFrmPrestamo = new FrmPrestamo();
            oFrmPrestamo.Show();

        }

        private void listadoDePréstamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoPrestamo oFrmListadoPrestamo = new FrmListadoPrestamo();
            oFrmListadoPrestamo.Show();
        }
        private void pagosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmPago oFrmPago = new FrmPago();
            oFrmPago.Show();
        }

        private void listadoDePagosRealizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaPagos oFrmListadoPagos = new FrmListaPagos();
            oFrmListadoPagos.Show();
        }

    }
}
