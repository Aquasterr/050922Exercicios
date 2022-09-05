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
            int n1, n2;
            Console.WriteLine("Digite o Primeiro Numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Numero: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 == n2)
            {
                Console.WriteLine("Os numeros são iguais ");
            }
            else
            {
                if (n1 > n2)
                {
                    Console.WriteLine("{0} é maior que {1}", n1, n2);
                }
                else
                {
                    Console.WriteLine("{0} é maior que {1}", n2, n1);
                }
            }
        }
    }
}
