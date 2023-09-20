using System;

public class Solution {
    public int solution(int[] num_list) {
        int product = 1; // 원소들의 곱을 저장할 변수 초기화
        int sum = 0; // 원소들의 합을 저장할 변수 초기화

        // 배열의 각 원소에 대해 원소들의 곱과 원소들의 합을 계산
        foreach (int num in num_list) {
            product *= num; // 원소들의 곱 계산
            sum += num;     // 원소들의 합 계산
        }

        // 모든 원소들의 곱이 모든 원소들의 합의 제곱보다 작으면 1을 반환, 그렇지 않으면 0을 반환
        if (product < sum * sum) {
            return 1;
        } else {
            return 0;
        }
    }
}