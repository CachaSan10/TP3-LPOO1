using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarPeriodo
    {

        public static string get_descripcion_periodo(int codigo) {

            string descripcion = "";

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT per_descripcion FROM Periodo WHERE per_codigo = @codigo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;


            cmd.Parameters.AddWithValue("@codigo", codigo);

            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read()) {

                descripcion = reader["per_descripcion"].ToString();
            }

            reader.Close();
            cnn.Close();

            return descripcion;
        
        }


        public static void insert_periodo(Periodo periodo) {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Periodo(per_descripcion) values(@descripcion)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@descripcion", periodo.Per_descripcion);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        
        }
    }
}
