namespace Vistas
{
    partial class FrmPago
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnPagarCuotaPrestamo = new System.Windows.Forms.Button();
            this.txtCuotaSeleccionada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPago = new System.Windows.Forms.DataGridView();
            this.cmbPrestamosDeCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbClientePago = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaDePago = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPago)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "SELECCIONE CUOTA A PAGAR:";
            // 
            // btnPagarCuotaPrestamo
            // 
            this.btnPagarCuotaPrestamo.Location = new System.Drawing.Point(105, 290);
            this.btnPagarCuotaPrestamo.Margin = new System.Windows.Forms.Padding(2);
            this.btnPagarCuotaPrestamo.Name = "btnPagarCuotaPrestamo";
            this.btnPagarCuotaPrestamo.Size = new System.Drawing.Size(94, 28);
            this.btnPagarCuotaPrestamo.TabIndex = 21;
            this.btnPagarCuotaPrestamo.Text = "Pagar";
            this.btnPagarCuotaPrestamo.UseVisualStyleBackColor = true;
            this.btnPagarCuotaPrestamo.Click += new System.EventHandler(this.btnPagarCuotaPrestamo_Click_1);
            // 
            // txtCuotaSeleccionada
            // 
            this.txtCuotaSeleccionada.Location = new System.Drawing.Point(160, 234);
            this.txtCuotaSeleccionada.Margin = new System.Windows.Forms.Padding(2);
            this.txtCuotaSeleccionada.Name = "txtCuotaSeleccionada";
            this.txtCuotaSeleccionada.ReadOnly = true;
            this.txtCuotaSeleccionada.Size = new System.Drawing.Size(151, 20);
            this.txtCuotaSeleccionada.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Cuota a Pagar";
            // 
            // dgvPago
            // 
            this.dgvPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPago.Location = new System.Drawing.Point(366, 69);
            this.dgvPago.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPago.Name = "dgvPago";
            this.dgvPago.RowTemplate.Height = 24;
            this.dgvPago.Size = new System.Drawing.Size(672, 318);
            this.dgvPago.TabIndex = 22;
            this.dgvPago.CurrentCellChanged += new System.EventHandler(this.dgvPago_CurrentCellChanged);
            // 
            // cmbPrestamosDeCliente
            // 
            this.cmbPrestamosDeCliente.FormattingEnabled = true;
            this.cmbPrestamosDeCliente.Location = new System.Drawing.Point(160, 189);
            this.cmbPrestamosDeCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPrestamosDeCliente.Name = "cmbPrestamosDeCliente";
            this.cmbPrestamosDeCliente.Size = new System.Drawing.Size(151, 21);
            this.cmbPrestamosDeCliente.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Prestamos de Cliente";
            // 
            // cmbClientePago
            // 
            this.cmbClientePago.FormattingEnabled = true;
            this.cmbClientePago.Location = new System.Drawing.Point(160, 153);
            this.cmbClientePago.Margin = new System.Windows.Forms.Padding(2);
            this.cmbClientePago.Name = "cmbClientePago";
            this.cmbClientePago.Size = new System.Drawing.Size(151, 21);
            this.cmbClientePago.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cliente";
            // 
            // dtpFechaDePago
            // 
            this.dtpFechaDePago.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaDePago.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDePago.Location = new System.Drawing.Point(160, 120);
            this.dtpFechaDePago.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaDePago.Name = "dtpFechaDePago";
            this.dtpFechaDePago.Size = new System.Drawing.Size(151, 20);
            this.dtpFechaDePago.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fecha de Pago";
            // 
            // FrmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 418);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPagarCuotaPrestamo);
            this.Controls.Add(this.txtCuotaSeleccionada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvPago);
            this.Controls.Add(this.cmbPrestamosDeCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbClientePago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaDePago);
            this.Controls.Add(this.label1);
            this.Name = "FrmPago";
            this.Text = "FrmPago";
            this.Load += new System.EventHandler(this.FrmPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPagarCuotaPrestamo;
        private System.Windows.Forms.TextBox txtCuotaSeleccionada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPago;
        private System.Windows.Forms.ComboBox cmbPrestamosDeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbClientePago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaDePago;
        private System.Windows.Forms.Label label1;
    }
}