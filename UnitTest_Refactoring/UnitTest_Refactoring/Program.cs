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
        if (timeOfDay >= 5 && timeOfDay <= 12)
        {
            greeting = "Good morning!";
        }
        else if (timeOfDay > 12 && timeOfDay <= 18)
        {
            greeting = "Good afternoon!";
        }
        else if (timeOfDay > 18 && timeOfDay <= 24)
        {
            greeting = "Good evening!";
        }
        else if (timeOfDay >= 0 && timeOfDay < 5)
        {
            greeting = "Good evening!";
        }
        else
        {
            greeting = "Out of bound!";
        }
        return greeting;
    }
}

//throw an exception if more than 24 and less than 0 