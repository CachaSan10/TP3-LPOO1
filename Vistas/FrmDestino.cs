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
    public partial class FrmDestino : Form
    {
        private bool activarCambio = false; // esto es para manejar que el form no venga con datos precargados

        public FrmDestino()
        {
            InitializeComponent();
        }

        private void btnDesGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea guardar los datos de Destino?", "Confirmación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Destino oDestino = new Destino();

                    oDestino.Des_descripcion = txtDesDescripcion.Text;

                    TrabajarDestino.exec_insert_destino_sp(oDestino);
                

                    MessageBox.Show("Datos de Destino: \n" +
                        "Descripción: " + oDestino.Des_descripcion + "\n"
                        );

                    load_destinos();
                    limpiarCampos();
            
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }


        private void FrmDestino_Load(object sender, EventArgs e) {
            activarCambio = false;

            load_destinos();

            activarCambio = true;
        }


        private void load_destinos() {
            dgvDestino.DataSource = TrabajarDestino.exec_list_destinos_sp();
        }


        private void dgvDestino_CurrentCellChanged(object sender, EventArgs e) {

            if (!activarCambio) return;

            if (dgvDestino.CurrentRow != null) {

                txtDesCodigo.Text = dgvDestino.CurrentRow.Cells["Codigo"].Value.ToString();
                txtDesDescripcion.Text = dgvDestino.CurrentRow.Cells["Descripcion"].Value.ToString();
            }
        }



        private void btnModificarDestino_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDesCodigo.Text != "")
                {

                    DialogResult result = MessageBox.Show("¿Está seguro que desea modificar este Destino?", "Confirmación", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {

                        Destino oDestino = new Destino();

                        oDestino.Des_codigo = int.Parse(txtDesCodigo.Text);
                        oDestino.Des_descripcion = txtDesDescripcion.Text;

                        TrabajarDestino.exec_update_destino_sp(oDestino);
                        load_destinos();
                        limpiarCampos();

                        MessageBox.Show("Destino actualizado correctamente.");

                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar un destino primero.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }



        private void btnEliminarDestino_Click(object sender, EventArgs e)
        {
            if (txtDesCodigo.Text != "") {

                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar este Destino?", "Confirmación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes) {

                    int codigo = int.Parse(txtDesCodigo.Text);
                    TrabajarDestino.exec_delete_destino_sp(codigo);

                    load_destinos();
                    limpiarCampos();
                    MessageBox.Show("Destino eliminado correctamente.");
                }
                
            }
            else {

                MessageBox.Show("Debe seleccionar un Destino para eliminar");
            }
        }


        private void limpiarCampos() {

            txtDesCodigo.Clear();
            txtDesDescripcion.Clear();
        
        }





    }
}
