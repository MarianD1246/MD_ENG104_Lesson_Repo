namespace CK1;

public class CodeK5
{
    public static int ReturnHighestNumber(int[] numArray)
    {
        if (numArray.Length == 0)
            throw new ArgumentNullException("The array is empty!");

        int bigNum = int.MinValue;
        foreach (int num in numArray)
        {
            if (bigNum < num)
                bigNum = num;
        }
        return bigNum;
    }
}