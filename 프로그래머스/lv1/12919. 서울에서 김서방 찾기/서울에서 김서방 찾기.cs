using System;
public class Solution {
    public string solution(string[] seoul) {
        for (int i = 0; i < seoul.Length; i++)
        {
            if (seoul[i] == "Kim")
            {
                return $"김서방은 {i}에 있다";
            }
        }

        // "Kim"을 찾지 못한 경우에는 예외 처리를 해야합니다.
        throw new ArgumentException("잘못된 값이 입력되었습니다. 배열에 \"Kim\"이 없습니다.");
    }
}