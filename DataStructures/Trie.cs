using System;

namespace practice
{
    public class Trie
    {
        private const int length = 26;
        private class Node
        {
            public bool Termination { get; set; }
            private Node[] Children { get; set; } = new Node[length];
            public Node this[char letter]
            {
                get => Children[letter - 'a'];
                set => Children[letter - 'a'] = value;
            }
        }

        private readonly Node root = new Node();
        public void Insert(char[] word)
        {
            var node = root;
            var last = word.Length - 1;
            for (int i = 0; i < word.Length; i++)
            {
                var letter = word[i];
                if (node[letter] is null)
                    node[letter] = new Node();
                node[letter].Termination = (i == last);
                node = node[letter];
            }
        }

        public void Remove(char[] word) {
            
        }

        public bool Contains(char[] word) {
            var node = root;
            var last = word.Length - 1;
            for (int i = 0; i < word.Length; i++)
            {
                var letter = word[i];
                if (node[letter] is null)
                    return false;
                if (i == last && !node[letter].Termination)
                    return false;
            }
            return true;
        }
    }
}