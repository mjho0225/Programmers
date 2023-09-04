using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];

        for (int i = 0; i < commands.GetLength(0); i++) {
            int startIdx = commands[i, 0] - 1;
            int endIdx = commands[i, 1] - 1;
            int k = commands[i, 2] - 1;

            int subArrayLength = endIdx - startIdx + 1;
            int[] subArray = new int[subArrayLength];
            
            Array.Copy(array, startIdx, subArray, 0, subArrayLength);

            Array.Sort(subArray);

            answer[i] = subArray[k];
        }

        return answer;
    }
}