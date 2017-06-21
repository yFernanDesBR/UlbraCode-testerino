using System;
class Tabuada
{
    public static void Main()
    {
        int i = 0;
        do
         {
            float n;
            float c = 0;
            float r;

            Console.WriteLine("Digite o número para ter sua tabuada:");
            n = float.Parse (Console.ReadLine());

            while (c<=10)
            {

                r=n*c;
                Console.WriteLine(n + "*" + c + "=" +r);
                c++;
            }  
        } while (i<2);   
        Console.ReadLine();
    }
}