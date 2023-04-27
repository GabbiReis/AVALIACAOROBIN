using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliaçaoRobinson
{
    internal class H1N1 : Virus
    {
        public override void ImprimirRecomendacoesTratamento()
        {
            bool ficarEmCasa = AnalisarVariacao(0);
            if (ficarEmCasa)
            {
                Console.WriteLine("Fique em casa por 5 dias.");
            }
            else
            {
                Console.WriteLine("Pode trabalhar, mas use máscara.");
            }
        }

        private bool AnalisarVariacao(int variacao)
        {
            if (variacao == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

