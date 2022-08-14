// Дано число, нужно проверить кратность 7,23
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число для проверки кратности 7 и 23: ");
        int a = int.Parse(Console.ReadLine());

        if (a % 7 == 0 && a % 23 == 0)
        {
            Console.WriteLine("Число" + a + "кратно 7 и 23");
        }
        else
        {
            Console.WriteLine("Число" + a + " не кратно 7 и 23");
        }
    }
}