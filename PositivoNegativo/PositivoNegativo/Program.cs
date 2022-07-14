using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositivoNegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;

            Console.WriteLine("Insira um número: ");
            num = double.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("O número " + num + " é: negativo");
            }
            else if(num == 0)
            {
                Console.WriteLine("O número " + num + " é: neutro");
            }
            else if (num > 0)
            {
                Console.WriteLine("O número " + num + " é: positivo");
            }
        }
    }
}
