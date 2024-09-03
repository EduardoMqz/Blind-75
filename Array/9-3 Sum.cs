/*
Given an integer array nums, return all the triplets [nums[i], nums[j], 
    nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
Notice that the solution set must not contain duplicate triplets.

Example 1:
Input: nums = [-1,0,1,2,-1,-4]
Output: [[-1,-1,2],[-1,0,1]]
Explanation: 
nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
The distinct triplets are [-1,0,1] and [-1,-1,2].
Notice that the order of the output and the order of the triplets does not matter.

Example 2:
Input: nums = [0,1,1]
Output: []
Explanation: The only possible triplet does not sum up to 0.

Example 3:
Input: nums = [0,0,0]
Output: [[0,0,0]]
Explanation: The only possible triplet sums up to 0.
*/
using System;
using System.Collections;

public class SolutionIX{
    public IList<IList<int>> threeSum(int[] nums){
        Array.Sort(nums);
        IList<IList<int>> triplets = new List<IList<int>>();
        for (int i = 0; i <= nums.Length-3; i++){
            if (i == 0 || nums[i] != nums[i-1]){
                int left = i+1, right = nums.Length-1;
                int target = 0-nums[i];
                while(left<right){
                    if(nums[left] + nums[right] == target){
                        List<int> triplet = new List<int>();
                        triplet.Add(nums[i]);
                        triplet.Add(nums[left]);
                        triplet.Add(nums[right]);
                        triplets.Add(triplet);
                        while(left < nums.Length-1 && nums[left] == nums[left+1]){
                            left++;
                        }
                        while(right > 0 && nums[right] == nums[right-1]){
                            right--;
                        }
                        left++;
                        right--;
                    }else if (nums[left]+nums[right]<target){
                        left++;
                    }else{
                        right--;
                    }
                }
                
            }
            
        }
        return triplets;
    }

}