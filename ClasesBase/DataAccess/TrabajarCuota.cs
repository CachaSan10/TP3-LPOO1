using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarCuota
    {

        public static void insert_cuota(Cuota cuota) {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Cuota (pre_numero, cuo_numero, cuo_vencimiento, cuo_importe, cuo_estado) values (@pre_numero, @cuo_numero, @vencimiento, @importe, @estado)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pre_numero", cuota.Pre_numero);
            cmd.Parameters.AddWithValue("@cuo_numero", cuota.Cuo_numero);
            cmd.Parameters.AddWithValue("@vencimiento", cuota.Cuo_vencimiento);
            cmd.Parameters.AddWithValue("@importe", cuota.Cuo_importe);
            cmd.Parameters.AddWithValue("@estado", cuota.Cuo_estado);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        
        }
    }
}
