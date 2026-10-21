using System;

public class Exercicio025
{
	public static void Executar()
	{
		Console.WriteLine("Digite o numero da conta do cliente: ");
		int conta = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite o saldo da conta do cliente: ");
		double saldo = double.Parse(Console.ReadLine());
		Console.Write("Digite o saldo do débito: ");
		double saldoDebito = double.Parse(Console.ReadLine());
		Console.Write("Digite o saldo do crédito: ");
		double saldoCredito = double.Parse(Console.ReadLine());

		double saldoTotal = saldo - saldoDebito + saldoCredito;

		if (saldoTotal >= 0)
		{
			Console.Write($"Saldo total: {saldoTotal} - Saldo Positivo");

		}
		else
		{
			Console.Write($"Saldo total: {saldoTotal} - Saldo Negativo");
		}
	}
}
