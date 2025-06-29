using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Destino
    {
        private int des_codigo;
        private string des_descripcion;

        public string Des_descripcion
        {
            get { return des_descripcion; }
            set { des_descripcion = value; }
        }

        public int Des_codigo
        {
            get { return des_codigo; }
            set { des_codigo = value; }
        }

        public Destino(int codigo, string descripcion) {
            Des_codigo = codigo;
            Des_descripcion = descripcion;
        }

        public Destino() { }
    }
}
