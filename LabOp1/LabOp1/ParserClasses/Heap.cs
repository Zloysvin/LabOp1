namespace LabOp1
{
    using System;
    using System.Reflection.Metadata.Ecma335;

    public class Heap<T> where T : IComparable<T>
    {
        public T[] SortedArray { get; }
        private int amountOfItems;

        public void AddItem(T item)
        {
            SortedArray[amountOfItems] = item;
            amountOfItems++;
            SortUp(amountOfItems - 1);
        }

        private void SortUp(int indexOfSortingUpItem)
        {
            if (indexOfSortingUpItem == 0)
            {
                return;
            }

            var indexOfParentItem = (indexOfSortingUpItem - 1) / 2;

            if (SortedArray[indexOfSortingUpItem].CompareTo(SortedArray[indexOfParentItem]) < 0)
            {
                Swap(indexOfSortingUpItem, indexOfParentItem);
                SortUp(indexOfParentItem);
            }
        }

        private void Swap(int indexOfSortingUpItem, int indexOfParentItem)
        {
            var tmp = SortedArray[indexOfParentItem];
            SortedArray[indexOfParentItem] = SortedArray[indexOfSortingUpItem];
            SortedArray[indexOfSortingUpItem] = tmp;
        }

        public Heap(int maxSize)
        {
            SortedArray = new T[maxSize];
            amountOfItems = 0;
        }
    }
}