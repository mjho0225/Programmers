using System;
using static System.Math;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        //double sqrt = Math.Sqrt(n);
        //만약, 제곱수라면 answer = 1
        //if(sqrt % 1 == 0)
        //{
        //    answer = 1;
        //}
        //else
        //{
        //    answer = 2;    
        //}
        //return answer;
        for(int i = 1; i<= n ; i++)
        {
            if(i*i == n)
            {
                return answer = 1;
            }
            else if(i*i > n)
            {
                break;
            } 
        }
        return answer = 2;
    }
}