using System;
using System.Linq;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        int[] board = new int[1004];
        for (int i = 0; i < array.Length; i++)
        {
            board[array[i]]++;
        }
        int maxCount = board.Max();
        bool flag = false;
        for (int i = 0; i < board.Length; i++)
        {
            if (board[i] == maxCount && flag)
            {
                answer = -1;
                break;
            }
            if (board[i] == maxCount)
            {
                flag = true;
                answer = i;
            }
        }
        return answer;
    }
}