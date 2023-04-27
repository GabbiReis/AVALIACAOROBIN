using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliaçaoRobinson
{
    internal class Covid : Virus
    {
        private int TotalQuarentenaDias;

        public Covid(int totalQuarentenaDias)
        {
            this.TotalQuarentenaDias = totalQuarentenaDias;
        }

        public override void ImprimirRecomendacoesTratamento()
        {
            DateTime CalcularDataRetorno = DateTime.Now.AddDays(TotalQuarentenaDias);
            Console.WriteLine("Retorne ao trabalho no dia " + CalcularDataRetorno.ToString("dd/MM/yyyy"));
        }
    }
}
