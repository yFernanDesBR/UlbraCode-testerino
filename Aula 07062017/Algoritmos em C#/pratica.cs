using System;
class pratica
{
    public static void Main()
    {
        float N1 = 0;
        float N2 = 0;
        float R = 0;
        string oper="";

        Console.WriteLine("Selecione a opção + | - | * | /");
        oper = Console.ReadLine();


        Console.WriteLine("Digite um número");
        N1 = float.Parse (Console.ReadLine());

        Console.WriteLine("Digite um número");
        N2 = float.Parse (Console.ReadLine());

        if (oper== "+")
        {
             R = N1 + N2;

        }
        else if (oper== "-")
        {
            R = N1 - N2;

        }
        else if (oper== "*")
        {
             R = N1 * N2;

        }
        else if (oper== "/")
        {
             R = N1 / N2;

        }
        else
             Console.WriteLine("Operação inválida.");      

        Console.WriteLine("O resultado é:" + N1 + oper + N2 + "=" + R);
        Console.ReadLine();
    } 
}