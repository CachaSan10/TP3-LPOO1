using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Periodo
    {
        private int per_codigo;
        private string per_descripcion;

        public string Per_descripcion
        {
            get { return per_descripcion; }
            set { per_descripcion = value; }
        }

        public int Per_codigo
        {
            get { return per_codigo; }
            set { per_codigo = value; }
        }

        public Periodo (int codigo, string descripcion){
            Per_codigo = codigo;
            Per_descripcion = descripcion;
        }

        public Periodo() { }
    }
}
