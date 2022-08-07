using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySort
{
    internal class Context
    {
        Strategy strategy;
        int[] array = { 3, 5, 7, 6, 4, 2, 8, 1, 9};

        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void Sort()
        {
            strategy.Sort(array);
        }

        public void PrintArray()
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }
    }
}
