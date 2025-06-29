using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarPago
    {
        public static DataTable exec_list_clientes_sp()
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "list_clientes_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable exec_list_pago_vw(string dni)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM vw_listar_pagos WHERE DNI = @dni";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni",dni);

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable exec_list_prestamo_sp(string dni)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "list_prestamos_pendientes_por_cliente_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dni);

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        public static DataTable exec_list_cuotas_pendientes_sp(int pre_numero)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "list_cuotas_pendientes_por_prestamo_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pre_numero", pre_numero);

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        public static void exec_insert_pago_sp(Pago pago)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert_pago_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@cuo_codigo", pago.Cuo_codigo);
            cmd.Parameters.AddWithValue("@pag_fecha", pago.Pag_fecha);
            cmd.Parameters.AddWithValue("@pag_importe", pago.Pag_importe);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void exec_update_estado_cuota_sp(int cuo_codigo)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update_estado_cuota_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@cuo_codigo", cuo_codigo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        public static void exec_update_estado_prestamo_sp(int pre_numero)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update_estado_prestamo_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pre_numero", pre_numero);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        public static int exec_cantidad_cuotas_pendientes_sp(int pre_numero)
        {

            int cantidadPendiente = 0;

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "cantidad_cuotas_pendientes_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pre_numero", pre_numero);

            cnn.Open();
            cantidadPendiente = Convert.ToInt32(cmd.ExecuteScalar());
            cnn.Close();


            return cantidadPendiente;

        }


        public static bool registrarPago(Pago pago, int pre_numero)
        {

            TrabajarPago.exec_insert_pago_sp(pago);
            TrabajarPago.exec_update_estado_cuota_sp(pago.Cuo_codigo);

            int cantidadCuotasPendientes = TrabajarPago.exec_cantidad_cuotas_pendientes_sp(pre_numero);

            if (cantidadCuotasPendientes == 0)
            {
                TrabajarPago.exec_update_estado_prestamo_sp(pre_numero);
                return true;
            }

            return false;
        }

    }
}
