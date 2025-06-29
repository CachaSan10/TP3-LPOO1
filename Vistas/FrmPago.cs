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
    public partial class FrmPago : Form
    {
        private bool cargandoCuotas = false;

        public FrmPago()
        {
            InitializeComponent();
        }

        private void FrmPago_Load(object sender, EventArgs e)
        {
            load_combo_cliente();
            cmbClientePago.SelectedIndexChanged += cmbClientePago_SelectedIndexChanged;
        }

        private void load_combo_cliente()
        {

            cmbClientePago.DisplayMember = "NombreCompleto";
            cmbClientePago.ValueMember = "cli_dni";
            cmbClientePago.DataSource = TrabajarPago.exec_list_clientes_sp();
            cmbClientePago.SelectedIndex = -1;
        }


        private void cmbClientePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_combo_prestamo();
            load_cuotas();
        }



        private void load_combo_prestamo()
        {

            if (cmbClientePago.SelectedIndex != -1)
            {

                string dni = cmbClientePago.SelectedValue.ToString();

                DataTable dtPrestamos = TrabajarPago.exec_list_prestamo_sp(dni);

                if (dtPrestamos.Rows.Count > 0)
                {
                    cmbPrestamosDeCliente.DataSource = dtPrestamos;
                    cmbPrestamosDeCliente.DisplayMember = "NumeroPrestamo";
                    cmbPrestamosDeCliente.ValueMember = "NumeroPrestamo";
                }
                else
                {
                    MessageBox.Show("Este cliente no posee préstamos pendientes.");
                    cmbPrestamosDeCliente.DataSource = null;
                }
            }
        }

        public void load_cuotas()
        {

            if (cmbPrestamosDeCliente.SelectedIndex != -1)
            {

                cargandoCuotas = true;

                int numPrestamo = int.Parse(cmbPrestamosDeCliente.SelectedValue.ToString());
                dgvPago.DataSource = TrabajarPago.exec_list_cuotas_pendientes_sp(numPrestamo);

                txtCuotaSeleccionada.Clear();
                cargandoCuotas = false;
            }
            else
            {
                dgvPago.DataSource = null;
                txtCuotaSeleccionada.Clear();
            }
        }

        public void dgvPago_CurrentCellChanged(object sender, EventArgs e)
        {

            if (cargandoCuotas) return;

            if (dgvPago.CurrentRow != null)
            {

                txtCuotaSeleccionada.Text = dgvPago.CurrentRow.Cells["cuo_numero"].Value.ToString();
            }

        }


        private void btnPagarCuotaPrestamo_Click_1(object sender, EventArgs e)
        {
            if (dgvPago.CurrentRow == null)
            {

                MessageBox.Show("Debe seleccionar una cuota a pagar.");
                return;
            }

            if (cmbPrestamosDeCliente.SelectedIndex == -1)
            {

                MessageBox.Show("Debe selecciona un préstamo.");
                return;
            }

            int pre_numero = int.Parse(cmbPrestamosDeCliente.SelectedValue.ToString());

            int cuo_codigo = Convert.ToInt32(dgvPago.CurrentRow.Cells["cuo_codigo"].Value);
            decimal importe = Convert.ToDecimal(dgvPago.CurrentRow.Cells["cuo_importe"].Value);
            DateTime fechaPago = DateTime.Now;

            Pago oPago = new Pago();
            oPago.Cuo_codigo = cuo_codigo;
            oPago.Pag_fecha = fechaPago;
            oPago.Pag_importe = importe;

            bool prestamoCancelado = TrabajarPago.registrarPago(oPago, pre_numero);

            MessageBox.Show("Pago registrado correctamente.");

            if (prestamoCancelado)
            {
                MessageBox.Show("El préstamo ha sido cancelado. Todas las cuotas han sido pagadas.");
            }

            load_cuotas();
            txtCuotaSeleccionada.Clear();
        }
    }
}
