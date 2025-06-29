using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Prestamo
    {
        private int pre_numero;
        private string cli_dni;
        private int des_codigo;
        private int per_codigo;
        private DateTime pre_fecha;
        private decimal pre_importe;
        private double pre_tasaInteres;
        private int pre_cantidadCuotas;
        private string pre_estado;

        public string Pre_estado
        {
            get { return pre_estado; }
            set { pre_estado = value; }
        }

        public int Pre_cantidadCuotas
        {
            get { return pre_cantidadCuotas; }
            set { pre_cantidadCuotas = value; }
        }

        public double Pre_tasaInteres
        {
            get { return pre_tasaInteres; }
            set { pre_tasaInteres = value; }
        }

        public decimal Pre_importe
        {
            get { return pre_importe; }
            set { pre_importe = value; }
        }

        public DateTime Pre_fecha
        {
            get { return pre_fecha; }
            set { pre_fecha = value; }
        }

        public int Per_codigo
        {
            get { return per_codigo; }
            set { per_codigo = value; }
        }

        public int Des_codigo
        {
            get { return des_codigo; }
            set { des_codigo = value; }
        }

        public int Pre_numero
        {
            get { return pre_numero; }
            set { pre_numero = value; }
        }

        public string Cli_dni
        {
            get { return cli_dni; }
            set { cli_dni = value; }
        }
    }
}
