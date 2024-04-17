using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2_PDOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caja caja = new Caja();
            LectorArchivo temp = new LectorArchivo();
            caja.Facturas = temp.cargarFacturas();
            //caja.ImprimirFactura(7);
            //temp.GuardarFacturas(temp.FormatearLineasFacturas(caja.Facturas));
            UI.Menu(caja);
            Console.ReadKey();
        }
    }
}
