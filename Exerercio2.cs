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
            int x, y;
            Console.WriteLine("Digite o primeiro numero: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Resultado: ");
            if (x > y)
            {
                Console.WriteLine("{0} é maior que {1}", x, y);
            }
            else
            {
                Console.WriteLine("{0} é maior que {1}", y, x);
            }
        }
    }
}
