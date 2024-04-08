using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2_PDOO
{
    internal class Factura
    {
        private string fecha;
        private string estado_actual;
        private string medio_pago;
        private float iva;
        private float total;
        private Producto[] canasta;
        private int indice;
        private int numero_factura;

        public Factura()
        {

        }

        public Factura(int cantidad_productos)
        {
            canasta = new Producto[cantidad_productos];
        }

        public Factura(string fecha, string estado_actual, string medio_pago, float iva, float total)
        {
            this.fecha = fecha;
            this.estado_actual = estado_actual;
            this.medio_pago = medio_pago;
            this.iva = iva;
            this.total = total;

        }

        public void MostrarProducto(int indice)
        {
            int cantidiad = canasta[indice].Cantidad;
            Console.Write(Utilitario.FormatearDigito(cantidad.ToString()));
            Utilitario
        Console.Write(Utilitario);
            Utilitario.ImprimirEspacios(1);
            Console.WriteLine(Utilitario.ImprimirEspaciosInicio(canasta[indice].Pro))
        Utilitario.ImprimirEspacios(1);
            Console.WriteLine(utilitario.ImprimirEspaciosInicio((canasta[indice]))

        }
    }
}
