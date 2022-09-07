// Показать двумерный массив размером m×n заполненный целыми числами
void PrintArray(int [,]matrix)
{
for (int i=0; i<matrix.GetLength(0); i++)
{
    for (int g=1; g<matrix.GetLength(1); g++)
    {
        Console.Write($" {matrix[i,g]}\t");
    }
    Console.WriteLine();
}
}
void FillArrayRandom(int[,]matrix,int min,int max)
{
    var rand=new Random();
    for (int i=0; i<matrix.GetLength(0); i++)
    { 
        for (int g=1; g<matrix.GetLength(1); g++)
        matrix[i,g]=rand.Next(min,max+1);
    }
}
Console.Clear();
int m,n;
m = int.Parse(Console.ReadLine());
n = int.Parse(Console.ReadLine());
int[,]array= new int[m,n];
FillArrayRandom(array,-10,10);
PrintArray(array);

