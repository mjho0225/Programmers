using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        var divisibleValues = arr.Where(x => x % divisor == 0).ToArray();

        if (divisibleValues.Length == 0)
            return new int[] { -1 };

        Array.Sort(divisibleValues);
        return divisibleValues;
    }
}