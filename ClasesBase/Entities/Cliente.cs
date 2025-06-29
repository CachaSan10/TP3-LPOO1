using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cliente
    {
        private string cli_dni;
        private string cli_nombre;
        private string cli_apellido;
        private string cli_sexo;
        private DateTime cli_fechaNacimiento;
        private decimal cli_ingresos;
        private string cli_direccion;
        private string cli_telefono;

        public DateTime Cli_fechaNacimiento
        {
            get { return cli_fechaNacimiento; }
            set { cli_fechaNacimiento = value; }
        }
        

        public string Cli_telefono
        {
            get { return cli_telefono; }
            set { cli_telefono = value; }
        }

        public string Cli_direccion
        {
            get { return cli_direccion; }
            set { cli_direccion = value; }
        }

        public decimal Cli_ingresos
        {
            get { return cli_ingresos; }
            set { cli_ingresos = value; }
        }

        public string Cli_sexo
        {
            get { return cli_sexo; }
            set { cli_sexo = value; }
        }

        public string Cli_apellido
        {
            get { return cli_apellido; }
            set { cli_apellido = value; }
        }

        public string Cli_nombre
        {
            get { return cli_nombre; }
            set { cli_nombre = value; }
        }

        public string Cli_dni
        {
            get { return cli_dni; }
            set { cli_dni = value; }
        }

        public Cliente(string dni, string nombre, string apellido, string sexo, DateTime fechaNacimiento, decimal ingresos, string direccion, string telefono) {
            Cli_dni = dni;
            Cli_nombre = nombre;
            Cli_apellido = apellido;
            Cli_sexo = sexo;
            Cli_fechaNacimiento = fechaNacimiento;
            Cli_ingresos = ingresos;
            Cli_direccion = direccion;
            Cli_telefono = telefono;
        }

        public Cliente() { }
    }
}
