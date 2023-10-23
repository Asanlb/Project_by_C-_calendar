using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите год :");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите месяц (1-12):");
        int month = int.Parse(Console.ReadLine());

        DateTime date = new DateTime(year, month, 1);
        int daysInMonth = DateTime.DaysInMonth(year, month);

        Console.WriteLine($"{date.ToString("MMMM")} {year}");
        Console.WriteLine("Пн Вт Ср Чт Пт Сб Вс");

        int dayOfWeek = (int)date.DayOfWeek;
        for (int i = 0; i < dayOfWeek-1; i++)
        {
            Console.Write("   ");
        }

        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write($"{day:D2} ");

            if ((day + dayOfWeek-1) % 7 == 0)
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine();
    }
}