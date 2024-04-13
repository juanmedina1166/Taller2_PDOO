namespace Taller2_PDOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caja caja = new Caja();
            LectorArchivo temp = new LectorArchivo();
            caja.Facturas = temp.cargarFacturas();
            //caja.ImprimirFactura(7);¨
            UI.Menu(caja);
            Console.ReadKey();
        }
    }
}
