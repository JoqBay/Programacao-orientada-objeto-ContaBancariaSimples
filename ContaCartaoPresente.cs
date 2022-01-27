using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacao_orientada_objeto_ContaBancariaSimples
{
    public class ContaCartaoPresente : ContaBancaria
    {
        private decimal _depositoMensal = 0m;

        public ContaCartaoPresente(string nome, decimal saldoInicialBalanco, decimal depositoMensal = 0) : base(nome, saldoInicialBalanco)
            => _depositoMensal = depositoMensal;

        public override void RealizarTransacaoDeFimDeMes()
        {
            if (_depositoMensal != 0)
            {
                FazerDeposito(_depositoMensal, DateTime.Now, "Adicionar depósito mensal");
            }

    }
}
