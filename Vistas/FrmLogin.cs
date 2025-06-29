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
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
        }
        

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            Usuario usuarioEncontrado = TrabajarUsuario.login_usuario(txtUserName.Text, txtPassword.Text);

            if (usuarioEncontrado != null)
            {

                MessageBox.Show("Bienvenido/a: " + usuarioEncontrado.Usu_apellidoNombre);

                FrmPrincipal oFrmPrincipal = new FrmPrincipal(usuarioEncontrado);
                this.Hide();
                oFrmPrincipal.Show();
            }
            else {
                MessageBox.Show("Datos de acceso incorrectos");
            }
        }





        private void btnIngresar_MouseHover(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.LightBlue;
            btnIngresar.Font = new Font(btnIngresar.Font, FontStyle.Bold);

        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackColor = SystemColors.Control;
            btnIngresar.Font = new Font(btnIngresar.Font, FontStyle.Regular);
        }
        
    }
}
