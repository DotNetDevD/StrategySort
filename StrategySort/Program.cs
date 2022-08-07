namespace StrategySort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sort = new QuickSort();
            var context = new Context(sort);
            context.Sort();
            sort.Name();
            context.PrintArray();
        }
    }
}