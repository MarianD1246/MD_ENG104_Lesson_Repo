
namespace CK1;

public class CodeK4
{
    public static string DuplicationInSentance(string sentance)
    {
        string sen = sentance;
        string dups = "";
        string check = "";
        foreach (char c in sentance.ToLower())
        {
            foreach (char c2 in check) 
            {
                if (c == c2 && !dups.Contains(c)) { dups += c; break; }
            }
            check += c;
        }
        return  dups ;
    }

}

