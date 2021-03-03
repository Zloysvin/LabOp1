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

            return Reverse(heap.Sort());
        }

        public T[] Reverse(T[] array)
        {
            T[] reversedArray = new T[array.Lenght];
            for (int i = 0; i < array.Lenght; i++)
            {
                reversedArray[i] = array[array.Lenght - 1 - i];
            }

            return reversedArray;
        }
    }
}