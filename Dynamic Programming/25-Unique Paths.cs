/*
There is a robot on an m x n grid. The robot is initially located at the top-left corner (i.e., grid[0][0]). The robot tries to move to the bottom-right corner (i.e., grid[m - 1][n - 1]). 
The robot can only move either down or right at any point in time.
Given the two integers m and n, return the number of possible unique paths that the robot can take to reach the bottom-right corner.
The test cases are generated so that the answer will be less than or equal to 2 * 109.

Example 1:
Input: m = 3, n = 7
Output: 28

Example 2:
Input: m = 3, n = 2
Output: 3

Explanation: From the top-left corner, there are a total of 3 ways to reach the bottom-right corner:
1. Right -> Down -> Down
2. Down -> Down -> Right
3. Down -> Right -> Down
*/
using System;

namespace Dynamic_Programming;

public class _25_Unique_Paths{
    public int UniquePaths(int m, int n) {
        int[,] dp = new int[m,n];
        dp[0,0] = 1;
        for(int i = 0; i < dp.GetLength(1); i++){
            dp[0,i] =1;
        }
        for(int i = 0; i < dp.GetLength(0); i++){
            dp[i,0] = 1;
        }

        for(int r = 1; r < dp.GetLength(0); r++){
            for(int c = 1; c < dp.GetLength(1); c++){
                int top = dp[r - 1, c];
                int left = dp[r, c - 1];
                dp[r,c] = top + left;
            }
        }
        return dp[m - 1, n - 1];
    }
}
