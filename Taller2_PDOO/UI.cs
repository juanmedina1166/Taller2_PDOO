using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2_PDOO
{
    internal class UI
    {
        internal class MenuPrograma
        {
            public void ImprimirLogo()
            {
            }

            public void ImprimirTitulo()
            {
            }
            public void ImprimirMenu()
            {
                ImprimirTitulo();
                ImprimirLinea(5, "_");
                ImprimirColumna(10);
                ImprimirLinea(5, "_");
            }
            public void ImprimirLinea(int ancho, string caracter)
            {
                string temp = "";
                for (int i = 0; i < ancho; i++)
                {
                    //Console.Write("texto"); Imprime en la misma linea
                    //Console.Writeline("Texto"); Imprime y salta de linea
                    temp += caracter;
                }
                Console.WriteLine(temp);
            }
            public void ImprimirColumna(int alto)
            {
                string temp = "";
                string caracter = "|";
                string salto = "\n"; //Secuencua de escape
                for (int i = 0; i < alto; i++)
                {
                    temp += caracter;
                    if (i + 1 < alto)
                    {
                        temp = temp + salto;
                    }
                }
                Console.WriteLine(temp);
            }
        }
    }
}
