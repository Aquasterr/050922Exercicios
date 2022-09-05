using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Digite o Primeiro Numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Numero: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Terceiro Numero: ");
            n3 = int.Parse(Console.ReadLine());

            // Maior numero é 1
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("O Maior numero é {0}", n1);
                if (n2 > n3) Console.WriteLine("O Menor numero é {0}", n3);
                    else Console.WriteLine("O Menor numero é {0}", n2);
            }
            // Maior numero é 2
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("O Maior numero é {0}", n2);
                if (n1 > n3) Console.WriteLine("O Menor numero é {0}", n3);
                    else Console.WriteLine("O Menor numero é {0}", n1);
            }
            // Maior numero é 3
            else if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine("O Maior numero é {0}", n3);
                if (n2 > n1) Console.WriteLine("O menor numero é {0}", n1);
                else Console.WriteLine("O Menor numero é {0}", n2);
            }
        }
    }
}
