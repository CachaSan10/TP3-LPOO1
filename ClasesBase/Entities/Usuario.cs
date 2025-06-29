using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int usu_id;
        private string usu_nombreUsuario;
        private string usu_contrasenia;
        private string usu_apellidoNombre;
        private string rol_codigo;

        public string Rol_codigo
        {
            get { return rol_codigo; }
            set { rol_codigo = value; }
        }
        
        public string Usu_apellidoNombre
        {
            get { return usu_apellidoNombre; }
            set { usu_apellidoNombre = value; }
        }

        public string Usu_contrasenia
        {
            get { return usu_contrasenia; }
            set { usu_contrasenia = value; }
        }

        public string Usu_nombreUsuario
        {
            get { return usu_nombreUsuario; }
            set { usu_nombreUsuario = value; }
        }

        public int Usu_id
        {
            get { return usu_id; }
            set { usu_id = value; }
        }

        public Usuario(int id, string username, string password, string apellidoNombre, string rol) {
            Usu_id = id;
            Usu_nombreUsuario = username;
            Usu_contrasenia = password;
            Usu_apellidoNombre = apellidoNombre;
            Rol_codigo = rol;
        }

        public Usuario(string username, string password) {
            Usu_nombreUsuario = username;
            Usu_contrasenia = password;
        }

        public Usuario() { }
    }
}
