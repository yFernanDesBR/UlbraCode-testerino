using System;
class media
{
	public static void Main()
	{
		float g1 = 0;
		float g2 = 0;
		float media = 0;
		Console.WriteLine("Informe nota da G1");
		g1 = float.Parse(Console.ReadLine());
		
		Console.WriteLine("Informe nota da G2");
		g2 = float.Parse(Console.ReadLine());
		
		media = (g1+(g2*2))/3;
		
		Console.WriteLine("Sua media � " + media);
			
			if(media>=6)
			Console.WriteLine("Parabens voc� foi aprovado!");
			
			else
			Console.WriteLine("Meeeee, bora estudar jovem? Pois voc� est� reprovado!");
		
		Console.ReadLine();
	}
}
