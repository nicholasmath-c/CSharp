using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeViagens
{
    class Program
    {
        static void Main(string[] args)
        {
            int op; //opção do menu

            List<Viagem> lstCadastro = new List<Viagem>();

            do
            {
                Console.Clear();
                Console.WriteLine("Menu - Controle de Viagens");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Listar Cadastros");
                Console.WriteLine("3 - Sair");
                //op = int.parse(Console.ReadLine());
                int.TryParse(Console.ReadLine(), out op);

                switch (op)
                {
                    case 1:
                        //Cadastro
                        Viagem d = new Viagem();
                        Console.WriteLine("Informe o Estado: ");
                        d.Estado = Console.ReadLine();
                        Console.WriteLine("Informe a Cidade: ");
                        d.Cidade = Console.ReadLine();
                        Console.WriteLine("Informe o Tipo de Transporte: ");
                        d.Tipotrans = Console.ReadLine();
                        Console.WriteLine("Informe o Acomodação: ");
                        d.Acomodacao = Console.ReadLine();
                        Console.WriteLine("Informe o Valor: ");
                        d.Valor = double.Parse(Console.ReadLine());


                        lstCadastro.Add(d); //Adiciona na lista o objeto
                        Console.WriteLine("Cadastro feito com sucesso");
                        break;
                    case 2:
                        //Listar Cadastro
                        if(lstCadastro.Count > 0)
                        {
                            foreach (Viagem item in lstCadastro)
                            {
                                Console.WriteLine(item.RetornaDados());
                            }
                            Console.WriteLine("Fim da lista");
                        }
                        else
                        {
                            Console.WriteLine("Lista vazia!");
                        }
                        break;
                    case 3: Console.WriteLine("Tchau o/");
                        break;
                    default: Console.WriteLine("Opção Inválida!");
                        break;
                        
                }

                Console.ReadKey();

            } while (op != 3);

            Console.ReadKey();
        }
    }
}
