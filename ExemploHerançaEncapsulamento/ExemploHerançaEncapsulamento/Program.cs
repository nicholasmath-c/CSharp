using System;

namespace ExemploHerançaEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno obj = new Aluno();

            obj.Nome = "LOVE STORY";
            Console.WriteLine(obj.Nome);
        }
    }
}
