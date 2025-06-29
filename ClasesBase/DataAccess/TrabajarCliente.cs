using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarCliente
    {

        public static void insert_cliente(Cliente client) {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Cliente(cli_dni, cli_nombre, cli_apellido, cli_sexo, cli_fechaNacimiento, cli_ingresos, cli_direccion, cli_telefono) values(@dni, @nombre, @apellido, @sexo, @fechaNacimiento, @ingresos, @direccion, @telefono)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;


            cmd.Parameters.AddWithValue("@dni", client.Cli_dni);
            cmd.Parameters.AddWithValue("@nombre", client.Cli_nombre);
            cmd.Parameters.AddWithValue("@apellido", client.Cli_apellido);
            cmd.Parameters.AddWithValue("@sexo", client.Cli_sexo);
            cmd.Parameters.AddWithValue("@fechaNacimiento", client.Cli_fechaNacimiento);
            cmd.Parameters.AddWithValue("@ingresos", client.Cli_ingresos);
            cmd.Parameters.AddWithValue("@direccion", client.Cli_direccion);
            cmd.Parameters.AddWithValue("@telefono", client.Cli_telefono);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }



        public static DataTable list_clientes() {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT "; 
            cmd.CommandText += " cli_dni as 'Dni Cliente', ";
            cmd.CommandText += " cli_nombre as 'Nombre', ";
            cmd.CommandText += " cli_apellido as 'Apellido', ";
            cmd.CommandText += " cli_sexo as 'Sexo', ";
            cmd.CommandText += " cli_fechaNacimiento as 'Fecha de Nacimiento', ";
            cmd.CommandText += " cli_ingresos as 'Ingresos', ";
            cmd.CommandText += " cli_direccion as 'Dirección', ";
            cmd.CommandText += " cli_telefono as 'Telefono' ";
            cmd.CommandText += "FROM Cliente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }


        public static void update_cliente(Cliente client) {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Cliente SET ";
            cmd.CommandText += "cli_nombre = @nombre, ";
            cmd.CommandText += "cli_apellido = @apellido, ";
            cmd.CommandText += "cli_sexo = @sexo, ";
            cmd.CommandText += "cli_fechaNacimiento = @fechaNacimiento, ";
            cmd.CommandText += "cli_ingresos = @ingresos, ";
            cmd.CommandText += "cli_direccion = @direccion, ";
            cmd.CommandText += "cli_telefono = @telefono";
            cmd.CommandText += " WHERE cli_dni = @dni";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", client.Cli_dni);
            cmd.Parameters.AddWithValue("@nombre", client.Cli_nombre);
            cmd.Parameters.AddWithValue("@apellido", client.Cli_apellido);
            cmd.Parameters.AddWithValue("@sexo", client.Cli_sexo);
            cmd.Parameters.AddWithValue("@fechaNacimiento", client.Cli_fechaNacimiento);
            cmd.Parameters.AddWithValue("@ingresos", client.Cli_ingresos);
            cmd.Parameters.AddWithValue("@direccion", client.Cli_direccion);
            cmd.Parameters.AddWithValue("@telefono", client.Cli_telefono);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }



        public static void delete_cliente(string dni) {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Cliente WHERE cli_dni = @dni";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dni);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();


        }


        public static DataTable search_clientes(string apellido, string nombre) {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += "cli_dni as 'Dni Cliente', ";
            cmd.CommandText += "cli_nombre as 'Nombre', ";
            cmd.CommandText += "cli_apellido as 'Apellido', ";
            cmd.CommandText += "cli_sexo as 'Sexo', ";
            cmd.CommandText += "cli_fechaNacimiento as 'Fecha de Nacimiento', ";
            cmd.CommandText += "cli_ingresos as 'Ingresos', ";
            cmd.CommandText += "cli_direccion as 'Dirección', ";
            cmd.CommandText += "cli_telefono as 'Telefono'";
            cmd.CommandText += " FROM Cliente";
            cmd.CommandText += " WHERE cli_apellido LIKE @apellido AND cli_nombre LIKE @nombre";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@apellido", "%" + apellido + "%");
            cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        
        }

        //Método que trabaja con vista
        public static DataTable list_clientes_ordenados()
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM vw_ClientesOrdenadosPorApellido ORDER BY cli_apellido, cli_nombre";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;


        }
    }
}
