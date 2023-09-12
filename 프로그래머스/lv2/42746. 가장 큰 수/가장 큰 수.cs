using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(int[] numbers) {
        // 정수를 문자열로 변환하여 비교하도록 정렬
        List<string> numStrList = numbers.Select(num => num.ToString()).ToList();
        
        // 정렬 기준을 재정의하여 내림차순 정렬
        numStrList.Sort((a, b) => (b + a).CompareTo(a + b));
        
        // 정렬된 문자열을 이어붙여 결과 문자열 생성
        string answer = string.Join("", numStrList);
        
        // 만약 결과가 "0"으로 시작한다면 모든 숫자가 0인 경우이므로 "0"을 반환
        if (answer[0] == '0') {
            return "0";
        }
        
        return answer;
    }
}