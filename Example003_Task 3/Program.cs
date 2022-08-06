int a=3;
int b=9;
int c=5;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c  >max) max = c;

Console.Write("max = ");
Console.WriteLine(max);