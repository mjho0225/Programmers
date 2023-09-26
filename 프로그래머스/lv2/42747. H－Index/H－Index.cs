using System;
using System.Linq;

public class Solution {
    public int solution(int[] citations)
    {
    Array.Sort(citations, CompareCitations);

        for (int i = 0; i < citations.Length; i++)
        {
            if (citations[i] <= i)
            {
                return i;
            }
        }

        return citations.Length;
    }

    private int CompareCitations(int a, int b)
    {
        return b - a;
    }
}