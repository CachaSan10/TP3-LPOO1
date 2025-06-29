namespace Vistas
{
    partial class FrmUsuario
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
            this.cmbRolUsuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidoyNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.dgwUsuarios = new System.Windows.Forms.DataGridView();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbApellido = new System.Windows.Forms.RadioButton();
            this.rdbUsername = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rol";
            // 
            // cmbRolUsuario
            // 
            this.cmbRolUsuario.FormattingEnabled = true;
            this.cmbRolUsuario.Location = new System.Drawing.Point(169, 93);
            this.cmbRolUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbRolUsuario.Name = "cmbRolUsuario";
            this.cmbRolUsuario.Size = new System.Drawing.Size(148, 21);
            this.cmbRolUsuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido y Nombre";
            // 
            // txtApellidoyNombre
            // 
            this.txtApellidoyNombre.Location = new System.Drawing.Point(169, 123);
            this.txtApellidoyNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellidoyNombre.Name = "txtApellidoyNombre";
            this.txtApellidoyNombre.Size = new System.Drawing.Size(148, 20);
            this.txtApellidoyNombre.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(169, 158);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(148, 20);
            this.txtUsuario.TabIndex = 7;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(169, 187);
            this.txtContrasenia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(148, 20);
            this.txtContrasenia.TabIndex = 9;
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Location = new System.Drawing.Point(94, 288);
            this.btnGuardarUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(64, 27);
            this.btnGuardarUsuario.TabIndex = 10;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // dgwUsuarios
            // 
            this.dgwUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsuarios.Location = new System.Drawing.Point(384, 93);
            this.dgwUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgwUsuarios.Name = "dgwUsuarios";
            this.dgwUsuarios.RowTemplate.Height = 24;
            this.dgwUsuarios.Size = new System.Drawing.Size(574, 322);
            this.dgwUsuarios.TabIndex = 11;
            this.dgwUsuarios.CurrentCellChanged += new System.EventHandler(this.dgwUsuarios_CurrentCellChanged);
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(384, 62);
            this.txtPattern.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(473, 20);
            this.txtPattern.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(872, 58);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 24);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Location = new System.Drawing.Point(191, 288);
            this.btnModificarUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(65, 27);
            this.btnModificarUsuario.TabIndex = 14;
            this.btnModificarUsuario.Text = "Modificar";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(282, 288);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(68, 27);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID Usuario";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(169, 227);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(76, 20);
            this.txtID.TabIndex = 17;
            this.txtID.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbUsername);
            this.groupBox1.Controls.Add(this.rdbApellido);
            this.groupBox1.Location = new System.Drawing.Point(45, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 95);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenar por";
            // 
            // rdbApellido
            // 
            this.rdbApellido.AutoSize = true;
            this.rdbApellido.Location = new System.Drawing.Point(28, 29);
            this.rdbApellido.Name = "rdbApellido";
            this.rdbApellido.Size = new System.Drawing.Size(62, 17);
            this.rdbApellido.TabIndex = 0;
            this.rdbApellido.TabStop = true;
            this.rdbApellido.Text = "Apellido";
            this.rdbApellido.UseVisualStyleBackColor = true;
            this.rdbApellido.CheckedChanged += new System.EventHandler(this.rdbOrdenar_CheckedChanged);
            // 
            // rdbUsername
            // 
            this.rdbUsername.AutoSize = true;
            this.rdbUsername.Location = new System.Drawing.Point(28, 61);
            this.rdbUsername.Name = "rdbUsername";
            this.rdbUsername.Size = new System.Drawing.Size(114, 17);
            this.rdbUsername.TabIndex = 1;
            this.rdbUsername.TabStop = true;
            this.rdbUsername.Text = "Nombre de usuario";
            this.rdbUsername.UseVisualStyleBackColor = true;
            this.rdbUsername.CheckedChanged += new System.EventHandler(this.rdbOrdenar_CheckedChanged);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.dgwUsuarios);
            this.Controls.Add(this.btnGuardarUsuario);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellidoyNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRolUsuario);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRolUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidoyNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.DataGridView dgwUsuarios;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbUsername;
        private System.Windows.Forms.RadioButton rdbApellido;

    }
}