using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarPrestamo
    {
        public static DataTable list_clientes() {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += "cli_dni, ";
            cmd.CommandText += "cli_nombre + ' ' + cli_apellido as NombreCompleto ";
            cmd.CommandText += " FROM Cliente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        public static DataTable list_destinos() {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Destino";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        
        }


        public static DataTable list_periodos() {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Periodo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        
        }


        public static int insert_prestamo(Prestamo prestamo) {

            int prestamoNumero = 0;

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Prestamo(cli_dni, des_codigo, per_codigo, pre_fecha, pre_importe, pre_tasaInteres, pre_cantidadCuotas, pre_estado) values(@cli_dni, @des_codigo, @per_codigo, @fecha, @importe, @tasaInteres, @cantidadCuotas, @estado) SELECT SCOPE_IDENTITY();";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@cli_dni", prestamo.Cli_dni);
            cmd.Parameters.AddWithValue("@des_codigo", prestamo.Des_codigo);
            cmd.Parameters.AddWithValue("@per_codigo", prestamo.Per_codigo);
            cmd.Parameters.AddWithValue("@fecha", prestamo.Pre_fecha);
            cmd.Parameters.AddWithValue("@importe", prestamo.Pre_importe);
            cmd.Parameters.AddWithValue("@tasaInteres", prestamo.Pre_tasaInteres);
            cmd.Parameters.AddWithValue("@cantidadCuotas", prestamo.Pre_cantidadCuotas);
            cmd.Parameters.AddWithValue("@estado", prestamo.Pre_estado);

            cnn.Open();
            prestamoNumero = Convert.ToInt32(cmd.ExecuteScalar());
            cnn.Close();

            return prestamoNumero;
        }


        public static void generarCuotas(Prestamo prestamo, int numeroPrestamo) {

            decimal tasaDecimal = (decimal)prestamo.Pre_tasaInteres;
            decimal totalPrestamo = (prestamo.Pre_importe * tasaDecimal / 100) + prestamo.Pre_importe;
            decimal importeCuotas = Math.Round(totalPrestamo / prestamo.Pre_cantidadCuotas, 2);

            string descripcionPeriodo = TrabajarPeriodo.get_descripcion_periodo(prestamo.Per_codigo);

            for (int i = 1; i <= prestamo.Pre_cantidadCuotas; i++) {

                Cuota oCuota = new Cuota();
                oCuota.Pre_numero = numeroPrestamo;
                oCuota.Cuo_numero = i;
                oCuota.Cuo_importe = importeCuotas;
                oCuota.Cuo_estado = "PENDIENTE";

                if (descripcionPeriodo == "Semanal") {
                    oCuota.Cuo_vencimiento = prestamo.Pre_fecha.AddDays(7 * i);
                }
                else if (descripcionPeriodo == "Mensual") {
                    oCuota.Cuo_vencimiento = prestamo.Pre_fecha.AddMonths(i);
                }
                else if (descripcionPeriodo == "Anual") {
                    oCuota.Cuo_vencimiento = prestamo.Pre_fecha.AddYears(i);
                }

                TrabajarCuota.insert_cuota(oCuota);
            }

        
        }

        public static DataTable list_prestamos() {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT " +
                "P.pre_numero AS 'N° de Préstamo', " +
                "C.cli_apellido + ', ' + C.cli_nombre AS 'Cliente', " +
                "D.des_descripcion AS 'Destino', " +
                "R.per_descripcion AS 'Periodo', " +
                "P.pre_fecha AS 'Fecha', " +
                "P.pre_importe AS 'Importe', " +
                "P.pre_tasaInteres AS 'Tasa %', " +
                "P.pre_cantidadCuotas AS 'Cuotas', " +
                "P.pre_estado AS 'Estado' " +
                "FROM Prestamo P " +
                "INNER JOIN Cliente C ON P.cli_dni = C.cli_dni " +
                "INNER JOIN Destino D ON P.des_codigo = D.des_codigo " +
                "INNER JOIN Periodo R ON P.per_codigo = R.per_codigo";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;


            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        
        }

        //Método que trabaja con vista
        public static DataTable exec_listar_prestamos_vw(string filtro)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);
            SqlCommand cmd = new SqlCommand();

            if (string.IsNullOrEmpty(filtro) || filtro == "Todos")
            {
                cmd.CommandText = "SELECT * FROM vw_Prestamos";
            }
            else
            {
                //pre estado
                cmd.CommandText = "SELECT * FROM vw_Prestamos WHERE [Destino del prestamo] = @filtro";
                cmd.Parameters.AddWithValue("@filtro", filtro);
            }
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable exec_listar_prestamos_por_fechas_vw(DateTime fechaDesde, DateTime fechaHasta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.prestamoConnectionString1);
            SqlCommand cmd = new SqlCommand();

            fechaHasta = fechaHasta.Date.AddDays(1).AddTicks(-1);

            cmd.CommandText = "SELECT * FROM vw_Prestamos WHERE Fecha >= @fechaDesde AND Fecha <= @fechaHasta";
          

            cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
            cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

    }
}
