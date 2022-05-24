using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textapp
{
    public class Stack: IStack
    {
        private Node Top;
        public int count = 0;

        public Stack()
        {
            Top = null;

        }
        public Node GetNode(object data)
        {
            Node node = new Node(data);
            return node;
        }
        public void Push(object data)
        {
            Node newNode = GetNode(data);

            if (Top == null)
            {
                Top = newNode;
                count++;
                return;
            }
            newNode.Next = Top;
            Top = newNode;
            count++;

        }
        public object Peek()
        {
            if (Top != null)
            {
                return Top.Data;
            }
            return -1;
        }
        public object Pop()
        {
            object peek = -1;

            if (Top != null)
            {
                peek = Top.Data;
                Top = Top.Next;
            }
            count--;
            return peek;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }
    }
}
