using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaSe
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Desenvolver um software que receba um número inteiro e retorne se essa idade é maior ou menor de idade*/

            int verificar;
            bool continuar = true;
            
            while(continuar)
            {
                int idade;

                Console.WriteLine("Insira sua idade:");
                idade = int.Parse(Console.ReadLine());

                if(idade < 18)
                {
                    Console.WriteLine("Você é menor de idade, com apenas: " + idade + " anos.");
                }
                else
                {
                    Console.WriteLine("Tudo certo! Você é maior de idade.");
                }

                Console.WriteLine("Deseja continuar verificando a idade? (1 = sim/ 2 = não)");
                verificar = int.Parse(Console.ReadLine());

                //Condição para repetição do código
                if(verificar == 1) continuar = true;  else continuar = false;
            }
        }
    }
}
