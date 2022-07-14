using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int soma = 0;

            for (int i = 0; i < 20; i++)
            {
                if ((num%2) != 0)
                {
                    soma += num;
                    Console.Write(soma + " ");
                }
                num++;
            }

            Console.ReadKey();
        }
    }
}
