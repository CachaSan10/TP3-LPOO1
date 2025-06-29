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
    public partial class FrmListaPagos : Form
    {
        public FrmListaPagos()
        {
            InitializeComponent();
        }

        private void FrmListaPagos_Load(object sender, EventArgs e)
        {
            load_combo_cliente();
        }

        private void load_combo_cliente()
        {

            cmbClientePago.DisplayMember = "NombreCompleto";
            cmbClientePago.ValueMember = "cli_dni";
            cmbClientePago.DataSource = TrabajarPago.exec_list_clientes_sp();
            cmbClientePago.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = cmbClientePago.SelectedValue.ToString();
            dtvPagos.DataSource = TrabajarPago.exec_list_pago_vw(dni);
        }
    }
}
