using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cuota
    {
        private int cuo_codigo;
        private int pre_numero;
        private int cuo_numero;
        private DateTime cuo_vencimiento;
        private decimal cuo_importe;
        private string cuo_estado;

        public string Cuo_estado
        {
            get { return cuo_estado; }
            set { cuo_estado = value; }
        }

        public decimal Cuo_importe
        {
            get { return cuo_importe; }
            set { cuo_importe = value; }
        }

        public DateTime Cuo_vencimiento
        {
            get { return cuo_vencimiento; }
            set { cuo_vencimiento = value; }
        }

        public int Cuo_numero
        {
            get { return cuo_numero; }
            set { cuo_numero = value; }
        }

        public int Pre_numero
        {
            get { return pre_numero; }
            set { pre_numero = value; }
        }

        public int Cuo_codigo
        {
            get { return cuo_codigo; }
            set { cuo_codigo = value; }
        }
    }
}
