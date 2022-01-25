using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacao_orientada_objeto_ContaBancariaSimples
{
    public class Transacao
    {
        public decimal Montante { get; }
        public DateTime DataDaTransacao { get; }
        public string DescricaoDaTransacao { get; set; }

        public Transacao(decimal montante, DateTime data, string descricao)
        {
            Montante = montante;
            DataDaTransacao = data;
            DescricaoDaTransacao = descricao;
        }
    }
}
