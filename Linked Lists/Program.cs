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
			CustomLinkedList<string> customLinkedList = new CustomLinkedList<string>("Start");
			customLinkedList.Add("First");
			customLinkedList.Add("Second");
			customLinkedList.Add("Third");
			customLinkedList.Add("Fourth");
			customLinkedList.Add("Fifth");

			Console.WriteLine(customLinkedList.Count);
			
			for(int i = 0; i < customLinkedList.Count; i++)
				Console.WriteLine(customLinkedList.GetData(i));
			
			Console.ReadLine();
		}
	}
}
