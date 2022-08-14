// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int dayNumber = new Random().Next(1, 8);
string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string Result = "";

if (dayNumber > 5)
{
 Console.WriteLine((Result) = $"Выходной день:");
}
else 
{
Console.WriteLine((Result) = $"Рабочий день:");
}
System.Console.WriteLine();
System.Console.WriteLine($"{dayNumber}-й день недели - это {Days[dayNumber - 1]} {Result}");
