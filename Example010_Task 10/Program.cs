﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine();

        int Number1 = new Random().Next(11, 101);
        int Number2 = new Random().Next(1, 11);
        int result = 0;

        int MultipleNumber()
        {
            result = Number1 % Number2;
            return result;
        }

        MultipleNumber();

        Console.WriteLine();
        if (result == 0) Console.WriteLine($"Число {Number1} кратно числу {Number2}");
        else
        {
            Console.WriteLine($"Число {Number1} не кратно числу {Number2}, остаток от деления равен {Number1 % Number2}");
        }
        Console.WriteLine();
    }
}