using System;
using System.Collections.Generic;

        //경우의 수
        //붙어 있는 경우 : 01, 0101, 010101
        //감싸고 있는 경우 : 0011, 000111,
        //복합 : 001101, 00011011
        //>> 스택/큐 >> 0이 n개 들어갔으면 무조건 1이n개 들어가야한다.
        // 0("(")은 무조건 첫번째로 들어가야한다.
        // 1(")")은 무조건 마지막에 들어가야한다.

public class Solution {
    public bool solution(string s) {
        

        Stack<char> stack = new Stack<char>();
        char a = '(';
        //char b = ')';
        
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            
            if (c == a)
            {
                stack.Push(c);
            }
            // 만약 b가 나오면
            else
            {
                if (stack.Count > 0)
                {
                    //a 제거
                    stack.Pop();
                }
                // 그 외 
                else
                {
                    return false; 
                }
            }
        }
        
        // 개수가 짝수가 아니면 거짓
        if(stack.Count == 1){
            return false;
        }
        // 개수가 짝수가 아니면 거짓
        //if (s.Length % 2 != 0)
        //{
        //    return false;
        //}
      
        return stack.Count == 0; 
    }
}