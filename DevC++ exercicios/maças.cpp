#include<stdio.h>
#include<conio.h>
main( )
{
	float total;
	int nm1;
		printf ("Quantas maças foram compradas?");
		scanf ("%i", &nm1);
		if (nm1<12){
			total=(nm1*1.3);
			printf ("\nO preço a ser pago é:%.2f", total);
		}
		else {
			total=(nm1*1);
			printf ("\nO preço a ser pago é:%.2f", total);
		}
}
