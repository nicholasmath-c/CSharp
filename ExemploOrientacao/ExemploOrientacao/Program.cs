using System;

namespace ExemploOrientacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();

            Console.WriteLine("Insira a marca do carro: ");
            carro.marca = Console.ReadLine();
            Console.WriteLine("Insira a cor do carro: ");
            carro.cor = Console.ReadLine();
            Console.WriteLine("Insira a quantidade de portas do carro: ");
            carro.qntdPortas = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o modelo do carro: ");
            carro.modelo = Console.ReadLine();
            Console.WriteLine("Insira o ano do carro: ");
            carro.ano = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine(carro.marca);
            Console.WriteLine(carro.cor);
            Console.WriteLine(carro.qntdPortas);
            Console.WriteLine(carro.modelo);
            Console.WriteLine(carro.ano);
        }
    }
}
