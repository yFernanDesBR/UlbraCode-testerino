#include<stdio.h>
#include<conio.h>
main( )
{
	float total;
	int nm1;
		printf ("Quantas ma�as foram compradas?");
		scanf ("%i", &nm1);
		if (nm1<12){
			total=(nm1*1.3);
			printf ("\nO pre�o a ser pago �:%.2f", total);
		}
		else {
			total=(nm1*1);
			printf ("\nO pre�o a ser pago �:%.2f", total);
		}
}
