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
    public partial class FrmListadoPrestamo : Form
    {
        public FrmListadoPrestamo()
        {
            InitializeComponent();
        }

        private void FrmListadoPrestamo_Load(object sender, EventArgs e)
        {
            dgvPrestamos.DataSource = TrabajarPrestamo.exec_listar_prestamos_vw("");
            loadComboDestinos();
        }
        private void loadComboDestinos()
        {
            cmbDestinos.DisplayMember = "des_descripcion";
            cmbDestinos.ValueMember = "des_codigo";
            cmbDestinos.DataSource = TrabajarPrestamo.list_destinos();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvPrestamos.DataSource = TrabajarPrestamo.exec_listar_prestamos_vw("");
        }

        private void btnConsultaFecha_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;

            if (desde > hasta)
            {
                MessageBox.Show("La fecha desde no puede ser mayor que la fecha hasta.");
                return;
            }

            dgvPrestamos.DataSource = TrabajarPrestamo.exec_listar_prestamos_por_fechas_vw(desde, hasta);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvPrestamos.DataSource = TrabajarPrestamo.exec_listar_prestamos_vw(cmbDestinos.Text);
        }
    }
}
