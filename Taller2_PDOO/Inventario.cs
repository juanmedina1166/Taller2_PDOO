using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2_PDOO
{
    internal class Inventario
    {
        private Dictionary<string, int> inventario;

        public Inventario()
        {
            inventario = new Dictionary<string, int>();
        }

        
        public void AgregarProducto(string nombre, int cantidad)
        {
            if (inventario.ContainsKey(nombre))
            {
               
                inventario[nombre] += cantidad;
            }
            else
            {
                
                inventario.Add(nombre, cantidad);
            }
        }

        
        public void ImprimirInventario()
        {
            Console.WriteLine("Inventario:");
            Console.WriteLine("Nombre\t\tCantidad");
            Console.WriteLine("---------------------");
            foreach (var item in inventario)
            {
                Console.WriteLine($"{item.Key}\t\t{item.Value}");
            }
        }
    }
}
