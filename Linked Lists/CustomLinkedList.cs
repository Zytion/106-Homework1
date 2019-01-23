using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_Lists
{
	class CustomLinkedList<T>
	{
		//Number of Nodes in the list
		private int count;
		//Node at the start of the list
		private CustomNode<T> headNode;
		//Node at the end of the list
		private CustomNode<T> tailNode;
		
		/// <summary>
		/// The number of Nodes in the list
		/// </summary>
		public int Count {  get {  return count; } }

		/// <summary>
		/// Initalizes a new list by creating a new Node as the head
		/// </summary>
		/// <param name="data"></param>
		public CustomLinkedList(T data)
		{
			headNode = new CustomNode<T>(data, null, null);
			tailNode = headNode;
			count = 1;
		}
		/// <summary>
		/// Initalizes a new LinkedList using a premade Node as the head
		/// </summary>
		/// <param name="node"></param>
		public CustomLinkedList(CustomNode<T> node)
		{
			headNode = node;
			tailNode = node;
			count = 1;
		}
		/// <summary>
		/// Adds the data to a new Node and attaches that Node to the end of the list
		/// </summary>
		/// <param name="data"></param>
		public void Add(T data)
		{
			CustomNode<T> node = new CustomNode<T>(data, null, null);
			node.PreviousNode = tailNode;
			tailNode.NextNode = node;
			tailNode = node;
			count++;
		}
		/// <summary>
		/// Iterates trhough the Nodes to find the data at the given index
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public T GetData(int index)
		{
			CustomNode<T> currentNode = headNode;
			for(int i = 0; i < index; i++)
			{
				currentNode = currentNode.NextNode;
			}
			return currentNode.Data;
		}

		/// <summary>
		/// Insert a new Node object (with the specified data) at the specified index in the list.
		/// If the index is greater than or equal to the count of the list, add the new node to the end of the list.
		/// </summary>
		/// <param name="data"></param>
		/// <param name="index"></param>
		public void Insert(T data, int index)
		{
			if(index < 0)
				throw new IndexOutOfRangeException("Error: index cannot be less than 0");
			
			CustomNode<T> currentNode = headNode;
			
			if(index >= count)
			{
				Add(data);
				return;
			}
			else if(index > 0)
			{
				for(int i = 0; i < index; i++)
				{
					currentNode = currentNode.NextNode;
				}
			}

			CustomNode<T> insertNode = new CustomNode<T>(data, currentNode, null);

			if(currentNode.PreviousNode != null)
				currentNode.PreviousNode.NextNode = insertNode;

			currentNode.PreviousNode = insertNode;

			count++;
		}
	}
}
