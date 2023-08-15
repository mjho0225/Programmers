// 앞의 가격 < 뒤의 가격

//1초 가격 1, 끝까지 가격 안떨굼 >> 4
//2초 가격 2, 끝까지 가격 안떨굼 >> 3
//3초 가격 3, 1초 후 가격이 2로 떨굼 >> 1
//4초 가격 2, >> 1 (떨궈도 1, 안떨궈도 1)
//5초 가격 3, >> 0


using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] prices) {
        int n = prices.Length;
        int[] result = new int[n];
        Stack<int> stock = new Stack<int>();
        
        for (int i = 0; i < n; i++)
        {
            while (stock.Count > 0 && prices[i] < prices[stock.Peek()])
            {
                int prevIndex = stock.Pop();
                result[prevIndex] = i - prevIndex;
            }
            stock.Push(i);
        }

        while (stock.Count > 0)
        {
            int prevIndex = stock.Pop();
            result[prevIndex] = n - 1 - prevIndex;
        }

        return result;
    }
}