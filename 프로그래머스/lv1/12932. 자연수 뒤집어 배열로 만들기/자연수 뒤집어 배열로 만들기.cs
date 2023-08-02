using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(long n) {

        string numberString = n.ToString();


        char[] charArray = numberString.ToCharArray();
        Array.Reverse(charArray);

 
        List<int> resultList = new List<int>();
        foreach (char c in charArray)
        {
            int digit = int.Parse(c.ToString());
            resultList.Add(digit);
        }

        return resultList.ToArray();
    }
}