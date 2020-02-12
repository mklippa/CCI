using System;
using System.Linq;

namespace practice
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            var trie = new Trie();
            var word = "banana".ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                trie.Insert(word.Skip(i).ToArray());
            }
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(trie.Contains(word.Skip(i).ToArray()));
            }
            Console.WriteLine(trie.Contains("band".ToCharArray()));
        }
    }
}
