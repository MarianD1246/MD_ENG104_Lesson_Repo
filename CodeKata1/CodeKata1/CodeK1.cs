namespace CK1;

public class CodeK1 //Vowels in a sentance
{

    public static void Main(string[] args)
    {
        string userInput = Console.ReadLine();
        Console.WriteLine(VowelsInSentance(userInput));

    }

    public static int VowelsInSentance(string sentance)
    {
        string vowels = "aeiouy";
        int vowelCounter = 0;
        foreach (char c in sentance.ToLower())
        {
            foreach (char c2 in vowels)
            {
                if (c == c2) { vowelCounter++; break; }
            }
        }
        return vowelCounter;
    }
}