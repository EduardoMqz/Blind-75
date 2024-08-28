/*Given an integer array nums, find a subarray that has the largest product, and return the product.
The test cases are generated so that the answer will fit in a 32-bit integer.

Example 1:
Input: nums = [2,3,-2,4]
Output: 6
Explanation: [2,3] has the largest product 6.

Example 2:
Input: nums = [-2,0,-1]
Output: 0
Explanation: The result cannot be 2, because [-2,-1] is not a subarray.
*/
using System;
namespace Array;

public class SolutionVI{
    public int maximumProductArray(int[] nums){
        int ans = nums[0],
            min = 1,
            max = 1;
        for (int i = 0; i < nums.Length; i++){
            if (nums[i] == 0){
                min = 1;
                max = 1;
                ans = Math.Max(ans,nums[i]);
                continue;
            }
            int temp = min;
            min = Math.Min(nums[i], Math.Min(nums[i] * min, nums[i] * max));
            max = Math.Max(nums[i], Math.Max(nums[i] * temp, nums[i] * max));
            ans = Math.Max(ans,max);  
        }
        return ans;
    }

}
