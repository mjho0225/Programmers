public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int rows = arr1.GetLength(0); // 행의 개수
        int cols = arr1.GetLength(1); // 열의 개수
        int[,] answer = new int[rows, cols]; // 결과 행렬 초기화

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                answer[i, j] = arr1[i, j] + arr2[i, j]; // 각 요소 더하기
            }
        }

        return answer;
    }
}