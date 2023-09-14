using System;

public class Solution {
    public int solution(int[,] sizes) {
        int maxHorizontal = 0;
        int maxVertical = 0;

        for (int i = 0; i < sizes.GetLength(0); i++) {
            int width = sizes[i, 0];
            int height = sizes[i, 1];

            maxHorizontal = Math.Max(maxHorizontal, Math.Max(width, height));
            maxVertical = Math.Max(maxVertical, Math.Min(width, height));
        }

        int minWalletSize = maxHorizontal * maxVertical;
        return minWalletSize;
    }
}