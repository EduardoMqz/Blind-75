/*
Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

Example 1:
Input: nums = [1,2,3,1]
Output: true

Example 2:
Input: nums = [1,2,3,4]
Output: false

Example 3:
Input: nums = [1,1,1,3,3,4,3,2,4,2]
Output: true
*/
using System;
using System.Collections;
using System.Numerics;

public class SolutionIII{
    public bool containsDuplicate(int[] nums){
        var visited = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++){
            if(visited.Contains(nums[i])){
                return true;
            }else{
                visited.Add(nums[i]);
            }   
        }
        return false;
    }
}
