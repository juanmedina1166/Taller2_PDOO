using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2_PDOO
{
    internal class Venta
    {
        public static void RealizarVenta(Producto[] productos)
        {
            float total = 0;
            foreach (var producto in productos)
            {
                total += producto.Precio;
            }
            Console.WriteLine($"Total a pagar: {total}");
            Console.WriteLine("Desea añadir otro producto? (s/n)");
            string respuesta = Console.ReadLine();
            if (respuesta == "s")
            {
                RealizarVenta(productos);
            }
            else
            {
                Console.WriteLine("Venta realizada");
            }

        }

    }

}
