using System;
class Trab
{
    public static void Main()
    {
        int op=0;

        do {
            
            Console.Clear();
            Console.WriteLine("Escolha o programa devido ao seu gosto: ");
            Console.WriteLine("1 -- Tabuada");
            Console.WriteLine("2 -- Media da ulbra");
            Console.WriteLine("3 -- Calculadora");
            Console.WriteLine("4 -- IMC");
            Console.WriteLine("5 -- Sair");
            op = int.Parse(Console.ReadLine());

                while (op<1 || op>5){

                    Console.WriteLine("Número inválido, digite conforme o menu");
                    op = int.Parse(Console.ReadLine());

                }

            if (op==1){
               
                float n;
                float c = 0;
                float r;

                Console.Clear();
                Console.WriteLine("Digite o número para ter sua tabuada:");
                n = float.Parse (Console.ReadLine());

                while (c<=10)
                {

                    r=n*c;
                    Console.WriteLine(n + "*" + c + "=" +r);
                    c++;
                }
                Console.WriteLine("Clique no enter para voltar");
                Console.ReadLine();
            }

            if (op==2){

                float g1 = 0;
                float g2 = 0;
                float media = 0;
                
                Console.Clear();
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
                
                Console.WriteLine("Clique no enter para voltar");
                Console.ReadLine();
            }

            
            if (op==3){

                float N1 = 0;
                float N2 = 0;
                float R = 0;
                string oper="";

                Console.Clear();
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
                Console.WriteLine("Clique no enter para voltar");
                Console.ReadLine();
            }

            if (op==4){

                
                float kg = 0;
                float h = 0;
                float imc = 0;
                string s = "";
 
                Console.Clear();
                Console.WriteLine("Digite seu sexo: [M] ou [F]");
                s = Console.ReadLine();
 
                Console.WriteLine("Qual seu peso em kg? ");
                kg = float.Parse(Console.ReadLine());
 
                Console.WriteLine("Qual sua altura em metros? ");
                h = float.Parse(Console.ReadLine());
 
                imc = kg/(h*h);
 
                    if(s == "m" || s == "M")
                        {
                            if(imc < 20.7){
                                Console.WriteLine("Abaixo do Peso! IMC: {0:00.00}", imc);
                            } else if(imc < 26.4){
                                Console.WriteLine("Peso normal! IMC: {0:00.00}", imc);
                            } else if(imc < 27.8){
                                Console.WriteLine("Marginalmente acima do peso! IMC: {0:00.00}", imc);
                            } else if(imc < 31.1){
                                Console.WriteLine("Acima do Peso ideal! IMC: {0:00.00}", imc);
                            } else{
                                Console.WriteLine("Obeso! IMC: {0:00.00}", imc);
                            }
                       } 
                    else if(s == "f" || s == "F")
                    {
                            if(imc < 19.1){
                                Console.WriteLine("Abaixo do Peso! IMC: {0:00.00}", imc);
                            } else if(imc < 25.8){
                                Console.WriteLine("Peso normal! IMC: {0:00.00}", imc);
                            } else if(imc < 27.3){
                                Console.WriteLine("Marginalmente acima do peso! IMC: {0:00.00}", imc);
                            } else if(imc < 32.3){
                                Console.WriteLine("Acima do Peso ideal! IMC: {0:00.00}", imc);
                            } else{
                                Console.WriteLine("Obeso! IMC: {0:00.00}", imc);
                            }
                    }
                    else{
                        Console.WriteLine("Letra errada, informe novamente, [M] ou [F]: ");
                    }
                Console.WriteLine("Clique no enter para voltar");
                Console.ReadLine();

            }

            if (op==5){

                Console.WriteLine("Bye Bye!!");
            }

        }while (op!=5);
    }    
}