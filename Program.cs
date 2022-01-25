// See https://aka.ms/new-console-template for more information
using Programacao_orientada_objeto_ContaBancariaSimples;


var conta01 = new ContaBancaria("Julio Maciel", 10000);

Console.WriteLine("Conta bancária nº1");
Console.WriteLine();

Console.WriteLine($"Número da conta: {conta01.NumeroDaConta}");
Console.WriteLine();
Console.WriteLine($"Nome do proprietário da conta: {conta01.NomeDoProprietarioDaConta}");
Console.WriteLine();
Console.WriteLine($"Saldo: {conta01.SaldoBalanco}");

Console.WriteLine();

Console.WriteLine("--------------------------");
Console.WriteLine();


var conta02 = new ContaBancaria("Bruna Karoline Moraes Maciel", 50000);

Console.WriteLine("Conta bancária nº2");

Console.WriteLine();

Console.WriteLine($"Número da conta: {conta02.NumeroDaConta}");
Console.WriteLine();
Console.WriteLine($"Nome do proprietário da conta: {conta02.NomeDoProprietarioDaConta}");
Console.WriteLine();
Console.WriteLine($"Saldo: {conta02.SaldoBalanco}");

// Algumas transações da Conta nº1
conta01.FazerDeposito(1000, DateTime.Now, "Uma venda");
Console.WriteLine(conta01.SaldoBalanco);
Console.WriteLine(conta01.ObterHistoricoDasTransacoesdaContaBancaria());
