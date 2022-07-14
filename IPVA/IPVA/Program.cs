using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPVA
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int vehicle = 0;
            double ipva = 0;
            double fipe = 0;

            Console.WriteLine("Olá, digite uma das opções abaixo:\n");
            Console.WriteLine("1 - Carro;");
            Console.WriteLine("2 - Moto;");
            Console.WriteLine("3 - Caminhão;");
            Console.Write("\n= ");
            vehicle = int.Parse(Console.ReadLine());

            if ((vehicle >= 4) || (vehicle <= 0))
            {
                Console.Write("\nVOCÊ É IMBECIL OU SE FAZ????? COLOCA UMA DAS OPÇÕES >>>VÁLIDAS<<<, BURRO(A).");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.Write("\nÓtimo, agora digite o valor do seu veículo: " + "R$ ");
            fipe = double.Parse(Console.ReadLine());

            switch (vehicle)
            {
                case 1:
                    ipva = fipe * 0.06;
                    break;
                case 2:
                    ipva = fipe * 0.08;
                    break;
                case 3:
                    ipva = fipe * 0.035;
                    break;
                default:
                    Console.Write("\nAlgo deu errado e provavelmente a culpa é sua. Tenta de novo.");
                    break;
            }

            Console.WriteLine("\nOk, o valor a ser pago do seu IPVA é de R$ " + ipva.ToString());


            Console.ReadKey();
        }
    }
}