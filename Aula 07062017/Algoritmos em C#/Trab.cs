using System;
class Trab
{
    public static void Main()
    {
        int op=0;

        do {
            
            Console.Clear();
            e("Escolha o programa devido ao seu gosto: ");
            e("1 -- Tabuada");
            e("2 -- Media da ulbra");
            e("3 -- Calculadora");
            e("4 -- IMC");
            e("5 -- Sair");
            op = int.Parse(Console.ReadLine());

                while (op<1 || op>5){

                    e("Número inválido, digite conforme o menu");
                    op = int.Parse(Console.ReadLine());

                }

            if (op==1){
               
                float n;
                float c = 0;
                float r;

                Console.Clear();
                e("Digite o número para ter sua tabuada:");
                n = float.Parse (Console.ReadLine());

                while (c<=10)
                {

                    r=n*c;
                    e(n + "*" + c + "=" +r);
                    c++;
                }
                voltar();
                Console.ReadLine();
            }

            if (op==2){

                float g1 = 0;
                float g2 = 0;
                float media = 0;
                
                Console.Clear();
                e("Informe nota da G1");
                g1 = float.Parse(Console.ReadLine());
                
                e("Informe nota da G2");
                g2 = float.Parse(Console.ReadLine());
                
                media = (g1+(g2*2))/3;
                
                e("Sua media � " + media);
                    
                    if(media>=6)
                    e("Parabens voc� foi aprovado!");
                    
                    else
                    e("Meeeee, bora estudar jovem? Pois voc� est� reprovado!");
                
                voltar();
                Console.ReadLine();
            }

            
            if (op==3){

                float N1 = 0;
                float N2 = 0;
                float R = 0;
                string oper="";

                Console.Clear();
                e("Selecione a opção + | - | * | /");
                oper = Console.ReadLine();


                e("Digite um número");
                N1 = float.Parse (Console.ReadLine());

                e("Digite um número");
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
                        e("Operação inválida.");      

                e("O resultado é:" + N1 + oper + N2 + "=" + R);
                voltar();
                Console.ReadLine();
            }

            if (op==4){

                
                float kg = 0;
                float h = 0;
                float imc = 0;
                string s = "";
 
                Console.Clear();
                e("Digite seu sexo: [M] ou [F]");
                s = Console.ReadLine();
 
                e("Qual seu peso em kg? ");
                kg = float.Parse(Console.ReadLine());
 
                e("Qual sua altura em metros? ");
                h = float.Parse(Console.ReadLine());
 
                imc = kg/(h*h);
 
                    if(s == "m" || s == "M")
                        {
                            if(imc < 20.7){
                                e("Abaixo do Peso! IMC: {0:00.00}", imc);
                            } else if(imc < 26.4){
                                e("Peso normal! IMC: {0:00.00}", imc);
                            } else if(imc < 27.8){
                                e("Marginalmente acima do peso! IMC: {0:00.00}", imc);
                            } else if(imc < 31.1){
                                e("Acima do Peso ideal! IMC: {0:00.00}", imc);
                            } else{
                                e("Obeso! IMC: {0:00.00}", imc);
                            }
                       } 
                    else if(s == "f" || s == "F")
                    {
                            if(imc < 19.1){
                                e("Abaixo do Peso! IMC: {0:00.00}", imc);
                            } else if(imc < 25.8){
                                e("Peso normal! IMC: {0:00.00}", imc);
                            } else if(imc < 27.3){
                                e("Marginalmente acima do peso! IMC: {0:00.00}", imc);
                            } else if(imc < 32.3){
                                e("Acima do Peso ideal! IMC: {0:00.00}", imc);
                            } else{
                                e("Obeso! IMC: {0:00.00}", imc);
                            }
                    }
                    else{
                        e("Letra errada, informe novamente, [M] ou [F]: ");
                    }
                voltar();
                Console.ReadLine();

            }

            if (op==5){

                e("Bye Bye!!");
            }

        }while (op!=5);
    } 

    static void voltar(){
       e("Clique no enter para voltar");
    }
    static void e(string frase){
        e(frase);
    }
}