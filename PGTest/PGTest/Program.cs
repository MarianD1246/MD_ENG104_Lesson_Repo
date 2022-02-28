
namespace CodeToTestPG;

public class Program
{

    public static void Main(string[] args)
    {
        int age = 0;
        Console.WriteLine(AvailableClassifications(age));
    }


    public static string AvailableClassifications(int ageOfViewer)
    {
        string result;
        switch (ageOfViewer)
        {
            case >= 0 and < 12:
                result = "U, PG are available.";
                break;
            case >= 12 and < 15:
                result = "U, PG &12 films are available.";
                break;
            case >= 15 and < 18:
                result = "U, PG, 12 & 15 films are available.";
                break;
            case > 18:
                result = "All films are available.";
                break;
            default:
                result = "Invalid age.";
                break;
        }
        return result;
    }
}