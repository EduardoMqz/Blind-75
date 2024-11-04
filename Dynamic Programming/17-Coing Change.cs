/*
You are given an integer array coins representing coins of different denominations and an integer amount representing a total amount of money.
Return the fewest number of coins that you need to make up that amount. If that amount of money cannot be made up by any combination of the coins, return -1.
You may assume that you have an infinite number of each kind of coin.

Example 1:
Input: coins = [1,2,5], amount = 11
Output: 3
Explanation: 11 = 5 + 5 + 1

Example 2:
Input: coins = [2], amount = 3
Output: -1

Example 3:
Input: coins = [1], amount = 0
Output: 0
*/
using System;
using System.Numerics;

namespace Dynamic_Programming;

public class SolutionXVII{
    public int CoinChange(int[] coins, int amount) {
        int[] dp = new int[amount + 1];
        for(int i = 1; i <= amount; i++){
            int min = Int32.MaxValue;
            for(int j = 0; j < coins.Length; j++){
                if(i >= coins[j] && dp[i - coins[j]] != -1){
                    min = Math.Min(min, dp[i - coins[j]]);
                }
            }
            dp[i] = (min == Int32.MaxValue) ? -1 : 1 + min;
        }
        return dp[amount];
    }
}
