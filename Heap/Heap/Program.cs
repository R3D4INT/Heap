namespace Heap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList(10);

            list.Add(4);
            list.Add(10);
            list.Add(3);
            list.Add(5);
            list.Add(2);
            list.Add(9);
            list.Add(15);
            list.Add(1);
            list.Add(7);
            list.Add(6);
            list.Add(0);
            list.Add(0);
            list.Add(0);

            list.BuildHeap(new int[] { 10, 5, 12, 3, 2, 1, 8, 7, 9, 4 });
            list.printList();
            Console.WriteLine("Unsorted:");
            list.printList();
            list.HeapSort(false);
            Console.WriteLine("Sorted:");
            list.printList();
            Console.ReadKey();
        }
    }
}
