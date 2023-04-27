using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliaçaoRobinson
{
    public class AnalisaVirus
    {
        public static void AnalisarVirusInfo()
        {
            Console.WriteLine("Digite o seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o tipo do vírus:");
            string tipo = Console.ReadLine();

            Virus virus;
            if (tipo == "Covid")
            {
                Console.WriteLine("Digite o total de dias de quarentena:");
                int TotalQuarentenaDias = int.Parse(Console.ReadLine());
                virus = new Covid(TotalQuarentenaDias);
            }
            else if (tipo == "H1N1")
            {
                virus = new H1N1();
            }
            else
            {
                Console.WriteLine("Tipo de vírus inválido!");
                return;
            }

            virus.ImprimirRecomendacoesTratamento();
        }

    }
}

