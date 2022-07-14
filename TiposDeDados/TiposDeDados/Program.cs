
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comentários Lineares
            /* Comentários
             * em
             * bloco
             */

            Console.Write("Informe o primeiro valor: ");
            int v1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            int v2 = Convert.ToInt32(Console.ReadLine());

            int r = v1 + v2;
            Console.Write("Resultado: " + r.ToString() );

            Console.ReadKey();

        }
    }
}
