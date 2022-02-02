using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacao_orientada_objeto_ContaBancariaSimples
{
    internal class ContaPessoaFisica : ContaBancaria
    {
        

        public ContaPessoaFisica(string nome, decimal saldoInicialBalanco, decimal saldoMinimoBalanco) : base(nome, saldoInicialBalanco, saldoMinimoBalanco, 1, 2)
        {
            
        }
    }
}
