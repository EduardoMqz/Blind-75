/*
Given an integer array nums, return the length of the longest strictly increasing 
subsequence.

Example 1:
Input: nums = [10,9,2,5,3,7,101,18]
Output: 4
Explanation: The longest increasing subsequence is [2,3,7,101], therefore the length is 4.

Example 2:
Input: nums = [0,1,0,3,2,3]
Output: 4

Example 3:
Input: nums = [7,7,7,7,7,7,7]
Output: 1
*/
using System;
using System.Runtime.InteropServices;

namespace Dynamic_Programming;

public class SolutionXVIII{
    public int LengthOfList(int[] nums) {
        int len = nums.Length;
        if(len == 1) return 1;
        int[] dp = new int[len];
        dp[0] = 1;
        int ans = 0;
        for (int i = 1; i < len; i++){
            int size = 0;
            for (int j = 0; j < i; j++){
                if(nums[j] < nums[i]){
                    size = Math.Max(size, dp[j]);
                } 
            }
            dp[i] = 1 + size;
            ans = Math.Max(ans, dp[i]);
        }
        return ans;
    }
}
