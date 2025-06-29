namespace Vistas
{
    partial class FrmCliente
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bntGuardar = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtIngresos = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuscarApellido = new System.Windows.Forms.TextBox();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnLimpiarCliente = new System.Windows.Forms.Button();
            this.btnVolverABM = new System.Windows.Forms.Button();
            this.btn_VerClientesOrdenados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Género";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ingresos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 218);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dirección";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 247);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Teléfono";
            // 
            // bntGuardar
            // 
            this.bntGuardar.Location = new System.Drawing.Point(80, 304);
            this.bntGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.bntGuardar.Name = "bntGuardar";
            this.bntGuardar.Size = new System.Drawing.Size(80, 28);
            this.bntGuardar.TabIndex = 0;
            this.bntGuardar.Text = "Guardar";
            this.bntGuardar.UseVisualStyleBackColor = true;
            this.bntGuardar.Click += new System.EventHandler(this.bntGuardar_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(220, 40);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(167, 20);
            this.txtDNI.TabIndex = 17;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(220, 69);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 20);
            this.txtNombre.TabIndex = 18;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(220, 98);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(167, 20);
            this.txtApellido.TabIndex = 19;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(220, 128);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(167, 20);
            this.txtSexo.TabIndex = 20;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(220, 157);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(167, 20);
            this.dtpFechaNacimiento.TabIndex = 21;
            // 
            // txtIngresos
            // 
            this.txtIngresos.Location = new System.Drawing.Point(220, 186);
            this.txtIngresos.Margin = new System.Windows.Forms.Padding(2);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.Size = new System.Drawing.Size(167, 20);
            this.txtIngresos.TabIndex = 22;
            this.txtIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(220, 215);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(167, 20);
            this.txtDireccion.TabIndex = 23;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(220, 245);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(167, 20);
            this.txtTelefono.TabIndex = 1;
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(469, 141);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowTemplate.Height = 24;
            this.dgvCliente.Size = new System.Drawing.Size(564, 316);
            this.dgvCliente.TabIndex = 24;
            this.dgvCliente.CurrentCellChanged += new System.EventHandler(this.dgvCliente_CurrentCellChanged);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(192, 304);
            this.btnModificarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(72, 28);
            this.btnModificarCliente.TabIndex = 25;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(296, 304);
            this.btnEliminarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(74, 28);
            this.btnEliminarCliente.TabIndex = 26;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(650, 45);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Apellido";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(650, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Nombre";
            // 
            // txtBuscarApellido
            // 
            this.txtBuscarApellido.Location = new System.Drawing.Point(716, 42);
            this.txtBuscarApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarApellido.Name = "txtBuscarApellido";
            this.txtBuscarApellido.Size = new System.Drawing.Size(199, 20);
            this.txtBuscarApellido.TabIndex = 29;
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(716, 74);
            this.txtBuscarNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(199, 20);
            this.txtBuscarNombre.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(736, 15);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "BUSQUEDA DE CLIENTES";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(739, 101);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(68, 26);
            this.btnBuscarCliente.TabIndex = 32;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnLimpiarCliente
            // 
            this.btnLimpiarCliente.Location = new System.Drawing.Point(827, 101);
            this.btnLimpiarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarCliente.Name = "btnLimpiarCliente";
            this.btnLimpiarCliente.Size = new System.Drawing.Size(63, 26);
            this.btnLimpiarCliente.TabIndex = 33;
            this.btnLimpiarCliente.Text = "Limpiar";
            this.btnLimpiarCliente.UseVisualStyleBackColor = true;
            this.btnLimpiarCliente.Click += new System.EventHandler(this.btnLimpiarCliente_Click);
            // 
            // btnVolverABM
            // 
            this.btnVolverABM.Location = new System.Drawing.Point(80, 373);
            this.btnVolverABM.Name = "btnVolverABM";
            this.btnVolverABM.Size = new System.Drawing.Size(105, 21);
            this.btnVolverABM.TabIndex = 34;
            this.btnVolverABM.Text = "Volver a vista ABM";
            this.btnVolverABM.UseVisualStyleBackColor = true;
            this.btnVolverABM.Click += new System.EventHandler(this.btnVolverABM_Click);
            // 
            // btn_VerClientesOrdenados
            // 
            this.btn_VerClientesOrdenados.Location = new System.Drawing.Point(220, 373);
            this.btn_VerClientesOrdenados.Name = "btn_VerClientesOrdenados";
            this.btn_VerClientesOrdenados.Size = new System.Drawing.Size(135, 23);
            this.btn_VerClientesOrdenados.TabIndex = 35;
            this.btn_VerClientesOrdenados.Text = "Ver Clientes Ordenados";
            this.btn_VerClientesOrdenados.UseVisualStyleBackColor = true;
            this.btn_VerClientesOrdenados.Click += new System.EventHandler(this.btn_VerClientesOrdenados_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 500);
            this.Controls.Add(this.btn_VerClientesOrdenados);
            this.Controls.Add(this.btnVolverABM);
            this.Controls.Add(this.btnLimpiarCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBuscarNombre);
            this.Controls.Add(this.txtBuscarApellido);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtIngresos);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.bntGuardar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCliente";
            this.Text = "Alta Cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bntGuardar;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtIngresos;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBuscarApellido;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnLimpiarCliente;
        private System.Windows.Forms.Button btnVolverABM;
        private System.Windows.Forms.Button btn_VerClientesOrdenados;
    }
}