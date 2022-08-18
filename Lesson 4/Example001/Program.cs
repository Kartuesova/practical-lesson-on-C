//Выяснить являются ли три числа сторонами треугольника

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число c: ");
int c = int.Parse(Console.ReadLine());

if (a<b+c && b<a+c && c<a+b)
{
    Console.WriteLine("Это треугольник : ");

}
else 
{
 Console.WriteLine("Это не треугольник : ");
}


// второй вариант

bool CheckTriangle(int a, int b, int c) => a+b>c && b+c>a && a+c>b;
    
    
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine() ?? "0");

bool check = CheckTriangle(number1, number2, number3);
Console.WriteLine(check ? "Три числа являются сторонами треугольника" :
                    "Три числа не являются сторонами треугольника");