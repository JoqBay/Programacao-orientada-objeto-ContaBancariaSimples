using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacao_orientada_objeto_ContaBancariaSimples
{
    public class ContaDeLinhaDeCredito : ContaBancaria
    {
        public ContaDeLinhaDeCredito(string nome, decimal saldoInicialBalanco) : base(nome, saldoInicialBalanco)
        {
        }

        public override void RealizarTransacaoDeFimDeMes()
        {
            // Negar o saldo para obter uma taxa de juros positiva:
            if (SaldoBalanco < 0)
            {
                var juros = -SaldoBalanco * 0.07m;
                FazerSaque(juros, DateTime.Now, "Cobrar juros mensais");
            }
        }

        protected override Transacao? ChecarLimiteDeSaqueParaTerOpcoes(bool issoEOverdrawn) => issoEOverdrawn
                ? new Transacao(-20, DateTime.Now, "Aplicar taxa ao cheque especial")
                : default;
    }
}
