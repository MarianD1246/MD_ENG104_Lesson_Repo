namespace CK1;

public class CodeK2 //given a number of days = output them in week/s + day/s
{
    public static string DaysAsWeeksAndDays(int nrOfDays)
    {
        if (nrOfDays < 0) { return "0 weeks and 0 days"; }
        decimal x = nrOfDays / 7;
        string weeks = "weeks", days = "days";
        if (x == 1) weeks = "week";
        if (nrOfDays % 7 == 1) days = "day";

        return $"{Math.Floor(x)} {weeks} and {nrOfDays % 7} {days}";
    }
}