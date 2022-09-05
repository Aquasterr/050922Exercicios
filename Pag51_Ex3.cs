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
            int numero, resultado;
            Console.WriteLine("Digite o Numero");
            numero = int.Parse(Console.ReadLine());
            resultado = numero % 7;

            if (resultado == 0)
            {
                Console.WriteLine("{0} é multiplo de 7", numero);
            }
            else
            {
                Console.WriteLine("{0} Não é multiplo de 7", numero);
            }

        }
    }
}
