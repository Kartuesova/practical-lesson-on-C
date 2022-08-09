internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число:   ");
        string writeNumber = Console.ReadLine();
        int endNumber = Convert.ToInt32(writeNumber);
        int Number = endNumber * -1;
        Console.Write($"{Number} ");

        while (Number < endNumber)
        {
            Number++;
            Console.Write($"{Number} ");
        }
        Console.WriteLine(); Console.WriteLine();
    }
}