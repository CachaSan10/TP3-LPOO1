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
    public partial class FrmPeriodo : Form
    {
        public FrmPeriodo()
        {
            InitializeComponent();
        }

        private void btnPerGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea guardar los datos de Periodo?", "Confirmación", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Periodo oPeriodo = new Periodo();

                oPeriodo.Per_descripcion = txtPerDescripcion.Text;

                TrabajarPeriodo.insert_periodo(oPeriodo);

                MessageBox.Show("Datos de Periodo \n" +
                        "Descripción: " + oPeriodo.Per_descripcion + "\n"
                    );
            }

            limpiarCampos();
            
        }

        private void limpiarCampos() {

            txtPerDescripcion.Clear();
        
        }

       
    }
}
