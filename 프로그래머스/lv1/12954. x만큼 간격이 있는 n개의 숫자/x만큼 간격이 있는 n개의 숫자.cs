using System;
using System.Collections.Generic;

public class Solution {
    public long[] solution(int x, int n) {
        long[] answer = new long[n];
        long currentNumber = x;
        
        for (int i = 0; i < n; i++) {
            answer[i] = currentNumber;
            currentNumber += x;
        }
        
        return answer;
    }
}