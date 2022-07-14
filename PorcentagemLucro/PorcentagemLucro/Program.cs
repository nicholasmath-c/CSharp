using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorcentagemLucro
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            double porcentagem;
            double valorFinal;

            Console.WriteLine("Insira o preço de custo: ");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora insira a porcentagem de lucro que deseja: ");
            porcentagem = double.Parse(Console.ReadLine());

            valorFinal = valor * (porcentagem / 100 + 1);

            Console.WriteLine("O valor final somado ao lucro desejado é de: R$" + valorFinal);
        }
    }
}
