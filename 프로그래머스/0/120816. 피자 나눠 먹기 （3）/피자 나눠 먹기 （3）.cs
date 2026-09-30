using System;

public class Solution {
    public int solution(int slice, int n) {
        int answer = 0;
        int pv = 0;
        
        while (n > pv)
        {
            pv += slice;
            answer++;
        }
        return answer;
    }
}