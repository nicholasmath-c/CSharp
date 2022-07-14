using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nota = new double[4];
            double media;
            double frequencia;

            for (int i = 0; i < nota.Length; i++)
            {
                Console.Write("Insira a " + (i+1) + "ª nota: ");
                nota[i] = double.Parse(Console.ReadLine());
;           }

            media = (nota[0] + nota[1] + nota[2] + nota[3]) / 4;

            Console.Write("\nAgora informe a frequência do aluno: ");
            frequencia = double.Parse(Console.ReadLine());

            if(media >= 5 && frequencia >= 75){
                Console.Write("\n\nRESULTADO:\nO aluno foi aprovado.\nMédia: " + media + "\nFrequência: " + frequencia + "%\n");
            }
            else
            {
                Console.Write("\n\nRESULTADO:\nO aluno foi reprovado.\nMédia: " + media + "\nFrequência: " + frequencia + "%\n");
            }
        }
    }
}
