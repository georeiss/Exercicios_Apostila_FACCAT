using System;

public class Exercicio004
{
	public static void Executar()
	{
		int A = 6 * (3 + 2);
		int B = 2 + 6 * (3 + 2);
		int C = 2 + 3 * 6 / (2 + 4);
		int D = 2 * 8 / (3 + 1);
		int E = 3 + (16 - 2) / (2 * (9 - 2));
		int F = (6 / 3 + 8 / 2);
		int G = (3 + (8 / 2)) * 4 + (3 * 2);
		int H = (6 * 3 * 3 + 6) - 10;
		int I = (10 * 8 + 3) * 9;
		int J = (-12 * -4) + (3 * -4);

		Console.WriteLine($"{A} {B} {C} {D} {E} {F} {G} {H} {I} {J}");
	}
}
