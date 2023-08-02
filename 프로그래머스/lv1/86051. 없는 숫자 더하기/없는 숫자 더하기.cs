using System;

public class Solution {
    public int solution(int[] numbers) {
    int answer = 0;
    bool[] found = new bool[10];

    for (int i = 0; i < numbers.Length; i++)
    {
        int num = numbers[i];
        found[num] = true;
    }

    for (int i = 0; i < 10; i++)
    {
        if (!found[i])
        {
            answer += i;
        }
    }

    return answer;
    }
}