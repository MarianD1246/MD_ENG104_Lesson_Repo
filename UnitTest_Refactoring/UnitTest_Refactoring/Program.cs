using System;

namespace CodeToTest;

public class Program
{
    static void Main(string[] args)
    {
        int timeOfDay = 21;
        var greeting = Greeting(timeOfDay);
        Console.WriteLine(greeting);
    }

    public static string Greeting(int timeOfDay)
    {
        string greeting;
        switch (timeOfDay)
        {
            case >= 0 and < 5:
                greeting = "Good evening!";
                break;
            case >= 5 and <= 12:
                greeting = "Good morning!";
                break;
            case > 12 and <= 18:
                greeting = "Good afternoon!";
                break;
            case > 18 and <= 24:
                greeting = "Good evening!";
                break;
            default:
                greeting = "Out of bound!";
                break;
        }
        return greeting;
    }
}

//throw an exception if more than 24 and less than 0 