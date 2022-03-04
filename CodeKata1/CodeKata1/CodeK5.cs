namespace CK1;

public class CodeK5
{
    public static int ReturnSecondHighestNumber(int[] numArray)
    {
        if (numArray.Length == 0)
            throw new ArgumentException("The array is empty!");
        if (numArray.Length == 1)
            throw new ArgumentException("The array should have at least 2 items!");

        int bigNum = int.MinValue;
        int secNum = numArray[0] > numArray[1] ? numArray[1] : numArray[0] ;
        foreach (int num in numArray)
        {
            if (bigNum < num)
                bigNum = num;
        }
        foreach(int num in numArray)
        {
            if (num != bigNum && secNum < num)
                secNum = num;
        }
        

        return secNum;
    }
}