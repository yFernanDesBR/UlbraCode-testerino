#include<stdio.h>
#include<conio.h>
main ( )
{
	float n1, n2, media;
		printf ("Nota 1: ");
		scanf ("%f", &n1);
		printf ("\nNota 2: ");
		scanf ("%f", &n2);
		media=(n1+n2*2)/3;
		printf ("\nMedia=%.2f", media);
		if (media>=9) {
			printf ("\nSeu conceito foi A");
		}
		if ((media>=7.5) && (media<9)) {
			printf ("\nSeu conceito foi B");
		}
		if ((media>=6) && (media<7.5)){
			printf ("\nSeu conceito foi C");
		}
		if (media<6) {
			printf ("\nSeu conceito foi D");
		}					
}
