/*
There are a total of numCourses courses you have to take, labeled from 0 to numCourses - 
1. You are given an array prerequisites where prerequisites[i] = [ai, bi] indicates that you must take course bi first if you want to take course ai.
For example, the pair [0, 1], indicates that to take course 0 you have to first take course 1.
Return true if you can finish all courses. Otherwise, return false.

Example 1:
Input: numCourses = 2, prerequisites = [[1,0]]
Output: true
Explanation: There are a total of 2 courses to take. 
To take course 1 you should have finished course 0. So it is possible.

Example 2:
Input: numCourses = 2, prerequisites = [[1,0],[0,1]]
Output: false
Explanation: There are a total of 2 courses to take. 
To take course 1 you should have finished course 0, and to take course 0 you should also have finished course 1. So it is impossible.
*/
using System;
using System.Collections;

namespace Graph;

public class SolutionXXVIII{
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        List<List<int>> adj = new List<List<int>>();
        int enrolled = 0;
        Queue<int> queue = new Queue<int>();

        for(int i = 0; i < numCourses; i++){
            adj.Add(new List<int>());
        }

        foreach(int[] edge in prerequisites){
            adj[edge[1]].Add(edge[0]);
        }

        int[] indegree = new int[numCourses];
        foreach(int[] edge in prerequisites){
            indegree[edge[0]]++;
        }

        
        for(int node = 0; node < indegree.Length; node++){
            if(indegree[node] == 0){
                queue.Enqueue(node);
                enrolled++;
            }
        }

        while(queue.Count != 0){
            int currNode = queue.Dequeue();//current course
            foreach(int neigh in adj[currNode]){
                indegree[neigh]--;
                if(indegree[neigh] == 0){
                    queue.Enqueue(neigh);
                    enrolled++;
                }
            }
        }

        return numCourses == enrolled;
        
    }

}

