using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2_PDOO
{
    internal class UI
    {
        public static Caja caja;

        public static void BuscarFactura()
        {
            int id_factura;
            do
            {
                Console.WriteLine("  Ingrese el id de la factura solicitada");
            } while (!int.TryParse(Console.ReadLine(), out id_factura));

            caja.ImprimirFactura(id_factura);
            Console.ReadKey();
        }

        public static void PintarCabezoteMenu()
        {
            //ASSI ART AQUI
        }

        public static int Menu(Caja caja)
        {
            int opc = 0;
            UI.caja = caja;
            //TODO: Personalizar el menu ascii            
            do
            {
                PintarCabezoteMenu();

                if (int.TryParse(Console.ReadLine(), out opc))
                {
                    if (opc == 1 || opc == 2 || opc == 3 || opc == 4 || opc == 5)
                    {
                        if (opc == 4)
                        {
                            BuscarFactura();
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Error al ingresar la opción");
                }
            } while (opc != -1);

            return opc;
        }
    }
}
