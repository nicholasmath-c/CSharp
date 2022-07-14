using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            char operacao = 'a';
            double resultado = 0;
            bool cont = true;
            bool operacaoValida = false;
            char digito;

            while (cont)
            {
                while (!operacaoValida)
                {
                    Console.WriteLine("Insira o 1º valor: ");
                    n1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Insira a operação (+, -, *, /): ");
                    operacao = char.Parse(Console.ReadLine());

                    Console.WriteLine("Insira o 2º valor: ");
                    n2 = double.Parse(Console.ReadLine());

                    switch (operacao)
                    {
                        case '+':
                            {
                                resultado = n1 + n2;
                                Console.WriteLine("Resultado: " + resultado);
                                Console.WriteLine("Deseja parar de calcular? (s / n)");
                                digito = char.Parse(Console.ReadLine());
                                cont = digito == 's' ? false : true;
                            }
                            break;
                        case '-':
                            
                                resultado = n1 - n2;
                                Console.WriteLine("Resultado: " + resultado);
                                Console.WriteLine("Deseja parar de calcular? (s / n)");
                                digito = char.Parse(Console.ReadLine());
                                cont = digito == 's' ? false : true;
                            
                            break;
                        case '*':
                            {
                                resultado = n1 * n2;
                                Console.WriteLine("Resultado: " + resultado);
                                Console.WriteLine("Deseja parar de calcular? (s / n)");
                                digito = char.Parse(Console.ReadLine());
                                cont = digito == 's' ? false : true;
                            }
                            break;
                        case '/':
                            {
                                resultado = n1 / n2;
                                Console.WriteLine("Resultado: " + resultado);
                                Console.WriteLine("Deseja parar de calcular? (s / n)");
                                digito = char.Parse(Console.ReadLine());
                                cont = digito == 's' ? false : true;
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Insira uma operação válida.");
                                operacaoValida = false;
                            }
                            break;
                    }
                }
            }
        }
    }
}


