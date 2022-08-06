using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    internal class Vendedor
    {
        private string _name, _apellido;
        private int _codigoDeVendedor;

        public string Name { get => _name; set => _name = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int CodigoDeVendedor { get => _codigoDeVendedor; set => _codigoDeVendedor = value; }

    }
}
