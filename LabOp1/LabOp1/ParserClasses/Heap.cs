namespace LabOp1
{
    using System;
    using System.Reflection.Metadata.Ecma335;

    public class Heap<T> where T : IComparable<T>
    {
        private T[] heapArray;
        private int amountOfItemsInTheHeap;

        public void AddItem(T item)
        {
            heapArray[amountOfItemsInTheHeap] = item;
            amountOfItemsInTheHeap++;
            SortUp(amountOfItemsInTheHeap - 1);
        }

        public T[] Sort()
        {
            var sortedArray = new T[heapArray.Length];

            while (amountOfItemsInTheHeap > 0)
            {
                sortedArray[sortedArray.Length - amountOfItemsInTheHeap] = heapArray[0];
                amountOfItemsInTheHeap--;
                heapArray[0] = heapArray[amountOfItemsInTheHeap];
                SortDown(0);
            }

            return sortedArray;
        }

        private void SortDown(int indexOfSortingDownItem)
        {
            var startOfTheLastStage = GetLastStageStartingIndex(amountOfItemsInTheHeap);

            if (indexOfSortingDownItem >= startOfTheLastStage)
            {
                return;
            }

            var indexOfFirstChild = indexOfSortingDownItem * 2 + 1;
            var indexOfSecondChild = indexOfSortingDownItem * 2 + 2;


            // Item is in right position
            if (heapArray[indexOfSortingDownItem].CompareTo(heapArray[indexOfFirstChild]) < 0
                && heapArray[indexOfSortingDownItem].CompareTo(heapArray[indexOfSecondChild]) < 0)
            {
                return;
            }

            // Item is bigger than right child
            if (heapArray[indexOfSortingDownItem].CompareTo(heapArray[indexOfFirstChild]) < 0
                && heapArray[indexOfSortingDownItem].CompareTo(heapArray[indexOfSecondChild]) >= 0)
            {
                Swap(indexOfSecondChild, indexOfSortingDownItem);
                SortDown(indexOfSecondChild);
                return;
            }

            // Item is bigger than left child
            if (heapArray[indexOfSortingDownItem].CompareTo(heapArray[indexOfFirstChild]) > 0
                && heapArray[indexOfSortingDownItem].CompareTo(heapArray[indexOfSecondChild]) <= 0)
            {
                Swap(indexOfFirstChild, indexOfSortingDownItem);
                SortDown(indexOfFirstChild);
                return;
            }

            // Item is bigger than both childs
            if (heapArray[indexOfFirstChild].CompareTo(heapArray[indexOfSecondChild]) < 0)
            {
                Swap(indexOfFirstChild, indexOfSortingDownItem);
                SortDown(indexOfFirstChild);
            }
            else
            {
                Swap(indexOfSecondChild, indexOfSortingDownItem);
                SortDown(indexOfSecondChild);
            }
        }

        private int GetLastStageStartingIndex(int amountOfItems)
        {
            var stage = 0;
            var indexOfStartStage = 0;

            while (Math.Pow(2, stage + 1) - 1 < amountOfItems)
            {
                stage++;
            }

            indexOfStartStage = (int) Math.Pow(2, stage - 1);

            return indexOfStartStage;
        }

        private void SortUp(int indexOfSortingUpItem)
        {
            if (indexOfSortingUpItem == 0)
            {
                return;
            }

            var indexOfParentItem = (indexOfSortingUpItem - 1) / 2;

            if (heapArray[indexOfSortingUpItem].CompareTo(heapArray[indexOfParentItem]) < 0)
            {
                Swap(indexOfSortingUpItem, indexOfParentItem);
                SortUp(indexOfParentItem);
            }
        }

        private void Swap(int indexOfSortingItem, int indexOfSwappingItem)
        {
            var tmp = heapArray[indexOfSwappingItem];
            heapArray[indexOfSwappingItem] = heapArray[indexOfSortingItem];
            heapArray[indexOfSortingItem] = tmp;
        }

        public Heap(int maxSize)
        {
            heapArray = new T[maxSize];
            amountOfItemsInTheHeap = 0;
        }
    }
}