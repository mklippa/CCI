using System;
using System.Collections.Generic;
using System.Linq;

namespace practice {
    public class Graph {
        public class Node<T> {
            public Node(T value)
            {
                Value = value;
            }
            public T Value { get; private set; }
            public IEnumerable<Node<T>> Children { get; set; }
        }
    }

    public partial class Program {
        private static Dictionary<string, string[]> _graph = new Dictionary<string, string[]>
        {
            ["you"] = new[] { "alice", "bob", "claire" },
            ["bob"] = new[] { "anuj", "peggy" },
            ["alice"] = new[] { "peggy" },
            ["claire"] = new[] { "thom", "jonny" },
            ["anuj"] = new string[0],
            ["peggy"] = new string[0],
            ["thom"] = new string[0],
            ["jonny"] = new string[0]
        };
        
        private static void DFS(Dictionary<string, string[]> graph)
        {
            var stack = new Stack<string>();
            stack.Push(graph.First().Key);
            var viewed = new HashSet<string>();
            while (stack.Length != 0)
            {
                var node = stack.Pop();
                if (viewed.Contains(node))
                    continue;
                viewed.Add(node);
                Console.WriteLine(node);
                foreach (var child in graph[node])
                    stack.Push(child);
            }
        }

        private static void BFS(Dictionary<string, string[]> graph)
        {
            var queue = new Queue<string>();
            queue.Enqueue(graph.First().Key);
            var viewed = new HashSet<string>();
            while (queue.Length != 0)
            {
                var node = queue.Dequeue();
                if (viewed.Contains(node))
                    continue;
                viewed.Add(node);
                Console.WriteLine(node);
                foreach (var child in graph[node])
                    queue.Enqueue(child);
            }
        }
    }
}