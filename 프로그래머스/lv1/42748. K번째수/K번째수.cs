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
            
            // 배열을 복사하여 자릅니다.
            Array.Copy(array, startIdx, subArray, 0, subArrayLength);

            Array.Sort(subArray);

            // k번째 숫자를 결과 배열에 저장합니다.
            answer[i] = subArray[k];
        }

        return answer;
    }
}