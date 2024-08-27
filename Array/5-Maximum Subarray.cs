/*
Given an integer array nums, find the subarray with the largest sum, and return its sum.

Example 1:
Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
Output: 6
Explanation: The subarray [4,-1,2,1] has the largest sum 6.

Example 2:
Input: nums = [1]
Output: 1
Explanation: The subarray [1] has the largest sum 1.

Example 3:
Input: nums = [5,4,-1,7,8]
Output: 23
Explanation: The subarray [5,4,-1,7,8] has the largest sum 23.
*/
using System;
using System.Reflection.Metadata.Ecma335;
namespace Array;

public class SolutionV{
    public int maximumArray(int[] nums){
        int curr = nums[0];
        int max = nums[0];
        for (int i = 1; i < nums.Length; i++){
            curr = Math.Max(nums[i],nums[i]+curr);
            max = Math.Max(max,curr);
        }
        return max;
    }
}
