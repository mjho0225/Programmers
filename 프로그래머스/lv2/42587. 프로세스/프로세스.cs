using System;
using System.Collections.Generic;


// A(2) B(1) C(3) D(2)

//  (A)  C D B
//  (A)  D B C     
//  (A)  B C D A , location 1, answer 0,

// B(1) C(3) D(2) A(2) 

//   (B)    D A C 
//   (B)    A C D
//   (B)    C D A B ---true On, loaction 0, answer 0, 
//    (C)      A B D
//    (C)       B D A
//    (C)       C D A B , answer 1, 

// C(3) D(2) A(2) B(1)
// 실행

// A(1) B(1) C(9) D(1) E(1) F(1)

//   (A) C D E F B
//   (A) D E F B C   -- true ON
//   (A) E F B C D
//   (A) F B C D E
//   (A) B C D E F,  location -1, >> location = 5;

// B(1) C(9) D(1) E(1) F(1) A(1)

// (B) D E F A C  -- ture ON
// (B) E F A C D
// (B) F A C D E
// (B) A C D E F
// (B) C D E F A B , location 4

// C(9) D(1) E(1) F(1) A(1) B(1)  -- false

// (C) E F A B D 
// (C) F A B D E
// (C) A B D E F
// (C) B D E F A
// (C) D E F A B , answer 1 , location 3

// (D) F A B E ,
// (D) A B E F ,
// (D) B E F A , 
// (D) E F A B , answer 2, location 2

// (E) A B F,
// (E) B F A,
// (E) F A B, answer 3, location 1

// (F) B A,
// (F) A B, answer 4, location 0

// (A) B, answer 5

// 실행

// queue.Enqueue (추가) | queue.Dequeue (제거)

// 1) 큐 입력값 추가
// 2) 큐 입력값 중 높은 우선순위 파악
// 3) 기존 큐 입력값에서 location가 몇번째에서 실행하는지 파악

public class Solution {
    public int solution(int[] priorities, int location) {
        int answer = 0;
        //1. 큐 입력값 추가
        Queue<int> queue = new Queue<int>(priorities);
        
        
        
        while (queue.Count > 0) 
        {
            // 현재 큐 2, 현재 큐 1,
            int currentPriority = queue.Dequeue();
            // 2. 우선 순위가 높은 큐가 남아있는지 여부 파악
            bool fastProcess = false;
            // 3. 일단, 우선순위가 높은 친구를 찾아야함
            
            for (int i = 0; i < queue.Count; i++)
            {
                // 다음 큐 1, 다음 큐 3
                int priority = queue.Dequeue();
                // 만약 다음큐가 현재 큐 비교해서 숫자 높으면 우선순위 높음
                if (priority > currentPriority) {
                    fastProcess = true;
                    
                }
                // 우선순위가 낮을 경우 다시 큐 2 추가, 1추가
                queue.Enqueue(priority);
            }
            
            // 만약, 우선순위 여부 확인됬을 때 (3)
            if (fastProcess == true) 
            {
                // 현재 뽑았던 큐 1 추가
                queue.Enqueue(currentPriority);
            } 
            // 위치값에 따른 return값 구하기
            // 우선순위가 아닐때는 
            else
            {
                
                answer++;
                // 3-1) 로케이션 0이 되었으면 완료 처리
                if (location == 0) 
                {
                    break;
                }
            }
            // 3) 로케이션 1,
            location--;
            
            //만약, 0 이하가 되면 위치를 큐의 맨 뒤로
            if (location < 0) {
                location = queue.Count - 1;
            }
        }

        return answer;
    }
}