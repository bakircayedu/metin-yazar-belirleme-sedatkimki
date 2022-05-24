using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textapp
{
    public class LinkedList : LinkedListADT
    {

        public override string DisplayElements()
        {
            string temp = "";
            Node item = Head;
            while (item != null)
            {
                temp += "-->" + item.Data;
                item = item.Next;
            }

            return temp;
        }

        public override Node GetElementAt(int pos)
        {
            Node node = Head;
            int sum = 0;

            while (node != null)
            {
                if (sum == pos)
                {
                    break;
                }
                else if (node.Next != null)
                {
                    node = node.Next;
                    sum++;
                }
                else break;
            }

            return node;
        }
        public override int GetElementPos(object obj)
        {
            Node head = Head;
            int sum = 0;

            while (head != null)
            {
                if (head.Data == obj)
                {
                    return sum;
                }
                else if (head.Next != null)
                {
                    head = head.Next;
                    sum++;
                }
                else break;
            }

            return -1;
        }

        public override void InsertFirst(object value)
        {
            Node tmpHead = new Node(value);

            if (Head == null) { Head = tmpHead; }
            else
            {
                tmpHead.Next = Head;
                Head = tmpHead;
            }
            Size++;
        }

        public override void InsertLast(object value)
        {
            Node newNode = new Node(value);

            if (Head == null)
            {
                InsertFirst(value);
            }
            else
            {
                Node lastNode = Head;
                while (lastNode != null)
                {
                    if (lastNode.Next != null)
                    {
                        lastNode = lastNode.Next;
                    }
                    else break;
                }
                lastNode.Next = newNode;
                Size++;
            }
        }

        public override void InsertPos(int pos, object value)
        {

            Node newNode = new Node(value);
            Node temp = this.GetElementAt(pos);
            if (temp != null)
            {
                newNode.Next = temp.Next;
                temp.Next = newNode;
                Size++;
            }
        }

        public override void RemoveFirst()
        {
            this.Head = Head.Next;
            Size--;
        }

        public override void RemoveLast()
        {
            Node node = this.Head;
            while (node != null)
            {
                if (node.Next.Next != null)
                {
                    node = node.Next;
                }
                else
                {
                    break;
                }
            }
            node.Next = null;
        }

        public override void RemovePos(int pos)
        {
            if (pos == 0)
            {
                this.RemoveFirst();
            }
            else
            {
                Node temp = this.GetElementAt(pos - 1);
                Node tempNext = this.GetElementAt(pos);

                temp.Next = tempNext.Next;
            }




        }
    
}
}
