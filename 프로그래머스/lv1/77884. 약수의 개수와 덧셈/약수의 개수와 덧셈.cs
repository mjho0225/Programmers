using System;

public class Solution {
    public int solution(int left, int right) {
        int result = 0;
        
        for (int num = left; num <= right; num++) {
            int divisorCount = CountDivisors(num);
            
            if (divisorCount % 2 == 0) {
                result += num;
            } else {
                result -= num;
            }
        }
        
        return result;
    }
    
    private int CountDivisors(int num) {
        int count = 0;
        
        for (int i = 1; i <= num; i++) {
            if (num % i == 0) {
                count++;
            }
        }
        
        return count;
    }
}