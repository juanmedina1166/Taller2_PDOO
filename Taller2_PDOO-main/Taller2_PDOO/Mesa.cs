using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2_PDOO
{
    internal class Mesa
    {
        private int numero;
        private bool estado;

        public int Numero { get => numero; set => numero = value; }
        public bool Estado { get => estado; set => estado = value; }
        public Mesa() { }

        public Mesa(int numero) {  this.numero = numero; }  

        public static void TomarPedido(Producto[] productos) { }
        public static void GenerarFactura() { }

    }
}
