// 큐,   다리를 건너는 트럭 = .Enqueue() 
// 큐,   다리를 지난 트럭 =  .Dequeue()

// (조건) 총 몇대 올라갈 수 있는지 >> bridge_length
// (조건) 무게 이하까지 >> weight보다 작아야함 (weight >= )

// 0초에는 대기중
// 
// 일단, 대기중인 트럭 한대를 다리위에 올림 >> Enqueque , <+1초>
// 올라간 트럭 수 <= bridge_length(총 몇대) 파악 후 한대 더 위에 올릴 수 있는지(weight)
// 올릴 수 있으면 Enqueque, 추가로 올릴 수 있는지 파악
// 올릴 수 없으면 <+1초>, Dequeue
//
// 모두 Dequeue 되면 끝

using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int bridge_length, int weight, int[] truck_weights)
    {
        //일단 큐, 현재 다리위 트럭 담을 큐
        Queue<int> truck = new Queue<int>();
        // 경과 시간이 필요함
        int time = 0;
        //무게
        int sumWeight = 0;
        
        //
        for(int i = 0; i < truck_weights.Length ;)
        {
            
            //만약 현재 올라간 차 대수가 가능 대수보다 적으면
            if(truck.Count < bridge_length)
            {
                //만약 트럭의 무게 합이 제한무게보다 적으면
                //다음차도 올려
                if(sumWeight + truck_weights[i] <= weight)
                {
                    // 차 한대를 다리위에 올려
                    truck.Enqueue(truck_weights[i]);
                    sumWeight += truck_weights[i];
                    i++;
                }
                //트럭의 무게 합이 제한무게보다 크면
                else truck.Enqueue(0);
                
                time++;
            }
            
            else if(truck.Count >= bridge_length)
            {
                sumWeight -= truck.Dequeue();
                //time++;
            }
                
        }
        time += bridge_length;
        return time;
    }

}
