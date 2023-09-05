using System;
using static System.Math;

public class Solution {
    public long solution(long n) {
        if (n <= 0) {
            return -1;
        }
        
        long x = (long)Math.Sqrt(n);
        
        if (x * x == n) {
            return (x + 1) * (x + 1);
        } else {
            return -1;
        }
    }
}