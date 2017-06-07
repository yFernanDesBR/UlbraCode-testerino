#include<stdio.h>
#include<conio.h>
main( )
{
	float n, n2, soma;
		printf ("Informe o primeiro numero:");
		scanf ("%f", &n);
		printf ("\nInforme o segundo numero:");
		scanf ("%f", &n2);
		soma=(n+n2);
			if (soma>20){
				soma=(n+n2+8);
				printf ("\nO resultado dos seus numeros e:%.2f", soma);
			}
			if (soma<=20){
				soma=(n+n2-5);
				printf ("\nO resultado dos seus numeros e:%.2f", soma);
			}
}
