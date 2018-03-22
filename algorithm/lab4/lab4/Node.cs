using System;
using System.Collections.Generic;

namespace lab4
{
    class Node
    {
        public char data
        {
            get;
            private set;
        }
        private Dictionary<char, Node> dictionary;
        private int level;
        private bool endOfWord { get; set; }

        public Node(char data, int level)
        {
            endOfWord = false;
            this.data = data;
            this.level = level;
            dictionary = new Dictionary<char, Node>();
        }

        public void addWord(string word, int level)
        {
            Node node;
            if (word.Length == 1)
            {
                if (dictionary.TryGetValue(word[0], out node))
                {
                    node.endOfWord = true;
                    return;
                }
                else
                {
                    node = new Node(word[0], this.level + 1)
                    {
                        endOfWord = true
                    };
                    dictionary.Add(word[0], node);
                    return;
                }
            }

            if (!dictionary.TryGetValue(word[0], out node))
            {
                node = new Node(word[0], this.level + 1);
                dictionary.Add(word[0], node);
            }
            node.addWord(word.Substring(1), this.level + 1);
        }

        public bool search(string word)
        {
            if (word.Length == 1)
            {
                if (dictionary.ContainsKey(word[0]))
                    return true;
                return false;
            }
            if (dictionary.TryGetValue(word[0], out Node node))
            {
                return node.search(word.Substring(1));
            }
            return false;
        }

        public void printAllNodes()
        {
            printNode(0);
        }

        public void printNode(int level)
        {
            foreach (Node node in dictionary.Values)
            {
                Console.ForegroundColor = colors[node.level % colors.Length];
                for (int i = 0; i < level; i++)
                    Console.Write("-");
                Console.Write(node.data);
                if (node.endOfWord)
                    Console.Write("|");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;

                node.printNode(level + 1);
            }
        }

        private ConsoleColor[] colors = new ConsoleColor[] { ConsoleColor.Yellow, ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.Magenta };
    }
}
