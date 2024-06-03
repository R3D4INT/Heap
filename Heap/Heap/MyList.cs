using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    public class MyList
    {
        private int[] data;
        private int maxSize;
        private int currentSize;

        public MyList(int size)
        {
            maxSize = size;
            data = new int[maxSize];
            currentSize = 0;
        }

        public bool isEmpty()
        {
            return currentSize == 0;
        }

        public bool isFull()
        {
            return currentSize == maxSize;
        }

        public void printList()
        {
            Console.WriteLine("List:");
            for (var i = 0; i < currentSize; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
        }

        public void HeapSort(bool ascending)
        {
            for (var i = data.Length / 2 - 1; i >= 0; i--)
            {
                Heapify(data, data.Length, i, ascending);
            }

            for (var i = data.Length - 1; i >= 0; i--)
            {
                (data[0], data[i]) = (data[i], data[0]);

                Heapify(data, i, 0, ascending);
            }
        }
        public void BuildHeap(int[] data)
        {
            var n = data.Length;
            for (var i = n / 2; i > 0; i--)
            {
                Heapify(data, n, i, true);
            }

            this.data = data;
        }

        private void Heapify(int[] arr, int n, int i, bool ascending)
        {
            var largest = i;
            var l = 2 * i + 1;
            var r = 2 * i + 2;
            if (ascending)
            {
                if (l < n && arr[l] > arr[largest])
                {
                    largest = l;
                }
                if (r < n && arr[r] > arr[largest])
                {
                    largest = r;
                }
            }
            else
            {
                if (l < n && arr[l] < arr[largest])
                {
                    largest = l;
                }
                if (r < n && arr[r] < arr[largest])
                {
                    largest = r;
                }
            }

            if (largest != i)
            {
                (arr[i], arr[largest]) = (arr[largest], arr[i]);
                Heapify(arr, n, largest, ascending);
            }
        }
        public void Add(int item)
        {
            if (isFull())
            {
                Console.WriteLine("List is full.");
                return;
            }
            data[currentSize++] = item;
        }
        public int Size()
        {
            return currentSize;
        }
    }
}
