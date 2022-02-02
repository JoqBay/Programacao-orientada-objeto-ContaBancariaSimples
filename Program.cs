// See https://aka.ms/new-console-template for more information
using Programacao_orientada_objeto_ContaBancariaSimples;


var conta01 = new ContaBancaria("Julio Maciel", 10000);



Console.WriteLine("Tipos de Conta");
Console.WriteLine(" Pessoa Física: 1 \n" +
   " Pessoa Jurídica: 2");

Console.WriteLine();

Console.WriteLine("Conta bancária nº1");
Console.WriteLine();


Console.WriteLine($"Tipo da Conta:  {conta01.PessoaFisica}");

Console.WriteLine();


Console.WriteLine($"Número da conta: {conta01.NumeroDaConta}");
Console.WriteLine();
Console.WriteLine($"Nome do proprietário da conta: {conta01.NomeDoProprietarioDaConta}");
Console.WriteLine();
Console.WriteLine($"Saldo: {conta01.SaldoBalanco}");

Console.WriteLine();

Console.WriteLine("--------------------------");
Console.WriteLine();


var conta02 = new ContaBancaria("Empresa de Tecnologia LTDA.", 500000);

Console.WriteLine("Conta bancária nº2");

Console.WriteLine();

Console.WriteLine($"Tipo da Conta: {conta02.PessoaJuridica}");

Console.WriteLine();


Console.WriteLine($"Número da conta: {conta02.NumeroDaConta}");
Console.WriteLine();
Console.WriteLine($"Nome do proprietário da conta: {conta02.NomeDoProprietarioDaConta}");
Console.WriteLine();
Console.WriteLine($"Saldo: {conta02.SaldoBalanco}");

Console.WriteLine();

Console.WriteLine("Algumas transações");

Console.WriteLine();

// Algumas transações da Conta nº1
conta01.FazerDeposito(1000, DateTime.Now, "Uma venda");
Console.WriteLine(conta01.SaldoBalanco);
Console.WriteLine();

Console.WriteLine(conta01.ObterHistoricoDasTransacoesdaContaBancaria());
