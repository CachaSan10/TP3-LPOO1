using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
   public class TrabajarUsuario
    {
        public static DataTable list_roles() {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM rol";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        public static void insert_usuario(Usuario user)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(usu_nombreUsuario, usu_contrasenia, usu_apellidoNombre, rol_codigo) values(@usuario, @passwd, @ayn, @rol)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@rol", user.Rol_codigo);
            cmd.Parameters.AddWithValue("@ayn", user.Usu_apellidoNombre);
            cmd.Parameters.AddWithValue("@usuario", user.Usu_nombreUsuario);
            cmd.Parameters.AddWithValue("@passwd", user.Usu_contrasenia);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable list_usuarios() {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " R.rol_descripcion as 'Rol', ";
            cmd.CommandText += " U.usu_apellidoNombre, ";
            cmd.CommandText += " U.usu_nombreUsuario, ";
            cmd.CommandText += " U.usu_id, ";
            cmd.CommandText += " U.rol_codigo, ";
            cmd.CommandText += " U.usu_contrasenia";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Rol as R ON (R.rol_codigo = U.rol_codigo)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;


            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
            
        }

        public static DataTable search_usuarios(string sPattern) {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " U.usu_id, ";
            cmd.CommandText += "U.rol_codigo, ";
            cmd.CommandText += " R.rol_descripcion as 'Rol', ";
            cmd.CommandText += " U.usu_apellidoNombre as 'Apellido y Nombre', ";
            cmd.CommandText += " U.usu_nombreUsuario as 'Usuario', ";
            cmd.CommandText += " U.usu_contrasenia as 'Contraseña' ";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Rol as R ON (R.rol_codigo = U.rol_codigo)";

            cmd.CommandText += " WHERE";
            cmd.CommandText += " U.usu_apellidoNombre LIKE @pattern ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }



        public static void update_usuario(Usuario user){

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Usuario SET ";
            cmd.CommandText += "usu_nombreUsuario = @usuario, ";
            cmd.CommandText += "usu_contrasenia = @passwd, ";
            cmd.CommandText += "usu_apellidoNombre = @ayn, ";
            cmd.CommandText += "rol_codigo = @rol  ";
            cmd.CommandText += "WHERE usu_id = @id";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@usuario", user.Usu_nombreUsuario);
            cmd.Parameters.AddWithValue("@passwd", user.Usu_contrasenia);
            cmd.Parameters.AddWithValue("@ayn", user.Usu_apellidoNombre);
            cmd.Parameters.AddWithValue("@rol", user.Rol_codigo);
            cmd.Parameters.AddWithValue("@id", user.Usu_id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }


        public static void delete_usuario(int id) {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Usuario WHERE usu_id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }



        public static Usuario login_usuario(string nombreUsuario, string contrasenia) {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario WHERE usu_nombreUsuario = @usuario AND usu_contrasenia = @passwd";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@usuario", nombreUsuario);
            cmd.Parameters.AddWithValue("@passwd", contrasenia);

            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Usuario user = null;

            if (reader.Read()) {

                user = new Usuario();
                user.Usu_id = Convert.ToInt32(reader["usu_id"]);
                user.Usu_nombreUsuario = reader["usu_nombreUsuario"].ToString();
                user.Usu_contrasenia = reader["usu_contrasenia"].ToString();
                user.Usu_apellidoNombre = reader["usu_apellidoNombre"].ToString();
                user.Rol_codigo = reader["rol_codigo"].ToString();
            }

            reader.Close();
            cnn.Close();

            return user;
        }

        //Método que trabaja con vista
        public static DataTable exec_ordenar_usuarios_vw(string criterioOrden)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM  vw_UsuariosOrdenadosPorUsernameOApellido";
            if (criterioOrden == "apellido")
                cmd.CommandText += " ORDER BY usu_apellidoNombre";
            else if (criterioOrden == "username")
                cmd.CommandText += " ORDER BY usu_nombreUsuario";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static int contarAdministradores()
        {
            int cantidad = 0;
            SqlConnection miConexion = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Usuario WHERE rol_codigo = 'ADM'";
            cmd.Connection = miConexion;
            miConexion.Open();
            cantidad = (int)cmd.ExecuteScalar();
            miConexion.Close();
            return cantidad;
        }

    }

    

}
