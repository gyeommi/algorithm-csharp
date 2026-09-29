using System;
using System.Linq;

public class Solution {
    public int solution(int[] array) {
        int[] count = new int[1001];

        for (int i = 0; i < array.Length; i++)
            count[array[i]]++;

        int max = count.Max();
        int answer = -1;
        int maxCount = 0;

        for (int i = 0; i < count.Length; i++)
        {
            if (count[i] == max)
            {
                answer = i;
                maxCount++;
            }
        }

        if (maxCount > 1)
            return -1;

        return answer;
    }
}