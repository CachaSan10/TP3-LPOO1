namespace Vistas
{
    partial class FrmPrestamo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.dtpFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtTasaInteres = new System.Windows.Forms.TextBox();
            this.txtCantidadCuotas = new System.Windows.Forms.TextBox();
            this.btnGuardarPrestamo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Período";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha";
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Location = new System.Drawing.Point(133, 211);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(55, 17);
            this.v.TabIndex = 8;
            this.v.Text = "Importe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tasa de Interés";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cantidad de Cuotas";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(324, 90);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(224, 24);
            this.cmbCliente.TabIndex = 1;
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(324, 123);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(224, 24);
            this.cmbDestino.TabIndex = 3;
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(324, 152);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(224, 24);
            this.cmbPeriodo.TabIndex = 5;
            // 
            // dtpFechaPrestamo
            // 
            this.dtpFechaPrestamo.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPrestamo.Location = new System.Drawing.Point(324, 184);
            this.dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            this.dtpFechaPrestamo.Size = new System.Drawing.Size(224, 22);
            this.dtpFechaPrestamo.TabIndex = 7;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(324, 213);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(224, 22);
            this.txtImporte.TabIndex = 9;
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.Location = new System.Drawing.Point(324, 241);
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.Size = new System.Drawing.Size(224, 22);
            this.txtTasaInteres.TabIndex = 11;
            // 
            // txtCantidadCuotas
            // 
            this.txtCantidadCuotas.Location = new System.Drawing.Point(324, 269);
            this.txtCantidadCuotas.Name = "txtCantidadCuotas";
            this.txtCantidadCuotas.Size = new System.Drawing.Size(224, 22);
            this.txtCantidadCuotas.TabIndex = 13;
            // 
            // btnGuardarPrestamo
            // 
            this.btnGuardarPrestamo.Location = new System.Drawing.Point(313, 348);
            this.btnGuardarPrestamo.Name = "btnGuardarPrestamo";
            this.btnGuardarPrestamo.Size = new System.Drawing.Size(101, 39);
            this.btnGuardarPrestamo.TabIndex = 14;
            this.btnGuardarPrestamo.Text = "Guardar";
            this.btnGuardarPrestamo.UseVisualStyleBackColor = true;
            this.btnGuardarPrestamo.Click += new System.EventHandler(this.btnGuardarPrestamo_Click);
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 476);
            this.Controls.Add(this.btnGuardarPrestamo);
            this.Controls.Add(this.txtCantidadCuotas);
            this.Controls.Add(this.txtTasaInteres);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.dtpFechaPrestamo);
            this.Controls.Add(this.cmbPeriodo);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.v);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrestamo";
            this.Text = "FrmPrestamo";
            this.Load += new System.EventHandler(this.FrmPrestamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.DateTimePicker dtpFechaPrestamo;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtTasaInteres;
        private System.Windows.Forms.TextBox txtCantidadCuotas;
        private System.Windows.Forms.Button btnGuardarPrestamo;
    }
}