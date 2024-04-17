using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2_PDOO
{
    internal class Inventario
    {
        private Producto[] productos;
        private int indice;

        public Inventario()
        {
            productos = new Producto[100];//TODO: Convertir en una lista

        }

        public void AgregarProducto(Producto producto)
        {

            if (indice + 1 <= productos.Length)
            {
                productos[indice++] = producto;
            }
        }

        public void AgregarProducto(string nombre, float precio, int cantidad)
        {
            AgregarProducto(new Producto(nombre, precio, cantidad));
        }

    }
}

