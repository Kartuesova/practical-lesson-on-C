namespace ConsoleApplication1

{
    enum Week
    {
        p1 = 1,
        v2,
        s3,
        ch4,
        p5,
        s6,
        v7
    };
    class program
    {
        static void Main(string[] args)
    {
        Console.WriteLine( "Введите число(от 1 до 7): ");
        Week mb =Converter.ToInt16(Console.ReadLine());
        TellAboutWeek(mb);
    }

        private static void TellAboutWeek(Week mb)
        {
            throw new NotImplementedException();
        }
    }

    internal class Converter
    {
        internal static Week ToInt16(string? v)
        {
            throw new NotImplementedException();
        }
    }

    private static void TellAboutWeek(Week mb)
         {
          switch(mb)
            {  
                case Week.p1:
                    Console.WriteLine("Понедельник");
                    break;
                case Week.v2:
                    Console.WriteLine("Вторник");
                    break;
                case Week.s3:
                    Console.WriteLine("Среда");
                    break;
                case Week.ch4:
                    Console.WriteLine("Четверг");
                    break;
                case Week.p5:
                    Console.WriteLine("Пятница");
                    break;
                case Week.s6:
                    Console.WriteLine("Суббота");
                    break;
                case Week.v7:
                    Console.WriteLine("Воскресенье");
                    break;
                
            }
        }
    }

