using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK1;

public class CodeK6
{
    public static int ClosestToZero(int[] numArr)
    {
        if (numArr.Length == 0 || numArr == null)
            throw new NullReferenceException("Array can't be empty!");
        if (numArr.Length == 1)
            return numArr[0];
            
        int closest = numArr[0];
        int closestAbs = Math.Abs(numArr[0]);
        for (int i = 1; i < numArr.Count(); i++)
        {
            int compare = Math.Abs(numArr[i]);
            if (closestAbs > compare)
            {
                closestAbs = compare;
                closest = numArr[i];
            }
        }
        return closest;
    }

}

