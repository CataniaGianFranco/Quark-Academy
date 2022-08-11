using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    internal abstract class Prenda
    {
        private enum Calidad { standard, premium}
        private int _precioUnitario, _cantidad = 0;

        public int PrecioUnitario { get => _precioUnitario; set => _precioUnitario = value; }
        public int Cantidad {  get => _cantidad; set => _cantidad = value; }

    }
}
