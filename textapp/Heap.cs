using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textapp
{
    public class Heap
    {
        private int currentSize { get; set; }
        private HeapNode[] HeapArray { get; set; }
        private int maxSize { get; set; }

        public Heap(int maxHeapSize)
        {
            maxSize = maxHeapSize;
            currentSize = 0;
            HeapArray = new HeapNode[maxSize];
        }

        public bool IsEmpty()
        {
            return currentSize == 0;
        }

        public bool Insert(Word value)
        {
            if (currentSize == maxSize)
            {
                return false;
            }
            HeapNode newHeapNode = new HeapNode(value);
            HeapArray[currentSize] = newHeapNode;
            MoveToUp(currentSize++);
            return true;
        }


        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapNode bottom = HeapArray[index];
            while (index > 0 && HeapArray[parent].Value.Frequency < bottom.Value.Frequency)
            {
                HeapArray[index] = HeapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            HeapArray[index] = bottom;
        }

        public HeapNode RemoveMax()
        {
            HeapNode root = HeapArray[0];
            HeapArray[0] = HeapArray[--currentSize];
            MoveToDown(0);
            return root;
        }

        public void MoveToDown(int index)
        {
            int largerChild;
            HeapNode top = HeapArray[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                if (rightChild < currentSize && HeapArray[leftChild].Value.Frequency < HeapArray[rightChild].Value.Frequency)
                {
                    largerChild = rightChild;   
                }
                else
                {
                    largerChild = leftChild;
                }
                if (top.Value.Frequency >= HeapArray[largerChild].Value.Frequency)
                {
                    break;
                }
                HeapArray[index] = HeapArray[largerChild];
                index = largerChild;
            }
            HeapArray[index] = top;
        }

        public Word[] Sort()
        {
            Word[] Sorted = new Word[HeapArray.Length];
            int i = 0;
            while (!this.IsEmpty())
            {
                Sorted[i++] =(Word)this.RemoveMax().Value;
            }
            return Sorted;
        }

    }
}
