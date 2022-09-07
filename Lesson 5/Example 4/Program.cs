Console.WriteLine("Здать длинну прямоугольника");
long n = long.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Здать ширину прямоугольника");
long m = long.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Здать сторону квадрата");
long a = long.Parse(Console.ReadLine() ?? "0");

long sum = ((m + a - 1)/a) * ((n + a - 1) / a);



