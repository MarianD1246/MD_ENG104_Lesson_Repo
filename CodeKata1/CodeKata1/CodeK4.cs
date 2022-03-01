namespace CK1;

public class CodeK4
{
    public static string DuplicationInSentance(string sentance)
    {
        string dups = "";
        string check = "";
        foreach (char c in sentance.ToLower())
        {
            if (check.Contains(c) && !dups.Contains(c)) 
                dups += c;
            
            check += c;
        }
        return dups;
    }   
}