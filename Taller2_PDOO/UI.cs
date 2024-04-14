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
            Console.WriteLine("   _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
            Console.WriteLine("  |                                                                                        |");
            Console.WriteLine("  |        __   ____  _      ____   __  __ __    ___                                       |");
            Console.WriteLine("  |       /  ] /    || |    |    | /  ]|  |  |  /  _]                                      |");
            Console.WriteLine("  |      /  / |  o  || |     |  | /  / |  |  | /  [_                                       |");
            Console.WriteLine("  |     /  /  |     || |___  |  |/  /  |  _  ||    _]                                      |");
            Console.WriteLine("  |    /   \\_ |  _  ||     | |  /   \\_ |  |  ||   [_                                       |");
            Console.WriteLine("  |    \\     ||  |  ||     | |  \\     ||  |  ||     |                                      |");
            Console.WriteLine("  |     \\____||__|__||_____||____\\____||__|__||_____|                                      |");
            Console.WriteLine("  |                                                                                        |");
            Console.WriteLine("  |     ____     ___  _____ ______   ____  __ __  ____    ____  ____   ______    ___       |");
            Console.WriteLine("  |    |    \\   /  _]/ ___/|      | /    ||  |  ||    \\  /    ||    \\ |      |  /  _]      |");
            Console.WriteLine("  |    |  D  ) /  [_(   \\_ |      ||  o  ||  |  ||  D  )|  o  ||  _  ||      | /  [_       |");
            Console.WriteLine("  |    |    / |    _]\\__  ||_|  |_||     ||  |  ||    / |     ||  |  ||_|  |_||    _]      |");
            Console.WriteLine("  |    |    \\ |   [_ /  \\ |  |  |  |  _  ||  :  ||    \\ |  _  ||  |  |  |  |  |   [_       |");
            Console.WriteLine("  |    |  .  \\|     |\\    |  |  |  |  |  ||     ||  .  \\|  |  ||  |  |  |  |  |     |      |");
            Console.WriteLine("  |    |__|\\_||_____| \\___|  |__|  |__|__| \\__,_||__|\\_||__|__||__|__|  |__|  |_____|      |");
            Console.WriteLine("  |                                                                                        |");
            Console.WriteLine("  |     ____    ____  ____                                                                 |");
            Console.WriteLine("  |    |    \\  /    ||    \\                                                                |");
            Console.WriteLine("  |    |  o  )|  o  ||  D  )                                                               |");
            Console.WriteLine("  |    |     ||     ||    /                                                                 |");
            Console.WriteLine("  |    |  O  ||  _  ||    \\                                                                |");
            Console.WriteLine("  |    |     ||  |  ||  .  \\                                                               |");
            Console.WriteLine("  |    |_____||__|__||__|\\_ |                                                              |");
            Console.WriteLine("  |                                                                                        |");
            Console.WriteLine("  |                          Ingrese una opción así:                                       |");
            Console.WriteLine("  |                           1. Realizar venta                                            |");
            Console.WriteLine("  |                           2. Operaciones con productos                                 |");
            Console.WriteLine("  |                           3. Imprimir inventario                                       |");
            Console.WriteLine("  |                           4. Buscar Factura                                            |");
            Console.WriteLine("  |                           5. Exportar factura                                          |");
            Console.WriteLine("  |                          -1. Salir                                                     |");
            Console.WriteLine("   ````````````````````````````````````````````````````````````````````````````````````````");
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
