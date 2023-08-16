using System;

public class Solution {
    public string solution(string my_string, string letter) {
                string answer = "";

        foreach (char c in my_string)
        {
            if (!letter.Contains(c.ToString()))
            {
                answer += c;
            }
        }

        return answer;
    }
}