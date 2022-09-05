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
            int n;
            Console.WriteLine("Digite o Numero");
            n = int.Parse(Console.ReadLine());
            if (n%2 == 0)
            {
                Console.WriteLine("par");
            }
            else
            {
                Console.WriteLine("impar");
            }
        }
    }
}
