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
    public partial class FrmUsuario : Form
    {
        private bool activarCambio = false; // esto es para manejar que el form no venga con datos precargados

        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
             DialogResult result = MessageBox.Show("¿Está seguro que desea guardar este usuario?", "Confirmación", MessageBoxButtons.YesNo);

             if (result == DialogResult.Yes)
             {

                 Usuario oUser = new Usuario();

                 oUser.Rol_codigo = (string)cmbRolUsuario.SelectedValue;
                 oUser.Usu_apellidoNombre = txtApellidoyNombre.Text;
                 oUser.Usu_nombreUsuario = txtUsuario.Text;
                 oUser.Usu_contrasenia = txtContrasenia.Text;

                 TrabajarUsuario.insert_usuario(oUser);

                 load_usuarios();
             
             }

             limpiarCampos();
            

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            activarCambio = false; 

            load_combo_rol();

            load_usuarios();

            activarCambio = true;
        }

        private void load_combo_rol()
        {
            cmbRolUsuario.DisplayMember = "rol_descripcion";
            cmbRolUsuario.ValueMember = "rol_codigo";
            cmbRolUsuario.DataSource = TrabajarUsuario.list_roles();

        }

        private void load_usuarios() {

            dgwUsuarios.DataSource = TrabajarUsuario.list_usuarios();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtPattern.Text != "")
            {
                dgwUsuarios.DataSource = TrabajarUsuario.search_usuarios(txtPattern.Text);
            }
            else {
                load_usuarios();
            }
        }


        private void dgwUsuarios_CurrentCellChanged(object sender, EventArgs e) {

            if (!activarCambio) return;

            if (dgwUsuarios.CurrentRow != null) {


                cmbRolUsuario.SelectedValue = dgwUsuarios.CurrentRow.Cells["rol_codigo"].Value.ToString();

                txtApellidoyNombre.Text = dgwUsuarios.CurrentRow.Cells["usu_apellidoNombre"].Value.ToString();
                txtUsuario.Text = dgwUsuarios.CurrentRow.Cells["usu_nombreUsuario"].Value.ToString();
                txtContrasenia.Text = dgwUsuarios.CurrentRow.Cells["usu_contrasenia"].Value.ToString();
                txtID.Text = dgwUsuarios.CurrentRow.Cells["usu_id"].Value.ToString();
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {

                 DialogResult result = MessageBox.Show("¿Está seguro que desea modificar este usuario?", "Confirmación", MessageBoxButtons.YesNo);

                 if (result == DialogResult.Yes)
                 {
                     Usuario oUser = new Usuario();

                     oUser.Usu_id = int.Parse(txtID.Text);
                     oUser.Rol_codigo = (string)cmbRolUsuario.SelectedValue;
                     oUser.Usu_apellidoNombre = txtApellidoyNombre.Text;
                     oUser.Usu_nombreUsuario = txtUsuario.Text;
                     oUser.Usu_contrasenia = txtContrasenia.Text;

                     TrabajarUsuario.update_usuario(oUser);

                     load_usuarios();

                     limpiarCampos();

                     MessageBox.Show("Usuario actualizado correctamente.");
                 }
                
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario primero");
            }
        }




        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {

                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar este usuario?", "Confirmación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    if (TrabajarUsuario.contarAdministradores() > 1)
                    {
                        int id = int.Parse(txtID.Text);
                        TrabajarUsuario.delete_usuario(id);

                        load_usuarios();
                        limpiarCampos();
                        MessageBox.Show("Usuario eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No podemos eliminar el usuario, solo se cuenta con un administrador ");
                    }

                    
                }
            }
            else {
                MessageBox.Show("Debe seleccionar un usuario para eliminar.");
            }
        }

        private void limpiarCampos() {

            txtID.Clear();
            txtApellidoyNombre.Clear();
            txtUsuario.Clear();
            txtContrasenia.Clear();
            cmbRolUsuario.SelectedIndex = -1;

        }

        private void rdbOrdenar_CheckedChanged(object sender, EventArgs e)
        {
            string criterio = "";

            if (rdbApellido.Checked)
                criterio = "apellido";
            else if (rdbUsername.Checked)
                criterio = "username";

            dgwUsuarios.DataSource = TrabajarUsuario.exec_ordenar_usuarios_vw(criterio);

        }

    }
}
