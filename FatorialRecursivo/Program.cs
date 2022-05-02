using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorialRecursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular o Fatorial de qual número? ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("O fatorial do " + num + " é: " + Fatorial(num));

            Console.ReadKey();
        }

        static int Fatorial (int num)
        {
            if (num <= 0)
            {
                return 1;
            }

            return num * Fatorial(num - 1);
        }
    }
}