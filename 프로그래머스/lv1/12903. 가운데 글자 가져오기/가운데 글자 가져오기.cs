using System;

public class Solution {
    public string solution(string s) {
        int length = s.Length;
        int middleIndex = length / 2;

        if (length % 2 == 0)
        {
            return s.Substring(middleIndex - 1, 2);
        }
        else
        {
            return s.Substring(middleIndex, 1);
        }
    }
}