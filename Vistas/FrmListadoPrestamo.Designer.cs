namespace Vistas
{
    partial class FrmListadoPrestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConsultaFecha = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cmbDestinos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Location = new System.Drawing.Point(12, 72);
            this.dgvPrestamos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.RowTemplate.Height = 24;
            this.dgvPrestamos.Size = new System.Drawing.Size(1089, 433);
            this.dgvPrestamos.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConsultaFecha);
            this.groupBox2.Controls.Add(this.dtpHasta);
            this.groupBox2.Controls.Add(this.dtpDesde);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(639, 55);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listar por rango de fechas";
            // 
            // btnConsultaFecha
            // 
            this.btnConsultaFecha.Location = new System.Drawing.Point(542, 20);
            this.btnConsultaFecha.Name = "btnConsultaFecha";
            this.btnConsultaFecha.Size = new System.Drawing.Size(87, 23);
            this.btnConsultaFecha.TabIndex = 4;
            this.btnConsultaFecha.Text = "Consultar";
            this.btnConsultaFecha.UseVisualStyleBackColor = true;
            this.btnConsultaFecha.Click += new System.EventHandler(this.btnConsultaFecha_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(309, 23);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 3;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(50, 23);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Desde";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(1011, 522);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.cmbDestinos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(670, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 54);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de prestamos";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(323, 20);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(87, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cmbDestinos
            // 
            this.cmbDestinos.FormattingEnabled = true;
            this.cmbDestinos.Location = new System.Drawing.Point(120, 22);
            this.cmbDestinos.Name = "cmbDestinos";
            this.cmbDestinos.Size = new System.Drawing.Size(176, 21);
            this.cmbDestinos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar por destino:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(930, 522);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmListadoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 557);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvPrestamos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmListadoPrestamo";
            this.Text = "FrmListadoPrestamo";
            this.Load += new System.EventHandler(this.FrmListadoPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConsultaFecha;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cmbDestinos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
    }
}