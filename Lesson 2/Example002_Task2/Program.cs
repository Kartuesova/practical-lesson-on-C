internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите координату х, не равную нулю: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите координату y, не равную нулю: ");
        int y = int.Parse(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine("Координата находится в первой четверти: ");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Координата находится во второй четверти: ");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Координата находится в третьей четверти: ");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Координата находится в четвертой четверти: ");
        }
    }
}