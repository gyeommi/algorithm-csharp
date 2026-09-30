using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int pv = 0;
        while(n > pv)
        {
            pv += 7;
            answer++;
        }
        return answer;
    }
}