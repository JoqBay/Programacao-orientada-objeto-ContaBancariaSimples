using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacao_orientada_objeto_ContaBancariaSimples
{
    public class ContaDeJuros : ContaBancaria
    {
        public ContaDeJuros(string nome, decimal saldoInicialBalanco) : base(nome, saldoInicialBalanco)
        {
        }

        public override void RealizarTransacaoDeFimDeMes()
        {
            if (SaldoBalanco > 500m)
            {
                var juros = SaldoBalanco * 0.05m;
                FazerDeposito(juros, DateTime.Now, "Aplicar juros mensais");
            }
            

        }
    }
}
