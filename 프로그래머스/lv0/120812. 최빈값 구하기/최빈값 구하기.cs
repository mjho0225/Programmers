using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] array) {
        Dictionary<int, int> frequency = new Dictionary<int, int>();

        foreach (int num in array) {
            if (frequency.ContainsKey(num)) {
                frequency[num]++;
            } else {
                frequency[num] = 1;
            }
        }

        int maxFrequency = 0;
        int mode = -1;

        foreach (var kvp in frequency) {
            if (kvp.Value > maxFrequency) {
                maxFrequency = kvp.Value;
                mode = kvp.Key;
            } else if (kvp.Value == maxFrequency) {

                mode = -1;
            }
        }

        return mode;
    
    }
}