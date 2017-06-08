using System;
class Calculator
{
	public static void Main()
	{
		int n;
		Console.Write("Digite um número:");
		n = int.Parse(Console.ReadLine());
		Console.WriteLine("O usuário digitou o número " + n );
		Console.ReadLine();
	}
}
