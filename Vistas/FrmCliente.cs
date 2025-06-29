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
    public partial class FrmCliente : Form
    {

        private bool activarCambio = false; // esto es para manejar que el form no venga con datos precargados
        private bool esConsulta = false;
        public FrmCliente()
        {
            InitializeComponent();
        }

      

        private void bntGuardar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Desea guardar los datos del cliente?", "Confirmación", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                Cliente oCliente = new Cliente();

                oCliente.Cli_dni = txtDNI.Text;
                oCliente.Cli_nombre = txtNombre.Text;
                oCliente.Cli_apellido = txtApellido.Text;
                oCliente.Cli_sexo = txtSexo.Text;
                oCliente.Cli_fechaNacimiento = dtpFechaNacimiento.Value;
                oCliente.Cli_ingresos = decimal.Parse(txtIngresos.Text);
                oCliente.Cli_direccion = txtDireccion.Text;
                oCliente.Cli_telefono =  txtTelefono.Text;

                TrabajarCliente.insert_cliente(oCliente);
               
                MessageBox.Show("Cliente Cargado:\n" +
                    "DNI: " + oCliente.Cli_dni + "\n" +
                    "Nombre: " + oCliente.Cli_nombre + "\n" +
                    "Apellido: " + oCliente.Cli_apellido + "\n" +
                    "Género: " + oCliente.Cli_sexo + "\n" +
                    "Fecha de Nacimiento: " + oCliente.Cli_fechaNacimiento.ToShortDateString() + "\n" +
                    "Ingresos: $" + oCliente.Cli_ingresos.ToString("N2") + "\n" +
                    "Dirección: " + oCliente.Cli_direccion + "\n" +
                    "Teléfono: " + oCliente.Cli_telefono + "\n"
               );

                load_clientes();
                limpiarCampos();
            }

        }


        private void FrmCliente_Load(object sender, EventArgs e)
        {
            activarCambio = false;
            load_clientes();
            activarCambio = true;
        }



        private void load_clientes() {

            dgvCliente.DataSource = TrabajarCliente.list_clientes();
        }


        private void dgvCliente_CurrentCellChanged(object sender, EventArgs e) {

            if (!activarCambio || esConsulta) return;

            if (dgvCliente.CurrentRow != null) {

                txtDNI.ReadOnly = true;

                txtDNI.Text = dgvCliente.CurrentRow.Cells["Dni Cliente"].Value.ToString();
                txtNombre.Text = dgvCliente.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvCliente.CurrentRow.Cells["Apellido"].Value.ToString();
                txtSexo.Text = dgvCliente.CurrentRow.Cells["Sexo"].Value.ToString();

                if (dgvCliente.CurrentRow.Cells["Fecha de Nacimiento"].Value != DBNull.Value)
                {
                    dtpFechaNacimiento.Value = Convert.ToDateTime(dgvCliente.CurrentRow.Cells["Fecha de Nacimiento"].Value);
                }
                else
                {
                    // o podemos setear la fecha de hoy
                }

                txtIngresos.Text = dgvCliente.CurrentRow.Cells["Ingresos"].Value.ToString();
                txtDireccion.Text = dgvCliente.CurrentRow.Cells["Dirección"].Value.ToString();
                txtTelefono.Text = dgvCliente.CurrentRow.Cells["Telefono"].Value.ToString();

            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        { 
             
            if (txtDNI.Text != "")
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea actualizar este cliente?", "Confirmación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes) {

                    Cliente oCliente = new Cliente();

                    oCliente.Cli_dni = txtDNI.Text;
                    oCliente.Cli_nombre = txtNombre.Text;
                    oCliente.Cli_apellido = txtApellido.Text;
                    oCliente.Cli_sexo = txtSexo.Text;
                    oCliente.Cli_fechaNacimiento = dtpFechaNacimiento.Value;
                    oCliente.Cli_ingresos = decimal.Parse(txtIngresos.Text);
                    oCliente.Cli_direccion = txtDireccion.Text;
                    oCliente.Cli_telefono = txtTelefono.Text;

                    TrabajarCliente.update_cliente(oCliente);
                    load_clientes();
                    limpiarCampos();

                    MessageBox.Show("Cliente actualizado correctamente.");
                
                }   

            }
            else {

                MessageBox.Show("Debe seleccionar un cliente primero.");
            
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text != "")
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar este cliente?", "Confirmación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes) {

                    string dni = txtDNI.Text;
                    TrabajarCliente.delete_cliente(dni);

                    load_clientes();
                    limpiarCampos();
                    MessageBox.Show("Cliente eliminado correctamente.");
                }

            }
            else {

                MessageBox.Show("Debe seleccionar un cliente primero.");
            }
        }





        private void limpiarCampos() {

            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtSexo.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;
            txtIngresos.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtDNI.ReadOnly = false;
            
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

            string apellido = txtBuscarApellido.Text.Trim();
            string nombre = txtBuscarNombre.Text.Trim();

            if (apellido != "" || nombre != "")
            {

                dgvCliente.DataSource = TrabajarCliente.search_clientes(apellido, nombre);
            }
            else {
                load_clientes();
            }
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            txtBuscarApellido.Clear();
            txtBuscarNombre.Clear();
            load_clientes();
        }

        private void btnVolverABM_Click(object sender, EventArgs e)
        {
            esConsulta = false;
            load_clientes();

        }

        private void btn_VerClientesOrdenados_Click(object sender, EventArgs e)
        {
            esConsulta = true;
            dgvCliente.DataSource = TrabajarCliente.list_clientes_ordenados();

        }


    }
}
