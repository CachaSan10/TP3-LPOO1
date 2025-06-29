using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarDestino
    {

        //*** METODOS QUE TRABAJAN CON STORED PROCEDURES TP3 ***
        public static void exec_insert_destino_sp(Destino destino)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);
            SqlCommand cmd = new SqlCommand();


            // Validación: Verificar si el destino ya existe (en minúsculas)
            cmd.CommandText = "SELECT COUNT(*) FROM Destino WHERE LOWER(des_descripcion) = @descripcion";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@descripcion", destino.Des_descripcion.ToLower());

            cnn.Open();
            int count = (int)cmd.ExecuteScalar();
            cnn.Close();

            if (count > 0)
            {
                throw new Exception("El destino ya existe en la base de datos (se considera en minúsculas).");
            }



            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cm = new SqlCommand("insertar_destino_sp", cn);
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@descripcion", destino.Des_descripcion);

            cn.Open();
            cm.ExecuteNonQuery();
            cn.Close();
        }

        public static DataTable exec_list_destinos_sp()
        {

            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand("listar_destinos_sp", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }


        public static void exec_update_destino_sp(Destino destino)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);
            SqlCommand cmd = new SqlCommand();


            // Validación: Verificar si el destino ya existe (en minúsculas)
            cmd.CommandText = "SELECT COUNT(*) FROM Destino WHERE LOWER(des_descripcion) = @descripcion";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@descripcion", destino.Des_descripcion.ToLower());

            cnn.Open();
            int count = (int)cmd.ExecuteScalar();
            cnn.Close();

            if (count > 0)
            {
                throw new Exception("El destino ya existe en la base de datos");
            }






            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cm = new SqlCommand("modificar_destino_sp", cn);

            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.AddWithValue("@codigo", destino.Des_codigo);
            cm.Parameters.AddWithValue("@descripcion", destino.Des_descripcion);

            cn.Open();
            cm.ExecuteNonQuery();
            cn.Close();

        }


        public static void exec_delete_destino_sp(int codigo)
        {

            SqlConnection cn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand("eliminar_destino_sp", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@codigo", codigo);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }
        // *** METODOS CON CONSULTAS DIRECTAS TP2 ***

        public static void insert_destino(Destino destino) {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Destino(des_descripcion) values(@descripcion)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@descripcion", destino.Des_descripcion);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable list_destinos() {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " des_codigo as 'Codigo', ";
            cmd.CommandText += " des_descripcion as 'Descripcion' ";
            cmd.CommandText += " FROM Destino";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

             //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }


        public static void update_destino(Destino destino) {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Destino SET ";
            cmd.CommandText += "des_descripcion = @descripcion ";
            cmd.CommandText += "WHERE des_codigo = @codigo";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@codigo", destino.Des_codigo);
            cmd.Parameters.AddWithValue("@descripcion", destino.Des_descripcion);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }


        public static void delete_destino(int codigo) {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Destino WHERE des_codigo = @codigo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@codigo", codigo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        
        }

    }
}
