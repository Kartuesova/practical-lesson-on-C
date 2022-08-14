internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите значение N:");
        int N = int.Parse(Console.ReadLine());

        int count = 1;
        while (count < N)
        {
            Console.WriteLine(count * count);
            count++;
        }
    }
}