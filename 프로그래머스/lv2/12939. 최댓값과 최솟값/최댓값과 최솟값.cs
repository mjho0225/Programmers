using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        string[] numbers = s.Split(' ');

        int[] intArray = Array.ConvertAll(numbers, int.Parse);

        int min = intArray.Min();
        int max = intArray.Max();

        return $"{min} {max}";
    }
}
