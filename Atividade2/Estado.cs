using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Estado
    {
        public List<Cidade> Cidades { get; set; }

        public Estado()
        {
            Cidades = new List<Cidade>();
        }

        public void CadastrarCidade(Cidade cidade)
        {
            Cidades.Add(cidade);
        }

        public void ImprimirCidade(string nome)
        {
            foreach (Cidade cidade in Cidades)
            {
                Console.WriteLine($"Cidade: {cidade.Nome}");
            }
        }
        public void localizarcidademaiorpopulacao()
        {

            int populacao = int.MinValue;

            if (populacao > 0)
            {
                Console.WriteLine("Quantidade de população: ");
            }
        }
    }
}
