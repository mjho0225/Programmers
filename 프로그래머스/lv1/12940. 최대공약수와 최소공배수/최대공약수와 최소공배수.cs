public class Solution {
    public int[] solution(int n, int m) {
        int gcd = GetGCD(n, m);
        int lcm = (n * m) / gcd;
        
        int[] answer = { gcd, lcm };
        return answer;
    }

    private int GetGCD(int a, int b) {
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}