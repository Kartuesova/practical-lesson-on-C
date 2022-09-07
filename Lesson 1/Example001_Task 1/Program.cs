internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число: ");
        string writeNumber1 = Console.ReadLine();
        int number1 = Convert.ToInt32(writeNumber1);

        Console.WriteLine("Введите второе число: ");
        string writeNumber2 = Console.ReadLine();
        int number2 = Convert.ToInt32(writeNumber2);

        string txtResult = $"Число {number1} не является квадратом числа {number2}";     

        if (number1 == number2 * number2)               
        {
            txtResult = txtResult.Replace(" не", "");  
        }
        Console.WriteLine(txtResult);
        Console.WriteLine();
    }
}