using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySort
{
    internal class QuickSort : Strategy
    {
        public override void Name()
        {
            Console.WriteLine("QuickSort");
        }

        public override void Sort(int[] array)
        {
            QuickSorting(array, 0, array.Length - 1);
        }

        /// <summary>
        /// The main function that implements QuickSort
        /// </summary>
        /// <param name="array">Array to be sorted</param>
        /// <param name="left">Starting index</param>
        /// <param name="right">Ending index</param>
        private void QuickSorting(int[] array, int left, int right)
        {
            if (left >= right) return;

            // pivotIndex is partitioning index, array[p] is now at right place
            int pivotIndex = GetPivotIndex(array, left, right);

            // Separately sort elements before GetPivotIndex and after
            QuickSorting(array, left, pivotIndex - 1);
            QuickSorting(array, pivotIndex + 1, right);
        }

        /* This function takes last element as pivot, places
           the pivot element at its correct position in sorted
           array, and places all smaller (smaller than pivot)
           to left of pivot and all greater elements to right
           of pivot */
        private int GetPivotIndex(int[] array, int left, int right)
        {
            int pivot = array[right];

            /* Index of smaller element and 
               indicates the right position of pivot found so far */
            int wall = left - 1;

            for (int i = left; i <= right; i++)
            {
                // If current element is smaller than the pivot
                if (array[i] <= pivot)
                {
                    // Increment index of smaller element
                    wall++;
                    Swop(ref array[wall], ref array[i]);
                }
            }
            // Now is the right position of pivot
            return wall;
        }

        // A utility function to swap two elements
        private void Swop(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}
