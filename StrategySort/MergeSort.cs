using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySort
{
    internal class MergeSort : Strategy
    {
        public override void Name()
        {
            Console.WriteLine("MergeSort");
        }
        public override void Sort(int[] array)
        {
            if (array.Length == 1)
                return;

            int mid = array.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[array.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = array[i];
            }

            for (int i = mid; i < array.Length; i++)
            {
                right[i - mid] = array[i];
            }

            Sort(left);
            Sort(right);
            Merge(array, left, right);
        }

        public void Merge(int[] dist, int[] left, int[] right)
        {

            int leftIndex = 0;
            int rightIndex = 0;
            int distIndex = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] <= right[rightIndex])
                {
                    dist[distIndex] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    dist[distIndex] = right[rightIndex];
                    rightIndex++;
                }
                distIndex++;
            }

            while (leftIndex < left.Length)
            {
                dist[distIndex] = left[leftIndex];
                leftIndex++;
                distIndex++;
            }

            while (rightIndex < right.Length)
            {
                dist[distIndex] = right[rightIndex];
                rightIndex++;
                distIndex++;
            }
        }

    }
}
