using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    internal class Tienda
    {
        private string _nombre, _direccion;
        private List<Prenda> _prendas;

        public string Nombre { get => _nombre; }
        public string Direccion { get => _direccion; }

        public Tienda()
        {
            _prendas = new List<Prenda>();
        }
    }
}
