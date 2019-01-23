using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_Lists
{
	class Program
	{
		static void Main(string[] args)
		{
			CustomLinkedList<string> customLinkedList = new CustomLinkedList<string>();
            customLinkedList.Add("Hello");
            customLinkedList.Add("There");
            customLinkedList.Add("General");
            customLinkedList.Add("Kenobi");

            bool running = true;
            Random rnd = new Random();
            int index;
            string input;

            while (running)
            {
                Console.Write("Comands are quit, print, count, clear, remove, reverse, and scramble.\n" +
                    "Type a word to add it to the list\n" +
                    "Type input here: ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "quit":
                        running = false;
                        break;
                    case "print":
                        Console.WriteLine("The following items are currently in the list:");
                        for (int i = 0; i < customLinkedList.Count; i++)
                            Console.WriteLine(customLinkedList[i]);
                        break;
                    case "count":
                        Console.WriteLine(customLinkedList.Count + " items in the Linked List");
                        break;
                    case "clear":
                        customLinkedList.Clear();
                        break;
                    case "remove":
                        index = rnd.Next(customLinkedList.Count);
                        Console.WriteLine("Removed \"" + customLinkedList.RemoveAt(index) + "\" from the list");
                        break;
                    case "reverse":
                        Console.WriteLine("The following items are in the list (in reverse order):");
                        customLinkedList.PrintReversed();
                        break;
                    case "scramble":
                        index = rnd.Next(customLinkedList.Count);
                        string data = customLinkedList.RemoveAt(index);

                        index = rnd.Next(customLinkedList.Count);
                        customLinkedList.Insert(data, index);
                        Console.WriteLine("A random element has been moved to a new position");
                        break;
                    case "":
                        Console.WriteLine("Please enter something");
                        break;
                    default:
                        customLinkedList.Add(input);
                        Console.WriteLine("\"" + input + "\" has been added to the list");
                        break;
                }
                Console.WriteLine("");
                
            }
		}
	}
}
