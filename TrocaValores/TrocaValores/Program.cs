using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;

            Console.WriteLine("Insira o valor A: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor B: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("\nNa ordem padrão (A -> B) fica: " + a + " -> " + b);
            Console.WriteLine("\nJá na ordem trocada (B -> A) fica: " + b + " -> " + a);
        }
    }
}
