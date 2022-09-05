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
            int x;
            x = int.Parse(Console.ReadLine());
            if (x > 10)
            {
                Console.WriteLine("{0} é maior que 10", x);
            }
        }
    }
}
