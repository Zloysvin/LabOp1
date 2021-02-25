namespace LabOp1
{
    using System;
    using System.Reflection.Metadata.Ecma335;

    public class Sorter<T> where T : IComparable<T>
    {
        public T[] SortWithHeapSorting(T[] arrayToSort)
        {
            Heap<T> heap = new Heap<T>(arrayToSort.Length);
            foreach (var itemOfArray in arrayToSort)
            {
                heap.AddItem(itemOfArray);
            }
            return heap.SortedArray;
        }
    }
}