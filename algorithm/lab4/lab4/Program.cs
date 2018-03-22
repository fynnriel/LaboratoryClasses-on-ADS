using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalTree tree = new DigitalTree();
            
            tree.addWord("Cat");
            tree.addWord("catS");
            tree.addWord("call");
            tree.addWord("crate");
            tree.addWord("compare");
            tree.addWord("art");
            tree.addWord("artist");

            tree.printTree();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add word\n2.Print tree\n3.Search word\n4.Exit");
                string input = Console.ReadLine();
                if (input == "4")
                {
                    break;
                }
                else if(input == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Input word:");
                    string word = Console.ReadLine();
                    tree.addWord(word);
                }
                else if (input == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Tree:\n------------------");
                    tree.printTree();
                    Console.Write("Press any key to return to menu...");
                    Console.ReadKey();
                }
                else if (input == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Input word to search:");
                    string word = Console.ReadLine();
                    Console.Write("Word ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(word);
                    Console.Write(": ");
                    if (tree.isContains(word))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("found");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("not found");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Press any key to return to menu...");
                    Console.ReadKey();
                }
            }
        }
    }
}
