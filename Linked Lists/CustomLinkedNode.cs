using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_Lists
{
	class CustomNode<T>
	{
		/// <summary>
		/// The data stored in this node
		/// </summary>
		public T Data { get; set;}
		/// <summary>
		/// The next node in the list
		/// </summary>
		public CustomNode<T> NextNode { get; set; }
		/// <summary>
		/// The previous node in the list
		/// </summary>
		public CustomNode<T> PreviousNode { get; set; }

		/// <summary>
		/// Creates a new Node with a stored data (of type T).
		/// Stores the previous and next Node pointers
		/// </summary>
		/// <param name="data"></param>
		/// <param name="nextNode"></param>
		/// <param name="previousNode"></param>
		public CustomNode(T data, CustomNode<T> nextNode, CustomNode<T> previousNode)
		{
			Data = data;
			NextNode = nextNode;
			PreviousNode = previousNode;
		}

	}
}
