using System;

public class Solution {
    public int solution(int n, int t) {
        int virus = n; 

        for (int i = 0; i < t; i++) {
            virus *= 2; 
        }

        return virus;
    }
}