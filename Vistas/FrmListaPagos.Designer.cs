namespace Vistas
{
    partial class FrmListaPagos
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbClientePago = new System.Windows.Forms.ComboBox();
            this.dtvPagos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(232, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbClientePago
            // 
            this.cmbClientePago.FormattingEnabled = true;
            this.cmbClientePago.Location = new System.Drawing.Point(12, 31);
            this.cmbClientePago.Name = "cmbClientePago";
            this.cmbClientePago.Size = new System.Drawing.Size(214, 21);
            this.cmbClientePago.TabIndex = 1;
            // 
            // dtvPagos
            // 
            this.dtvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvPagos.Location = new System.Drawing.Point(12, 74);
            this.dtvPagos.Name = "dtvPagos";
            this.dtvPagos.Size = new System.Drawing.Size(791, 376);
            this.dtvPagos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pagos Realizados";
            // 
            // FrmListaPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtvPagos);
            this.Controls.Add(this.cmbClientePago);
            this.Controls.Add(this.btnBuscar);
            this.Name = "FrmListaPagos";
            this.Text = "FrmListaPagos";
            this.Load += new System.EventHandler(this.FrmListaPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbClientePago;
        private System.Windows.Forms.DataGridView dtvPagos;
        private System.Windows.Forms.Label label1;
    }
}