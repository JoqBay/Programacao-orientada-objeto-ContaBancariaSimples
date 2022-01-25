using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacao_orientada_objeto_ContaBancariaSimples
{
    public class ContaBancaria
    {
        private static int numeroDaContaIncremental = 1234567890;
        public string NumeroDaConta { get; }
        public string NomeDoProprietarioDaConta { get; set; }
        public decimal SaldoBalanco
        {
            get
            {
                decimal saldoBalanco = 0;
                foreach (var item in todasAsTransacoes)
                {
                    saldoBalanco += item.Montante;
                }

                return saldoBalanco;
            }
        }

        private List<Transacao> todasAsTransacoes = new List<Transacao>();


        private readonly decimal saldoMinimoBalanco;

        public ContaBancaria(string nome, decimal saldoInicialBalanco) : this(nome, saldoInicialBalanco, 0)
        {

        }


        public ContaBancaria(string nome, decimal saldoInicialBalanco, decimal saldoMinimoBalanco)
        {
            NumeroDaConta = numeroDaContaIncremental.ToString();
            numeroDaContaIncremental++;

            NomeDoProprietarioDaConta = nome;
            this.saldoMinimoBalanco = saldoMinimoBalanco;
            if (saldoInicialBalanco > 0)
                FazerDeposito(saldoInicialBalanco, DateTime.Now, "Saldo inicial da conta");
        }



        public void FazerDeposito(decimal montante, DateTime data, string descricao)
        {
            if (montante <= 0)
                throw new ArgumentOutOfRangeException(nameof(montante), "O valor de depósito deve ser positivo");

            var deposito = new Transacao(montante, data, descricao);
            todasAsTransacoes.Add(deposito);
        }


        public void FazerSaque(decimal montante, DateTime data, string descricao)
        {
            if (montante <= 0)
                throw new ArgumentOutOfRangeException(nameof(montante), "O valor de saque deve ser positivo");

            var transacaoDeChequeEspecial = ChecarLimiteDeSaqueParaTerOpcoes(SaldoBalanco - montante < saldoMinimoBalanco);
            var saque = new Transacao(-montante, data, descricao);
            todasAsTransacoes.Add(saque);
            if (transacaoDeChequeEspecial != null)
                todasAsTransacoes.Add(transacaoDeChequeEspecial);
        }


        protected virtual Transacao? ChecarLimiteDeSaqueParaTerOpcoes(bool issoEOverdrawn)
        {
            if (issoEOverdrawn)
            {
                throw new InvalidOperationException("Fundos insuficientes para esse saque");
            }
            else
            {
                return default;
            }
        }


        public string ObterHistoricoDasTransacoesdaContaBancaria()
        {
            var relatorioDastransacoes = new System.Text.StringBuilder();

            decimal saldoBalanco = 0;
            relatorioDastransacoes.AppendLine($"Data       \b\tMontante      \b\tDescrição da Transação");
            foreach (var item in todasAsTransacoes)
            {
                saldoBalanco += item.Montante;
                relatorioDastransacoes.AppendLine($"{item.DataDaTransacao.ToShortDateString()}    \b\t{item.Montante}         \b\t{item.DescricaoDaTransacao}");
            }

            return relatorioDastransacoes.ToString();
        }
    }
}
