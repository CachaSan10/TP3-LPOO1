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
    public partial class FrmPrestamo : Form
    {
        private bool activarCambio = false; // esto es para manejar que el form no venga con datos precargados
        
        public FrmPrestamo()
        {
            InitializeComponent();
        }


        private void FrmPrestamo_Load(object sender, EventArgs e) {

            activarCambio = false;
            load_combo_cliente();
            load_combo_destino();
            load_combo_periodo();
            activarCambio = true;
        }


        private void load_combo_cliente() {

            cmbCliente.DisplayMember = "NombreCompleto";
            cmbCliente.ValueMember = "cli_dni";
            cmbCliente.DataSource = TrabajarPrestamo.list_clientes();

            Application.DoEvents(); 
            cmbCliente.SelectedIndex = -1;
        }


        private void load_combo_destino() {

            cmbDestino.DisplayMember = "des_descripcion";
            cmbDestino.ValueMember = "des_codigo";
            cmbDestino.DataSource = TrabajarPrestamo.list_destinos();

            Application.DoEvents();
            cmbDestino.SelectedIndex = -1;
        }


        private void load_combo_periodo() {

            cmbPeriodo.DisplayMember = "per_descripcion";
            cmbPeriodo.ValueMember = "per_codigo";
            cmbPeriodo.DataSource = TrabajarPrestamo.list_periodos();

            Application.DoEvents();
            cmbPeriodo.SelectedIndex = -1;
        
        }

        private void btnGuardarPrestamo_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Los datos son correctos?", "Confirmación", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                Prestamo oPrestamo = new Prestamo();

                oPrestamo.Cli_dni = cmbCliente.SelectedValue.ToString();
                oPrestamo.Des_codigo = (int)cmbDestino.SelectedValue;
                oPrestamo.Per_codigo = (int)cmbPeriodo.SelectedValue;
                oPrestamo.Pre_fecha = dtpFechaPrestamo.Value;
                oPrestamo.Pre_importe = decimal.Parse(txtImporte.Text);
                oPrestamo.Pre_tasaInteres = float.Parse(txtTasaInteres.Text);
                oPrestamo.Pre_cantidadCuotas = int.Parse(txtCantidadCuotas.Text);
                oPrestamo.Pre_estado = "PENDIENTE";

                int numeroPrestamo = TrabajarPrestamo.insert_prestamo(oPrestamo);
                TrabajarPrestamo.generarCuotas(oPrestamo, numeroPrestamo);

                MessageBox.Show("Préstamos y Cuotas registradas correctamente");
            
            }

            limpiarCampos();


        }


        public void limpiarCampos() {

            cmbCliente.SelectedIndex = -1;
            cmbDestino.SelectedIndex = -1;
            cmbPeriodo.SelectedIndex = -1;
            dtpFechaPrestamo.Value = DateTime.Today;
            txtImporte.Clear();
            txtTasaInteres.Clear();
            txtCantidadCuotas.Clear();
        }




    }
}
