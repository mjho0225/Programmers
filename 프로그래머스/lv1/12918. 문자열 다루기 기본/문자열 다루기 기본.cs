using System;

public class Solution {
    public bool solution(string s) {

        if (s.Length != 4 && s.Length != 6)
            return false;

        foreach (char c in s)
        {
            if (!Char.IsDigit(c))
                return false;
        }

        return true;
    }
}