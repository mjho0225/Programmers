using System;

public class Solution {
    public int solution(int n) {
        //int answer = 1;

            //for(int x = 1 ; x < n; x++)
            //{
            //    for(int i = x ; x < n ; i++)
            //    {
            //        if((i^x)>n)
            //       {
             //           
            //            answer = x;
            //            break;
            //        }  
             //   }   
            //}

        //return answer;
        int answer = 1;

        while (n % answer != 1) {
            answer++;
        }

        return answer;
    
    }
}