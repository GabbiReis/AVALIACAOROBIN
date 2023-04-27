using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("========== MENU ==========");
            Console.WriteLine("1 - CADASTRAR CIDADE");
            Console.WriteLine("2 - IMPRIMIR CIDADE");
            Console.WriteLine("3- LOCALIZAR CIDADE COM MAIOR POPULAÇAO");
            Console.WriteLine("Digite a opção desejada: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Cidade cidade = new Cidade();
                    Console.WriteLine("Digite o nome da cidade: ");
                    cidade.Nome = Console.ReadLine();
                    Console.WriteLine("Digite o número da população: ");
                    cidade.Populacao = int.Parse(Console.ReadLine());
                    break;
                case 2:
                    Estado estado = new Estado();
                    Console.WriteLine($"Cidade: {estado.Cidades}");
                    break;
                case 3:
                    Cidade cidade1 = new Cidade();
                    Console.WriteLine($"Maior população: {cidade1.Populacao}");
                    break;
          
                default:
                    Console.WriteLine("Opção invalida");
                    break;

            }
        }
    }
}
