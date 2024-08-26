/*
Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
You must write an algorithm that runs in O(n) time and without using the division operation.

Example 1:
Input: nums = [1,2,3,4]
Output: [24,12,8,6]

Example 2:
Input: nums = [-1,1,0,-3,3]
Output: [0,0,9,0,0]
*/
using System;
namespace Array;

public class SolutionIV{
    public int[] productArray(int[] nums){
        int[] prefix = new int[nums.Length];
        prefix[0] = 1;
        for (int i = 1; i < nums.Length; i++){
            prefix[i] = prefix[i-1] * nums[i-1];
        }
        int sufix = 1;
        for (int i = nums.Length-1; i >=0; i--){
            prefix[i] =prefix[i]*sufix;
            sufix = sufix*nums[i];
        }
        return prefix;
    }
}
