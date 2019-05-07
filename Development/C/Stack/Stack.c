#include<stdio.h>

void main()
{
	int const*a = 5;
	int b = 10;
	a = &b;
	printf("%d\t\t%d", b, a);
	getch();
}