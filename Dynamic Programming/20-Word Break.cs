/*
Given a string s and a dictionary of strings wordDict, return true if s can be segmented into a space-separated sequence of one or more dictionary words.
Note that the same word in the dictionary may be reused multiple times in the segmentation.

Example 1:
Input: s = "leetcode", wordDict = ["leet","code"]
Output: true
Explanation: Return true because "leetcode" can be segmented as "leet code".

Example 2:
Input: s = "applepenapple", wordDict = ["apple","pen"]
Output: true
Explanation: Return true because "applepenapple" can be segmented as "apple pen apple".
Note that you are allowed to reuse a dictionary word.

Example 3:
Input: s = "catsandog", wordDict = ["cats","dog","sand","and","cat"]
Output: false
*/
using System;

namespace Dynamic_Programming;

public class SolutionXX{
    public bool WordBreak(string s, IList<string> wordDict) {
        bool[] dp = new bool[s.Length + 1]; 
        dp[0] = true; 
        HashSet<string> set = new HashSet<string>(wordDict); 
        for (int i = 1; i <= s.Length; i++) { 
            for (int j = 0; j < i; j++) { 
                string suffix = s.Substring(j, i - j); // Corrected this line 
                if (set.Contains(suffix) && dp[j] == true) { 
                    dp[i] = true; 
                    break; 
                } 
            } 
        } 
        return dp[s.Length];
    }
}
