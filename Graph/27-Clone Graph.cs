/*
Given a reference of a node in a connected undirected graph.
Return a deep copy (clone) of the graph.
Each node in the graph contains a value (int) and a list (List[Node]) of its neighbors.

class Node {
    public int val;
    public List<Node> neighbors;
}

Test case format:
For simplicity, each node's value is the same as the node's index (1-indexed). For example, the first node with val == 1, 
the second node with val == 2, and so on. The graph is represented in the test case using an adjacency list.
An adjacency list is a collection of unordered lists used to represent a finite graph. Each list describes the set of neighbors of a node in the graph.
The given node will always be the first node with val = 1. You must return the copy of the given node as a reference to the cloned graph.
*/
using System;
using System.Reflection.Metadata;

namespace Graph;

public class SolutionXXX{
    public Node CloneGraph(Node node) {
        if(node == null) return null;
        Dictionary<Node, Node> map = new Dictionary<Node, Node>();
        Node newNode = new Node(node.val);
        map.Add(node, newNode);
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(node);
        while (queue.Count != 0){
            Node curr = queue.Dequeue();
            IList<Node> newNeigh = map[curr].neighbors;
            foreach(Node n in curr.neighbors){
                if(!map.ContainsKey(n)){
                    Node tmp = new Node(n.val);
                    map.Add(n, tmp);
                    queue.Enqueue(n);
                }
                newNeigh.Add(map[n]);
            }
        }
        return newNode;
    }
}

public class Node {
    public int val;
    public IList<Node> neighbors;
    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }
    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }
    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }

    public static implicit operator List<object>(Node v)
    {
        throw new NotImplementedException();
    }
}
