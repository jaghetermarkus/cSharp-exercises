using _01_Enums.Enums;

namespace _01_Enums.Service;

public class WeekdayService
{
	public void Run()
	{
        var weekday = Weekdays.Wednesday;

        switch (weekday)
        {
            case Weekdays.Monday:
                Console.WriteLine("Det är måndag.");
                break;
            case Weekdays.Tuesday:
                Console.WriteLine("Det är tisdag.");
                break;
            case Weekdays.Wednesday:
                Console.WriteLine("Det är lill-lördag!");
                break;
            case Weekdays.Thursday:
                Console.WriteLine("Det är torsdag.");
                break;
            case Weekdays.Friday:
                Console.WriteLine("Det är fredag, HELG!!");
                break;
            case Weekdays.Saturday:
                Console.WriteLine("Det är lördag.");
                break;
            case Weekdays.Sunday:
                Console.WriteLine("Det är söndag...");
                break;
        }

        Console.ReadKey();
    }
}

