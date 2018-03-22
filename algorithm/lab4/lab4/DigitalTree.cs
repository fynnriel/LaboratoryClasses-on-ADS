using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class DigitalTree
    {
        Node root;

        public DigitalTree()
        {
            root = new Node('-', -1);
        }

        public void addWord(string word)
        {
            if (word.Length == 0)
                return;
            word = word.ToLower();

            root.addWord(word, 0);
        }

        public void printTree()
        {
            root.printAllNodes();
        }

        public bool isContains(string word)
        {
            if (word.Length == 0)
                return false;
            word = word.ToLower();
            return root.search(word);
        }
    }
}
