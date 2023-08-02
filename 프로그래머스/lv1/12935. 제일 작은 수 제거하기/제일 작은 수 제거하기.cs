using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
    {
        if (arr.Length == 1)
            return new int[] { -1 };

        int minIndex = Array.IndexOf(arr, arr.Min());

        return arr.Where((value, index) => index != minIndex).ToArray();
    }
}
}