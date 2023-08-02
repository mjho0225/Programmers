public class Solution {
    public bool solution(int x) {

        int sumOfDigits = 0;
        int originalX = x; 

        while (x > 0)
        {
            sumOfDigits += x % 10;
            x /= 10;
        }

        return originalX % sumOfDigits == 0;
    }
}