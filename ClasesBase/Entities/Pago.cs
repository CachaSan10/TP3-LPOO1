using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Pago
    {
        private int pag_codigo;
        private int cuo_codigo;
        private DateTime pag_fecha;
        private decimal pag_importe;

        public decimal Pag_importe
        {
            get { return pag_importe; }
            set { pag_importe = value; }
        }

        public DateTime Pag_fecha
        {
            get { return pag_fecha; }
            set { pag_fecha = value; }
        }

        public int Cuo_codigo
        {
            get { return cuo_codigo; }
            set { cuo_codigo = value; }
        }

        public int Pag_codigo
        {
            get { return pag_codigo; }
            set { pag_codigo = value; }
        }
    }
}
