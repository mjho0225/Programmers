using System;
using System.Linq;

public class Solution {
    public int solution(int[] array, int n) {
        int count = array.Count(item => item == n);
        return count;
        
    }
}