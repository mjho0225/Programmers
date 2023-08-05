using System;
using System.Linq;

public class Solution {
    public long solution(long n) {
        char[] digits = n.ToString().ToCharArray();

        Array.Sort(digits, (a, b) => b.CompareTo(a));

        long answer = long.Parse(new string(digits));
        return answer;
    }
}